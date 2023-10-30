using System;
using System.Windows.Forms;

namespace QuanLyQuanCafe
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
            this.stripAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.stripInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFoodByIdCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiamGia = new Guna.UI2.WinForms.Guna2Button();
            this.nmGiamGia = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.cbSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAdmin,
            this.stripInfor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripAdmin
            // 
            this.stripAdmin.Name = "stripAdmin";
            this.stripAdmin.Size = new System.Drawing.Size(67, 24);
            this.stripAdmin.Text = "Admin";
            this.stripAdmin.Click += new System.EventHandler(this.stripAdmin_Click);
            // 
            // stripInfor
            // 
            this.stripInfor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.stripInfor.Name = "stripInfor";
            this.stripInfor.Size = new System.Drawing.Size(151, 24);
            this.stripInfor.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(410, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 593);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.nmFoodCount);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cbFoodByIdCategory);
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Controls.Add(this.btnAddFood);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 142);
            this.panel5.TabIndex = 1;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmFoodCount.ForeColor = System.Drawing.Color.Black;
            this.nmFoodCount.Location = new System.Drawing.Point(123, 91);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(54, 30);
            this.nmFoodCount.TabIndex = 9;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category :";
            // 
            // cbFoodByIdCategory
            // 
            this.cbFoodByIdCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbFoodByIdCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFoodByIdCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodByIdCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbFoodByIdCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFoodByIdCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFoodByIdCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFoodByIdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFoodByIdCategory.ItemHeight = 30;
            this.cbFoodByIdCategory.Location = new System.Drawing.Point(123, 44);
            this.cbFoodByIdCategory.Name = "cbFoodByIdCategory";
            this.cbFoodByIdCategory.Size = new System.Drawing.Size(262, 36);
            this.cbFoodByIdCategory.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(123, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(262, 36);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Black;
            this.btnAddFood.Location = new System.Drawing.Point(426, 30);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(113, 77);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 152);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(558, 438);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Đồ Uống";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 101;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.guna2Panel2);
            this.panel4.Controls.Add(this.btnGiamGia);
            this.panel4.Controls.Add(this.nmGiamGia);
            this.panel4.Controls.Add(this.guna2Panel1);
            this.panel4.Location = new System.Drawing.Point(974, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 432);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(130, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "%";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.txtThanhTien);
            this.guna2Panel2.Location = new System.Drawing.Point(6, 106);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(177, 119);
            this.guna2Panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tổng tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "0";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(11, 57);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(149, 38);
            this.txtThanhTien.TabIndex = 13;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiamGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiamGia.FillColor = System.Drawing.Color.Red;
            this.btnGiamGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.ForeColor = System.Drawing.Color.Black;
            this.btnGiamGia.Location = new System.Drawing.Point(17, 363);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(149, 45);
            this.btnGiamGia.TabIndex = 11;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.nmGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmGiamGia.ForeColor = System.Drawing.Color.Red;
            this.nmGiamGia.Location = new System.Drawing.Point(17, 289);
            this.nmGiamGia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(112, 36);
            this.nmGiamGia.TabIndex = 10;
            this.nmGiamGia.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnThanhToan);
            this.guna2Panel1.Location = new System.Drawing.Point(6, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(177, 100);
            this.guna2Panel1.TabIndex = 8;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(11, 7);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(149, 80);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackColor = System.Drawing.Color.Yellow;
            this.btnChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyen.FillColor = System.Drawing.Color.Yellow;
            this.btnChuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyen.ForeColor = System.Drawing.Color.Black;
            this.btnChuyen.Location = new System.Drawing.Point(126, 567);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(149, 45);
            this.btnChuyen.TabIndex = 9;
            this.btnChuyen.Text = "Chuyển bàn";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSwitchTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSwitchTable.ItemHeight = 30;
            this.cbSwitchTable.Location = new System.Drawing.Point(126, 514);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(149, 36);
            this.cbSwitchTable.TabIndex = 7;
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.BackColor = System.Drawing.Color.Yellow;
            this.flowTable.Location = new System.Drawing.Point(0, 31);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(404, 466);
            this.flowTable.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.LightCoral;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(991, 514);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 69);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng :";
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1169, 624);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.cbSwitchTable);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void flowTable_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripAdmin;
        private System.Windows.Forms.ToolStripMenuItem stripInfor;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwitchTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmGiamGia;
        private Guna.UI2.WinForms.Guna2Button btnChuyen;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2Button btnGiamGia;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFoodByIdCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddFood;
        private Label label5;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}