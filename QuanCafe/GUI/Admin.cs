using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanCafe.GUI
{
    public partial class Admin : Form
    {
        // --- CẤU HÌNH ---
        private string connectionString = @"Data Source=TUANTHANH\MSSQLSERVER1;Initial Catalog=QLCAFE;Integrated Security=True";

        BindingSource foodList = new BindingSource();

        public Admin()
        {
            InitializeComponent();

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);

            dtgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
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

        object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
            }
            return data;
        }
        #endregion

        #region LOGIC XML (XỬ LÝ FILE FOOD.XML)

        string xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Food.xml");

        void EnsureXmlExists()
        {
            if (!File.Exists(xmlPath)) new XDocument(new XElement("Foods")).Save(xmlPath);
        }

        void InsertFoodXml(int id, string name, double price, int idType)
        {
            try
            {
                EnsureXmlExists();
                XDocument doc = XDocument.Load(xmlPath);

                XElement newFood = new XElement("Food",
                    new XElement("id", id),
                    new XElement("foodname", name),
                    new XElement("price", price),
                    new XElement("idType", idType)
                );
                doc.Root.Add(newFood);
                doc.Save(xmlPath);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu XML: " + ex.Message); }
        }

        void UpdateFoodXml(int id, string name, double price, int idType)
        {
            try
            {
                if (File.Exists(xmlPath))
                {
                    XDocument doc = XDocument.Load(xmlPath);
                    var food = doc.Descendants("Food").FirstOrDefault(x => x.Element("id").Value == id.ToString());

                    if (food != null)
                    {
                        food.Element("foodname").Value = name;
                        food.Element("price").Value = price.ToString();
                        food.Element("idType").Value = idType.ToString();
                        doc.Save(xmlPath);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa XML: " + ex.Message); }
        }

        void DeleteFoodXml(int id)
        {
            try
            {
                if (File.Exists(xmlPath))
                {
                    XDocument doc = XDocument.Load(xmlPath);
                    var food = doc.Descendants("Food").FirstOrDefault(x => x.Element("id").Value == id.ToString());
                    if (food != null)
                    {
                        food.Remove();
                        doc.Save(xmlPath);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa XML: " + ex.Message); }
        }

        #endregion

        #region LOGIC TAB THỨC ĂN (FOOD)

        void LoadListFood()
        {
            string query = "SELECT id as [ID], foodname as [Tên Món], idType as [ID Danh Mục], price as [Giá] FROM Food";
            foodList.DataSource = ExecuteQuery(query);
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = ExecuteQuery("SELECT * FROM CategoryFood");
            cb.DisplayMember = "nameType";
            cb.ValueMember = "idType";
        }

        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Clear();
            txbFoodID.DataBindings.Clear();
            txbFoodPrice.DataBindings.Clear();

            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Tên Món", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));

            Binding priceBinding = new Binding("Text", dtgvFood.DataSource, "Giá", true, DataSourceUpdateMode.Never);
            priceBinding.FormatString = "N0";
            priceBinding.NullValue = "0";
            txbFoodPrice.DataBindings.Add(priceBinding);

            txbFoodID.TextChanged += TxbFoodID_TextChanged;
        }

        private void TxbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0 && dtgvFood.SelectedCells[0].OwningRow.Cells["ID Danh Mục"].Value != null)
                {
                    int idType = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["ID Danh Mục"].Value;
                    cbFoodCategory.SelectedValue = idType;
                }
            }
            catch { }
        }

        // --- CÁC NÚT THAO TÁC FOOD ---

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        // --- NÚT THÊM 
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (int)cbFoodCategory.SelectedValue;

            float price = 0;
            string priceString = txbFoodPrice.Text.Replace(",", "").Replace(".", "");
            float.TryParse(priceString, out price);

            string query = string.Format("INSERT dbo.Food ( foodname, idType, price ) VALUES  ( N'{0}', {1}, {2})", name, categoryID, price);

            if (ExecuteNonQuery(query) > 0)
            {
                MessageBox.Show("Thêm món thành công (Đã lưu SQL & XML)");

                try
                {
                    object result = ExecuteScalar("SELECT MAX(id) FROM Food");
                    int newID = Convert.ToInt32(result);

                    InsertFoodXml(newID, name, price, categoryID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đồng bộ XML: " + ex.Message);
                }

                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn vào Database");
            }
        }

        // --- NÚT SỬA 
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbFoodID.Text))
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!", "Thông báo");
                return;
            }

            int id = Convert.ToInt32(txbFoodID.Text);
            string name = txbFoodName.Text;
            int categoryID = (int)cbFoodCategory.SelectedValue;

            string priceString = txbFoodPrice.Text.Replace(",", "").Replace(".", "").Trim();
            float price = 0;
            if (!float.TryParse(priceString, out price))
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                return;
            }

            string query = string.Format(new System.Globalization.CultureInfo("en-US"),
                "UPDATE dbo.Food SET foodname = N'{0}', idType = {1}, price = {2} WHERE id = {3}",
                name, categoryID, price, id);

            if (ExecuteNonQuery(query) > 0)
            {
                MessageBox.Show("Sửa món thành công");
                UpdateFoodXml(id, name, price, categoryID); 
                LoadListFood(); 
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa! (Có thể do ID không tồn tại hoặc lỗi kết nối)");
            }
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbFoodID.Text)) return;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (MessageBox.Show("Bạn có chắc muốn xóa món này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExecuteNonQuery("DELETE FROM BillInfo WHERE idFood = " + id);

                string query = string.Format("Delete Food where id = {0}", id);

                if (ExecuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Xóa món thành công ");

                    DeleteFoodXml(id); 

                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thức ăn");
                }
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string name = txbSearchFoodName.Text;
            string query = string.Format("SELECT id as [ID], foodname as [Tên Món], idType as [ID Danh Mục], price as [Giá] FROM dbo.Food WHERE foodname LIKE N'%{0}%'", name);
            foodList.DataSource = ExecuteQuery(query);
        }

        #endregion

        #region LOGIC TAB THỐNG KÊ (QUAN TRỌNG)

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                string query = string.Format(@"
                    SELECT 
                        b.id AS [ID Hóa Đơn], 
                        t.nameTable AS [Tên Bàn], 
                        b.totalPrice AS [Tổng tiền], 
                        b.dateCheckIn AS [Ngày vào], 
                        b.dateCheckOut AS [Ngày ra], 
                        b.discount AS [Giảm giá]
                    FROM dbo.Bill AS b
                    JOIN dbo.Seat AS t ON b.idSeat = t.id
                    WHERE b.dateCheckOut >= '{0}' AND b.dateCheckOut <= '{1}' AND b.status = 1",
                    checkIn.ToString("yyyy-MM-dd 00:00:00"),
                    checkOut.ToString("yyyy-MM-dd 23:59:59")
                );

                DataTable data = ExecuteQuery(query);
                dtgvStatictis.DataSource = data; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message);
            }
        }

        private void btnStatictis_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void tpBill_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void tpFood_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tcBill_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tpCategory_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dtpToDate_ValueChanged(object sender, EventArgs e) { }
        private void Admin_Load(object sender, EventArgs e) { }
        private void btnAddCategory_Click(object sender, EventArgs e) { }
        private void dtgvStatictis_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dtgvFoods_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}