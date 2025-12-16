namespace QuanCafe.GUI
{
    partial class Admin
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
            this.dtgvStatistics = new System.Windows.Forms.DataGridView();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.Statictis = new System.Windows.Forms.Button();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbFoodPrice = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.lbNameFood = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStatictis = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvStatictis = new System.Windows.Forms.DataGridView();
            this.tcBill = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistics)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatictis)).BeginInit();
            this.tcBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvStatistics
            // 
            this.dtgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatistics.Location = new System.Drawing.Point(3, 3);
            this.dtgvStatistics.Name = "dtgvStatistics";
            this.dtgvStatistics.RowHeadersWidth = 51;
            this.dtgvStatistics.RowTemplate.Height = 24;
            this.dtgvStatistics.Size = new System.Drawing.Size(1103, 516);
            this.dtgvStatistics.TabIndex = 0;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(29, 17);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(866, 17);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 1;
            // 
            // Statictis
            // 
            this.Statictis.Location = new System.Drawing.Point(478, 12);
            this.Statictis.Name = "Statictis";
            this.Statictis.Size = new System.Drawing.Size(92, 36);
            this.Statictis.TabIndex = 2;
            this.Statictis.Text = "Thống kê";
            this.Statictis.UseVisualStyleBackColor = true;
            this.Statictis.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpFood
            // 
            this.tpFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.tpFood.Controls.Add(this.dtgvFood);
            this.tpFood.Controls.Add(this.panel8);
            this.tpFood.Controls.Add(this.panel7);
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(842, 476);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.Click += new System.EventHandler(this.tpFood_Click);
            // 
            // dtgvFood
            // 
            this.dtgvFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(15, 82);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(448, 384);
            this.dtgvFood.TabIndex = 3;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFoods_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnEditFood);
            this.panel8.Controls.Add(this.btnDeleteFood);
            this.panel8.Controls.Add(this.btnAddFood);
            this.panel8.Location = new System.Drawing.Point(470, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 72);
            this.panel8.TabIndex = 0;
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditFood.Location = new System.Drawing.Point(271, 12);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(85, 46);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDeleteFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteFood.Location = new System.Drawing.Point(147, 12);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(85, 46);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFood.Location = new System.Drawing.Point(18, 12);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(85, 46);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(470, 82);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 384);
            this.panel7.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.panel12.Controls.Add(this.txbFoodPrice);
            this.panel12.Controls.Add(this.lbCost);
            this.panel12.Location = new System.Drawing.Point(18, 178);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(338, 37);
            this.panel12.TabIndex = 4;
            // 
            // txbFoodPrice
            // 
            this.txbFoodPrice.Location = new System.Drawing.Point(139, 7);
            this.txbFoodPrice.Name = "txbFoodPrice";
            this.txbFoodPrice.Size = new System.Drawing.Size(185, 20);
            this.txbFoodPrice.TabIndex = 4;
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.lbCost.Location = new System.Drawing.Point(16, 6);
            this.lbCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(31, 19);
            this.lbCost.TabIndex = 3;
            this.lbCost.Text = "Giá";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.panel11.Controls.Add(this.cbFoodCategory);
            this.panel11.Controls.Add(this.labelCategory);
            this.panel11.Location = new System.Drawing.Point(18, 124);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(338, 37);
            this.panel11.TabIndex = 4;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(139, 7);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(185, 21);
            this.cbFoodCategory.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.labelCategory.Location = new System.Drawing.Point(16, 6);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(78, 19);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Danh mục";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.panel10.Controls.Add(this.txbFoodName);
            this.panel10.Controls.Add(this.lbNameFood);
            this.panel10.Location = new System.Drawing.Point(18, 73);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(338, 37);
            this.panel10.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txbFoodName.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.txbFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.txbFoodName.Location = new System.Drawing.Point(139, 6);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(185, 25);
            this.txbFoodName.TabIndex = 2;
            // 
            // lbNameFood
            // 
            this.lbNameFood.AutoSize = true;
            this.lbNameFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.lbNameFood.Location = new System.Drawing.Point(16, 6);
            this.lbNameFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(68, 19);
            this.lbNameFood.TabIndex = 3;
            this.lbNameFood.Text = "Tên món";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.panel9.Controls.Add(this.txbFoodID);
            this.panel9.Controls.Add(this.lbId);
            this.panel9.Location = new System.Drawing.Point(18, 15);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(338, 37);
            this.panel9.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txbFoodID.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.txbFoodID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.txbFoodID.Location = new System.Drawing.Point(139, 6);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(185, 25);
            this.txbFoodID.TabIndex = 2;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.lbId.Location = new System.Drawing.Point(16, 6);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 19);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "ID";
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Controls.Add(this.btnSearchFood);
            this.panel6.Controls.Add(this.txbSearchFoodName);
            this.panel6.Location = new System.Drawing.Point(15, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 72);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchFood.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchFood.Location = new System.Drawing.Point(316, 12);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(85, 46);
            this.btnSearchFood.TabIndex = 3;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = false;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.txbSearchFoodName.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.txbSearchFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.txbSearchFoodName.Location = new System.Drawing.Point(45, 25);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(237, 25);
            this.txbSearchFoodName.TabIndex = 4;
            // 
            // tpBill
            // 
            this.tpBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.tpBill.Controls.Add(this.panel4);
            this.tpBill.Controls.Add(this.panel3);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(842, 476);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = " Doanh thu";
            this.tpBill.Click += new System.EventHandler(this.tpBill_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnStatictis);
            this.panel4.Controls.Add(this.dtpFromDate);
            this.panel4.Controls.Add(this.dtpToDate);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 52);
            this.panel4.TabIndex = 1;
            // 
            // btnStatictis
            // 
            this.btnStatictis.BackColor = System.Drawing.Color.Navy;
            this.btnStatictis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatictis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnStatictis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatictis.Location = new System.Drawing.Point(368, 7);
            this.btnStatictis.Name = "btnStatictis";
            this.btnStatictis.Size = new System.Drawing.Size(100, 37);
            this.btnStatictis.TabIndex = 3;
            this.btnStatictis.Text = "Thống kê";
            this.btnStatictis.UseVisualStyleBackColor = false;
            this.btnStatictis.Click += new System.EventHandler(this.btnStatictis_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFromDate.Location = new System.Drawing.Point(33, 10);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(260, 27);
            this.dtpFromDate.TabIndex = 4;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dtpToDate.Location = new System.Drawing.Point(536, 10);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(260, 27);
            this.dtpToDate.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvStatictis);
            this.panel3.Location = new System.Drawing.Point(8, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 410);
            this.panel3.TabIndex = 0;
            // 
            // dtgvStatictis
            // 
            this.dtgvStatictis.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvStatictis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatictis.Location = new System.Drawing.Point(2, 0);
            this.dtgvStatictis.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvStatictis.Name = "dtgvStatictis";
            this.dtgvStatictis.RowHeadersWidth = 51;
            this.dtgvStatictis.RowTemplate.Height = 24;
            this.dtgvStatictis.Size = new System.Drawing.Size(826, 408);
            this.dtgvStatictis.TabIndex = 0;
            this.dtgvStatictis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStatictis_CellContentClick);
            // 
            // tcBill
            // 
            this.tcBill.Controls.Add(this.tpBill);
            this.tcBill.Controls.Add(this.tpFood);
            this.tcBill.Location = new System.Drawing.Point(10, 12);
            this.tcBill.Name = "tcBill";
            this.tcBill.SelectedIndex = 0;
            this.tcBill.Size = new System.Drawing.Size(850, 502);
            this.tcBill.TabIndex = 0;
            this.tcBill.SelectedIndexChanged += new System.EventHandler(this.tcBill_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(876, 531);
            this.Controls.Add(this.tcBill);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistics)).EndInit();
            this.tpFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpBill.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatictis)).EndInit();
            this.tcBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvStatistics;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Button Statictis;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txbFoodPrice;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label lbNameFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStatictis;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvStatictis;
        private System.Windows.Forms.TabControl tcBill;
    }
}