using System;

namespace QuanCafe
{
    partial class TableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.xMLToSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click_1);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click_1);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // xMLToSQLToolStripMenuItem
            // 
            this.xMLToSQLToolStripMenuItem.Name = "xMLToSQLToolStripMenuItem";
            this.xMLToSQLToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.xMLToSQLToolStripMenuItem.Text = "XML to SQL";
            this.xMLToSQLToolStripMenuItem.Click += new System.EventHandler(this.xMLToSQLToolStripMenuItem_Click_1);
            this.xMLToSQLToolStripMenuItem.DoubleClick += new System.EventHandler(this.xmlToSQLToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(442, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 383);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(441, 383);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.btnTotal);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(442, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 62);
            this.panel3.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(120, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(120, 3);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(91, 28);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Thành tiền";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(14, 34);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(91, 21);
            this.cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(14, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(91, 28);
            this.btnSwitchTable.TabIndex = 3;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click_1);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(226, 35);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(91, 20);
            this.nmDiscount.TabIndex = 2;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(226, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(91, 28);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(330, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(106, 52);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteDish);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(442, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 59);
            this.panel4.TabIndex = 4;
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Location = new System.Drawing.Point(354, 13);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(72, 38);
            this.btnDeleteDish.TabIndex = 4;
            this.btnDeleteDish.Text = "Xóa món";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(303, 24);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(45, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(225, 13);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(72, 38);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click_1);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(208, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged_1);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(0, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(436, 450);
            this.flpTable.TabIndex = 5;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 492);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ToolStripMenuItem xMLToSQLToolStripMenuItem;
    }
}