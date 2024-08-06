
namespace AppQuanLyBanHang
{
    partial class frmSanPham
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fulldes = new System.Windows.Forms.RichTextBox();
            this.txt_shortdes = new System.Windows.Forms.RichTextBox();
            this.pic_SanPham = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.txtGiaDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Brand = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.group_Text = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_CateName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgv_Category = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Xoa_Brand = new System.Windows.Forms.Button();
            this.btn_Sua_Brand = new System.Windows.Forms.Button();
            this.btn_Them_Brand = new System.Windows.Forms.Button();
            this.dtgv_Brand = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_BrandName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).BeginInit();
            this.group_Text.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Brand)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgvSanPham);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboDanhMuc);
            this.tabPage1.Controls.Add(this.group_Text);
            this.tabPage1.Controls.Add(this.btnTroVe);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Xoa);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Controls.Add(this.btn_Them);
            this.tabPage2.Controls.Add(this.dtgv_Category);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_CateName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(6, 322);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.Size = new System.Drawing.Size(914, 298);
            this.dtgvSanPham.TabIndex = 31;
            this.dtgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanPham_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mô tả dài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mô tả ngắn";
            // 
            // txt_fulldes
            // 
            this.txt_fulldes.Location = new System.Drawing.Point(339, 131);
            this.txt_fulldes.Name = "txt_fulldes";
            this.txt_fulldes.Size = new System.Drawing.Size(194, 65);
            this.txt_fulldes.TabIndex = 30;
            this.txt_fulldes.Text = "";
            // 
            // txt_shortdes
            // 
            this.txt_shortdes.Location = new System.Drawing.Point(339, 32);
            this.txt_shortdes.Name = "txt_shortdes";
            this.txt_shortdes.Size = new System.Drawing.Size(194, 65);
            this.txt_shortdes.TabIndex = 30;
            this.txt_shortdes.Text = "";
            // 
            // pic_SanPham
            // 
            this.pic_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_SanPham.Location = new System.Drawing.Point(663, 6);
            this.pic_SanPham.Name = "pic_SanPham";
            this.pic_SanPham.Size = new System.Drawing.Size(250, 250);
            this.pic_SanPham.TabIndex = 29;
            this.pic_SanPham.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thương hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sort:";
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Location = new System.Drawing.Point(112, 213);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(121, 20);
            this.txt_Soluong.TabIndex = 27;
            // 
            // txtGiaDiscount
            // 
            this.txtGiaDiscount.Location = new System.Drawing.Point(112, 177);
            this.txtGiaDiscount.Name = "txtGiaDiscount";
            this.txtGiaDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtGiaDiscount.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Số lượng";
            // 
            // txtGiaSanPham
            // 
            this.txtGiaSanPham.Location = new System.Drawing.Point(112, 67);
            this.txtGiaSanPham.Name = "txtGiaSanPham";
            this.txtGiaSanPham.Size = new System.Drawing.Size(121, 20);
            this.txtGiaSanPham.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Giá discount";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(112, 36);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(121, 20);
            this.txtTenSanPham.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // cbo_Brand
            // 
            this.cbo_Brand.FormattingEnabled = true;
            this.cbo_Brand.Location = new System.Drawing.Point(112, 107);
            this.cbo_Brand.Name = "cbo_Brand";
            this.cbo_Brand.Size = new System.Drawing.Size(121, 21);
            this.cbo_Brand.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Loại sản phẩm";
            // 
            // cbo_Category
            // 
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(112, 142);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(121, 21);
            this.cbo_Category.TabIndex = 22;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(799, 295);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cboDanhMuc.TabIndex = 38;
            this.cboDanhMuc.TextChanged += new System.EventHandler(this.cboDanhMuc_TextChanged);
            // 
            // group_Text
            // 
            this.group_Text.Controls.Add(this.label6);
            this.group_Text.Controls.Add(this.label5);
            this.group_Text.Controls.Add(this.txt_fulldes);
            this.group_Text.Controls.Add(this.txt_shortdes);
            this.group_Text.Controls.Add(this.btnLamMoi);
            this.group_Text.Controls.Add(this.pic_SanPham);
            this.group_Text.Controls.Add(this.label3);
            this.group_Text.Controls.Add(this.txt_Soluong);
            this.group_Text.Controls.Add(this.txtGiaDiscount);
            this.group_Text.Controls.Add(this.label7);
            this.group_Text.Controls.Add(this.txtGiaSanPham);
            this.group_Text.Controls.Add(this.label8);
            this.group_Text.Controls.Add(this.txtTenSanPham);
            this.group_Text.Controls.Add(this.label2);
            this.group_Text.Controls.Add(this.label1);
            this.group_Text.Controls.Add(this.cbo_Brand);
            this.group_Text.Controls.Add(this.label9);
            this.group_Text.Controls.Add(this.cbo_Category);
            this.group_Text.Location = new System.Drawing.Point(6, 6);
            this.group_Text.Name = "group_Text";
            this.group_Text.Size = new System.Drawing.Size(914, 257);
            this.group_Text.TabIndex = 30;
            this.group_Text.TabStop = false;
            this.group_Text.Text = "Thông tin sản phẩm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(339, 219);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 36;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(936, 6);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 35;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(328, 288);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(178, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Xoa_Brand);
            this.tabPage3.Controls.Add(this.btn_Sua_Brand);
            this.tabPage3.Controls.Add(this.btn_Them_Brand);
            this.tabPage3.Controls.Add(this.dtgv_Brand);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_BrandName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thương hiệu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_CateName
            // 
            this.txt_CateName.Location = new System.Drawing.Point(154, 34);
            this.txt_CateName.Name = "txt_CateName";
            this.txt_CateName.Size = new System.Drawing.Size(140, 20);
            this.txt_CateName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên loại sản phẩm";
            // 
            // dtgv_Category
            // 
            this.dtgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Category.Location = new System.Drawing.Point(57, 76);
            this.dtgv_Category.Name = "dtgv_Category";
            this.dtgv_Category.Size = new System.Drawing.Size(369, 176);
            this.dtgv_Category.TabIndex = 2;
            this.dtgv_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Category_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(462, 76);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(462, 128);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(462, 182);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Xoa_Brand
            // 
            this.btn_Xoa_Brand.Location = new System.Drawing.Point(460, 182);
            this.btn_Xoa_Brand.Name = "btn_Xoa_Brand";
            this.btn_Xoa_Brand.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa_Brand.TabIndex = 7;
            this.btn_Xoa_Brand.Text = "Xóa";
            this.btn_Xoa_Brand.UseVisualStyleBackColor = true;
            this.btn_Xoa_Brand.Click += new System.EventHandler(this.btn_Xoa_Brand_Click);
            // 
            // btn_Sua_Brand
            // 
            this.btn_Sua_Brand.Location = new System.Drawing.Point(460, 128);
            this.btn_Sua_Brand.Name = "btn_Sua_Brand";
            this.btn_Sua_Brand.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua_Brand.TabIndex = 8;
            this.btn_Sua_Brand.Text = "Sửa";
            this.btn_Sua_Brand.UseVisualStyleBackColor = true;
            this.btn_Sua_Brand.Click += new System.EventHandler(this.btn_Sua_Brand_Click);
            // 
            // btn_Them_Brand
            // 
            this.btn_Them_Brand.Location = new System.Drawing.Point(460, 76);
            this.btn_Them_Brand.Name = "btn_Them_Brand";
            this.btn_Them_Brand.Size = new System.Drawing.Size(75, 23);
            this.btn_Them_Brand.TabIndex = 9;
            this.btn_Them_Brand.Text = "Thêm";
            this.btn_Them_Brand.UseVisualStyleBackColor = true;
            this.btn_Them_Brand.Click += new System.EventHandler(this.btn_Them_Brand_Click);
            // 
            // dtgv_Brand
            // 
            this.dtgv_Brand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Brand.Location = new System.Drawing.Point(55, 76);
            this.dtgv_Brand.Name = "dtgv_Brand";
            this.dtgv_Brand.Size = new System.Drawing.Size(369, 176);
            this.dtgv_Brand.TabIndex = 6;
            this.dtgv_Brand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Brand_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên thương hiệu";
            // 
            // txt_BrandName
            // 
            this.txt_BrandName.Location = new System.Drawing.Point(152, 34);
            this.txt_BrandName.Name = "txt_BrandName";
            this.txt_BrandName.Size = new System.Drawing.Size(140, 20);
            this.txt_BrandName.TabIndex = 4;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).EndInit();
            this.group_Text.ResumeLayout(false);
            this.group_Text.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Brand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.GroupBox group_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_fulldes;
        private System.Windows.Forms.RichTextBox txt_shortdes;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.PictureBox pic_SanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Soluong;
        private System.Windows.Forms.TextBox txtGiaDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Brand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgv_Category;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CateName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa_Brand;
        private System.Windows.Forms.Button btn_Sua_Brand;
        private System.Windows.Forms.Button btn_Them_Brand;
        private System.Windows.Forms.DataGridView dtgv_Brand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_BrandName;
    }
}