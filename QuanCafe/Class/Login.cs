using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QuanCafe.Class
{
    public class Login
    {
        public bool checkLogin(string username, string password)
        {
            DataSet ds = new DataSet();
            string path = Path.Combine(Application.StartupPath, "Account.xml");

            if (!File.Exists(path))
            {
                MessageBox.Show("File Account.xml không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ds.ReadXml(path);

            if (!ds.Tables.Contains("Account"))
            {
                MessageBox.Show("File XML không có bảng Account!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DataTable table = ds.Tables["Account"];
            foreach (DataRow row in table.Rows)
            {
                if (row["username"].ToString() == username && row["password"].ToString() == password)
                    return true;
            }

            return false;
        }
    }
}
