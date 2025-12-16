namespace QuanCafe
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(90)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(90)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogin.Location = new System.Drawing.Point(198, 142);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(115, 34);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.btnLogin);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.txtUserName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUserName.Location = new System.Drawing.Point(176, 24);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(274, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPassWord.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.txtPassWord.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPassWord.Location = new System.Drawing.Point(176, 90);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(274, 29);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(336, 142);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(491, 201);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnClose;
    }
}