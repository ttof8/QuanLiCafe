using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using QuanCafe.GUI;

namespace QuanCafe
{
    public partial class TableManager : Form
    {
        private string connectionString = @"Data Source=TUANTHANH\MSSQLSERVER1;Initial Catalog=QLCAFE;Integrated Security=True";

        private double currentTotalPrice = 0;

        public TableManager()
        {
            InitializeComponent();
        }

        #region DATABASE HELPER

        DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }

        object ExecuteScalar(string query)
        {
            object data = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
            }
            return data;
        }

        int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
            }
            return data;
        }

        #endregion

        #region LOGIC XỬ LÝ XML (BILL & SEAT)
        // Xuat Bill
        void ExportBillToExistingXml(int idBillDB, int idSeat, int discount, double finalTotalPrice)
        {
            try
            {
                string pathBill = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bill.xml");
                string pathBillInfo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BillInfor.xml");

                if (!File.Exists(pathBill)) new XDocument(new XElement("Bills")).Save(pathBill);
                if (!File.Exists(pathBillInfo)) new XDocument(new XElement("BillInfos")).Save(pathBillInfo);

                string queryDetails = @"SELECT idFood, count FROM BillInfo WHERE idBill = " + idBillDB;
                DataTable dtDetails = ExecuteQuery(queryDetails);

                XDocument docBill = XDocument.Load(pathBill);
                int newXmlBillId = 1;
                if (docBill.Descendants("Bill").Any())
                    newXmlBillId = docBill.Descendants("Bill").Max(x => (int)x.Element("id")) + 1;

                XElement newBillNode = new XElement("Bill",
                    new XElement("id", newXmlBillId),
                    new XElement("dateCheckIn", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")),
                    new XElement("dateCheckOut", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")),
                    new XElement("discount", discount),
                    new XElement("total", finalTotalPrice),
                    new XElement("idSeat", idSeat)
                );
                docBill.Root.Add(newBillNode);
                docBill.Save(pathBill);

                XDocument docBillInfo = XDocument.Load(pathBillInfo);
                int currentXmlInfoId = 0;
                if (docBillInfo.Descendants("BillInfo").Any())
                    currentXmlInfoId = docBillInfo.Descendants("BillInfo").Max(x => (int)x.Element("id"));

                foreach (DataRow row in dtDetails.Rows)
                {
                    currentXmlInfoId++;
                    XElement newInfoNode = new XElement("BillInfo",
                        new XElement("id", currentXmlInfoId),
                        new XElement("idFood", row["idFood"]),
                        new XElement("count", row["count"]),
                        new XElement("idBill", newXmlBillId)
                    );
                    docBillInfo.Root.Add(newInfoNode);
                }
                docBillInfo.Save(pathBillInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi XML Bill: " + ex.Message);
            }
        }

        // Cap nhat trang thai Seat
        void UpdateSeatStatusXml(int idSeat, string newStatus)
        {
            try
            {
                string pathSeat = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seat.xml");

                if (!File.Exists(pathSeat))
                {
                    new XDocument(new XElement("Seats")).Save(pathSeat);
                }

                XDocument doc = XDocument.Load(pathSeat);
                var seatElement = doc.Descendants("Seat").FirstOrDefault(x => (int)x.Element("id") == idSeat);

                if (seatElement != null)
                {
                    seatElement.Element("statusTable").Value = newStatus;
                    doc.Save(pathSeat);
                }
                else
                {
                    XElement newSeat = new XElement("Seat",
                        new XElement("id", idSeat),
                        new XElement("nameTable", "Bàn " + idSeat),
                        new XElement("statusTable", newStatus)
                    );
                    doc.Root.Add(newSeat);
                    doc.Save(pathSeat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật Seat.xml: " + ex.Message);
            }
        }

        #endregion

        #region LOAD DATA & LOGIC

        private void TableManager_Load(object sender, EventArgs e)
        {

            lsvBill.View = View.Details;
            lsvBill.GridLines = true;
            lsvBill.FullRowSelect = true;


            lsvBill.Columns.Clear();
            lsvBill.Columns.Add("Tên món", 140);
            lsvBill.Columns.Add("SL", 50);
            lsvBill.Columns.Add("Đơn giá", 90);
            lsvBill.Columns.Add("Thành tiền", 100);

            try
            {
                LoadTable();
                LoadCategory();
                LoadComboboxTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            DataTable dt = ExecuteQuery("SELECT * FROM Seat");

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 90;

                string name = row["nameTable"].ToString();
                string status = row["statusTable"].ToString();

                btn.Text = name + Environment.NewLine + status;
                btn.Tag = row["id"];
                btn.Click += btn_Click;

                if (status == "Trống") btn.BackColor = Color.Aqua;
                else btn.BackColor = Color.LightPink;

                flpTable.Controls.Add(btn);
            }
        }

        void LoadComboboxTable()
        {
            cbSwitchTable.DataSource = ExecuteQuery("SELECT * FROM Seat");
            cbSwitchTable.DisplayMember = "nameTable";
            cbSwitchTable.ValueMember = "id";
        }

        void LoadCategory()
        {
            cbCategory.DataSource = ExecuteQuery("SELECT * FROM CategoryFood");
            cbCategory.DisplayMember = "nameType";
            cbCategory.ValueMember = "idType";
        }

        void LoadFoodListByCategoryID(int idType)
        {
            cbFood.DataSource = ExecuteQuery("SELECT * FROM Food WHERE idType = " + idType);
            cbFood.DisplayMember = "foodname";
            cbFood.ValueMember = "id";
        }

        int GetUncheckBillID_Direct(int idSeat)
        {
            DataTable data = ExecuteQuery("SELECT * FROM Bill WHERE idSeat = " + idSeat + " AND status = 0");
            if (data.Rows.Count > 0)
                return (int)data.Rows[0]["id"];
            return -1;
        }

        void ShowBill(int idSeat)
        {
            lsvBill.Items.Clear();
            currentTotalPrice = 0;

            int idBill = GetUncheckBillID_Direct(idSeat);

            if (idBill != -1)
            {
                string query = @"SELECT f.id, f.foodname, bi.count, f.price, f.price * bi.count AS totalPrice 
                                 FROM BillInfo bi
                                 JOIN Bill b ON bi.idBill = b.id
                                 JOIN Food f ON bi.idFood = f.id
                                 WHERE b.id = " + idBill;

                DataTable dt = ExecuteQuery(query);

                foreach (DataRow item in dt.Rows)
                {
                    ListViewItem lsvItem = new ListViewItem(item["foodname"].ToString());
                    lsvItem.SubItems.Add(item["count"].ToString());
                    double price = Convert.ToDouble(item["price"]);
                    double total = Convert.ToDouble(item["totalPrice"]);
                    lsvItem.SubItems.Add(price.ToString("#,###", new CultureInfo("vi-VN")));
                    lsvItem.SubItems.Add(total.ToString("#,###", new CultureInfo("vi-VN")));
                    lsvItem.Tag = item["id"];

                    currentTotalPrice += total;
                    lsvBill.Items.Add(lsvItem);
                }
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            if (txtTotal != null)
            {
                txtTotal.Text = currentTotalPrice.ToString("c", culture);
            }
        }

        #endregion

        #region EVENTS (Sự kiện)

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.Tag == null) return;

            int tableID = int.Parse(btn.Tag.ToString());
            lsvBill.Tag = btn.Tag;

            ShowBill(tableID);

            LoadSwitchableTables(tableID);
        }
        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue == null) return;

            int id = 0;
            if (cb.SelectedValue is int) id = (int)cb.SelectedValue;
            else if (cb.SelectedValue is DataRowView row) id = (int)row["idType"];

            if (id > 0) LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lsvBill.Tag == null) { MessageBox.Show("Hãy chọn bàn trước!"); return; }
                if (cbFood.SelectedValue == null) { MessageBox.Show("Chưa chọn món!"); return; }

                int idSeat = int.Parse(lsvBill.Tag.ToString());
                int idFood = (int)cbFood.SelectedValue;
                int count = (int)nmFoodCount.Value;

                int idBill = GetUncheckBillID_Direct(idSeat);

                if (idBill == -1)
                {
                    if (count <= 0) return;
                    ExecuteNonQuery("INSERT INTO Bill (dateCheckIn, dateCheckOut, idSeat, status) VALUES (GETDATE(), NULL, " + idSeat + ", 0)");

                    ExecuteNonQuery("UPDATE Seat SET statusTable = N'Có khách' WHERE id = " + idSeat);

                    UpdateSeatStatusXml(idSeat, "Có khách");

                    idBill = (int)ExecuteScalar("SELECT MAX(id) FROM Bill WHERE idSeat = " + idSeat);
                }

                DataTable dtCheck = ExecuteQuery("SELECT count FROM BillInfo WHERE idBill = " + idBill + " AND idFood = " + idFood);
                if (dtCheck.Rows.Count > 0)
                {
                    int currentCount = Convert.ToInt32(dtCheck.Rows[0]["count"]);
                    int newCount = currentCount + count;
                    if (newCount > 0) ExecuteNonQuery("UPDATE BillInfo SET count = " + newCount + " WHERE idBill = " + idBill + " AND idFood = " + idFood);
                    else ExecuteNonQuery("DELETE FROM BillInfo WHERE idBill = " + idBill + " AND idFood = " + idFood);
                }
                else
                {
                    if (count > 0) ExecuteNonQuery("INSERT INTO BillInfo (idBill, idFood, count) VALUES (" + idBill + ", " + idFood + ", " + count + ")");
                }

                ShowBill(idSeat);
                LoadTable();
                nmFoodCount.Value = 1;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm món: " + ex.Message); }
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null) return;
            int idSeat = int.Parse(lsvBill.Tag.ToString());
            int idBill = GetUncheckBillID_Direct(idSeat);

            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvBill.SelectedItems[0];
                int idFood = (int)item.Tag;

                if (idBill != -1)
                {
                    ExecuteNonQuery("DELETE FROM BillInfo WHERE idBill = " + idBill + " AND idFood = " + idFood);

                    object countResult = ExecuteScalar("SELECT COUNT(*) FROM BillInfo WHERE idBill = " + idBill);
                    int remainingItems = (countResult != null) ? Convert.ToInt32(countResult) : 0;

                    if (remainingItems == 0)
                    {
                        ExecuteNonQuery("DELETE FROM Bill WHERE id = " + idBill);

                        ExecuteNonQuery("UPDATE Seat SET statusTable = N'Trống' WHERE id = " + idSeat);

                        UpdateSeatStatusXml(idSeat, "Trống");

                        MessageBox.Show("Đã xóa món cuối cùng. Bàn trở về trạng thái Trống.");
                        LoadTable();
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa món: " + item.Text);
                    }

                    ShowBill(idSeat);
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null) return;
            int idSeat = int.Parse(lsvBill.Tag.ToString());
            int idBill = GetUncheckBillID_Direct(idSeat);

            if (idBill != -1)
            {
                int discount = (int)nmDiscount.Value;
                double finalTotalPrice = currentTotalPrice - (currentTotalPrice / 100) * discount;

                string strTotal = finalTotalPrice.ToString("c", new CultureInfo("vi-VN"));
                string msg = $"Bạn có chắc thanh toán cho bàn {idSeat}?\n" +
                             $"Tổng tiền gốc: {currentTotalPrice.ToString("#,###")}\n" +
                             $"Giảm giá: {discount}%\n" +
                             $"CẦN THANH TOÁN: {strTotal}";

                if (MessageBox.Show(msg, "Xác nhận thanh toán", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ExportBillToExistingXml(idBill, idSeat, discount, finalTotalPrice);

                    ExecuteNonQuery("UPDATE Bill SET dateCheckOut = GETDATE(), status = 1, discount = " + discount + ", totalPrice = " + finalTotalPrice.ToString(CultureInfo.InvariantCulture) + " WHERE id = " + idBill);
                    ExecuteNonQuery("UPDATE Seat SET statusTable = N'Trống' WHERE id = " + idSeat);

                    UpdateSeatStatusXml(idSeat, "Trống");

                    MessageBox.Show("Thanh toán thành công!", "Thông báo");

                    ShowBill(idSeat);
                    LoadTable();
                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null) { MessageBox.Show("Hãy chọn bàn muốn chuyển đi!"); return; }

            if (cbSwitchTable.SelectedValue == null) { MessageBox.Show("Không còn bàn trống để chuyển!"); return; }

            int idOldTable = int.Parse(lsvBill.Tag.ToString());
            int idNewTable = (int)cbSwitchTable.SelectedValue;

            int idBill = GetUncheckBillID_Direct(idOldTable);

            if (idBill == -1)
            {
                MessageBox.Show("Bàn hiện tại đang trống, không có món để chuyển!");
                return;
            }

            if (MessageBox.Show($"Chuyển toàn bộ món từ bàn {idOldTable} sang bàn {idNewTable}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ExecuteNonQuery("UPDATE Bill SET idSeat = " + idNewTable + " WHERE id = " + idBill);

                    ExecuteNonQuery("UPDATE Seat SET statusTable = N'Trống' WHERE id = " + idOldTable);
                    ExecuteNonQuery("UPDATE Seat SET statusTable = N'Có khách' WHERE id = " + idNewTable);

                    UpdateSeatStatusXml(idOldTable, "Trống");
                    UpdateSeatStatusXml(idNewTable, "Có khách");

                    MessageBox.Show("Chuyển bàn thành công!");

                    LoadTable();

                    ShowBill(idNewTable);
                    lsvBill.Tag = idNewTable;

                    LoadSwitchableTables(idNewTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển bàn: " + ex.Message);
                }
            }
        }

        void LoadSwitchableTables(int currentTableID)
        {
            string query = "SELECT * FROM Seat WHERE statusTable = N'Trống' AND id != " + currentTableID;
            DataTable dt = ExecuteQuery(query);

            cbSwitchTable.DataSource = dt;
            cbSwitchTable.DisplayMember = "nameTable";
            cbSwitchTable.ValueMember = "id";

            btnSwitchTable.Enabled = (dt.Rows.Count > 0);
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag != null)
            {
                int idSeat = int.Parse(lsvBill.Tag.ToString());
                ShowBill(idSeat);
            }
        }

        private void flpTable_Paint(object sender, PaintEventArgs e) { }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnSwitchTable_Click_1(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();

        }

        // --- SỰ KIỆN CLICK MENU ---
        private void xmlToSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncAllData();
        }

        // --- HÀM TỔNG: ĐIỀU PHỐI VÀ HIỆN THÔNG BÁO CHUNG ---
        void SyncAllData()
        {
            try
            {
                // Gọi từng hàm và hứng lấy thông báo kết quả trả về
                string msgCategory = SyncCategoryXml(); // Đồng bộ Danh mục
                string msgTable = SyncTableXml();       // Đồng bộ Bàn ăn
                string msgFood = SyncFoodXml();         // Đồng bộ Món ăn

                // Tạo thông báo tổng hợp
                string finalMessage = string.Format(
                    "ĐỒNG BỘ DỮ LIỆU HOÀN TẤT!\n\n" +
                    "{0}\n" +
                    "{1}\n" +
                    "{2}",
                    msgCategory, msgTable, msgFood);

                MessageBox.Show(finalMessage, "Kết quả đồng bộ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình đồng bộ: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // HÀM 1: ĐỒNG BỘ DANH MỤC (Trả về thông báo string)
        // ---------------------------------------------------------
        string SyncCategoryXml()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CategoryFood.xml");
            if (!File.Exists(path)) return "- Danh mục: Không tìm thấy file XML (Bỏ qua)";

            int inserted = 0, updated = 0;
            XDocument doc = XDocument.Load(path);

            foreach (XElement item in doc.Descendants("Category"))
            {
                int id = int.Parse(item.Element("id").Value);
                string name = item.Element("name").Value.Replace("'", "''");

                if ((int)ExecuteScalar("SELECT COUNT(*) FROM CategoryFood WHERE id = " + id) > 0)
                {
                    ExecuteNonQuery(string.Format("UPDATE CategoryFood SET name = N'{0}' WHERE id = {1}", name, id));
                    updated++;
                }
                else
                {
                    string query = string.Format(
                        "SET IDENTITY_INSERT CategoryFood ON; " +
                        "INSERT INTO CategoryFood (id, name) VALUES ({0}, N'{1}'); " +
                        "SET IDENTITY_INSERT CategoryFood OFF;", id, name);
                    ExecuteNonQuery(query);
                    inserted++;
                }
            }
            return string.Format("- Danh mục: Thêm mới {0}, Cập nhật {1}", inserted, updated);
        }

        // ---------------------------------------------------------
        // HÀM 2: ĐỒNG BỘ BÀN ĂN (Trả về thông báo string)
        // ---------------------------------------------------------
        string SyncTableXml()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seat.xml");
            if (!File.Exists(path)) return "- Bàn ăn: Không tìm thấy file XML (Bỏ qua)";

            int inserted = 0, updated = 0;
            XDocument doc = XDocument.Load(path);

            foreach (XElement item in doc.Descendants("Table"))
            {
                int id = int.Parse(item.Element("id").Value);
                string name = item.Element("name").Value.Replace("'", "''");
                string status = item.Element("status").Value.Replace("'", "''");

                if ((int)ExecuteScalar("SELECT COUNT(*) FROM Seat WHERE id = " + id) > 0)
                {
                    ExecuteNonQuery(string.Format("UPDATE Seat SET name = N'{0}', status = N'{1}' WHERE id = {2}", name, status, id));
                    updated++;
                }
                else
                {
                    string query = string.Format(
                        "SET IDENTITY_INSERT Seat ON; " +
                        "INSERT INTO Seat (id, name, status) VALUES ({0}, N'{1}', N'{2}'); " +
                        "SET IDENTITY_INSERT Seat OFF;", id, name, status);
                    ExecuteNonQuery(query);
                    inserted++;
                }
            }
            return string.Format("- Bàn ăn: Thêm mới {0}, Cập nhật {1}", inserted, updated);
        }

        // ---------------------------------------------------------
        // HÀM 3: ĐỒNG BỘ MÓN ĂN (Trả về thông báo string)
        // ---------------------------------------------------------
        string SyncFoodXml()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Food.xml");
            if (!File.Exists(path)) return "- Món ăn: Không tìm thấy file XML (Bỏ qua)";

            int inserted = 0, updated = 0;
            XDocument doc = XDocument.Load(path);

            foreach (XElement item in doc.Descendants("Food"))
            {
                int id = int.Parse(item.Element("id").Value);
                string name = item.Element("foodname").Value.Replace("'", "''");
                float price = float.Parse(item.Element("price").Value);
                int idType = int.Parse(item.Element("idType").Value);

                if ((int)ExecuteScalar("SELECT COUNT(*) FROM Food WHERE id = " + id) > 0)
                {
                    ExecuteNonQuery(string.Format("UPDATE Food SET foodname = N'{0}', price = {1}, idType = {2} WHERE id = {3}", name, price, idType, id));
                    updated++;
                }
                else
                {
                    string query = string.Format(
                        "SET IDENTITY_INSERT Food ON; " +
                        "INSERT INTO Food (id, foodname, idType, price) VALUES ({0}, N'{1}', {2}, {3}); " +
                        "SET IDENTITY_INSERT Food OFF;", id, name, idType, price);
                    ExecuteNonQuery(query);
                    inserted++;
                }
            }
            return string.Format("- Món ăn: Thêm mới {0}, Cập nhật {1}", inserted, updated);
        }
        #endregion

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void xMLToSQLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SyncAllData();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}