using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient; 
namespace QuanCafe
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=TUANTHANH\\MSSQLSERVER1;Initial Catalog=QLCAFE;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername(object sender, EventArgs e)
        {

        }

        private void txtPassword(object sender, EventArgs e)
        {

        }

        private void logginBtn(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Account WHERE userName = @username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["psword"].ToString() != password)
                            {
                                MessageBox.Show("Mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show("Đăng nhập thành công!");
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
