using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Loads(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin(object sender, EventArgs e)
        {
            string username = txtUserName.Text; 
            string password = txtPassWord.Text;
            Class.Login lg = new Class.Login();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
            }
            else
            {
                if(lg.checkLogin(username,password))
                {
                    MessageBox.Show("Đăng nhập thành công"); 
                    TableManager mn = new TableManager();
                    this.Hide();    
                    mn.Show(); 
                }
                else
                    MessageBox.Show("Đăng nhập không thành công! Tài khoản hoặc mật khẩu sai!"); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;    
        }
    }
}
