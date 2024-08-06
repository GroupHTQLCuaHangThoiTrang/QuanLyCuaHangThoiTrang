
namespace AppQuanLyBanHang
{
    partial class frmKho
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
            this.dtgvPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.groupText_Kho = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cb_TenSanPham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapKho)).BeginInit();
            this.groupText_Kho.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvPhieuNhapKho
            // 
            this.dtgvPhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhapKho.Location = new System.Drawing.Point(52, 116);
            this.dtgvPhieuNhapKho.Name = "dtgvPhieuNhapKho";
            this.dtgvPhieuNhapKho.Size = new System.Drawing.Size(527, 298);
            this.dtgvPhieuNhapKho.TabIndex = 32;
            this.dtgvPhieuNhapKho.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvPhieuNhapKho_ColumnHeaderMouseClick);
            // 
            // groupText_Kho
            // 
            this.groupText_Kho.Controls.Add(this.btn_Tinh);
            this.groupText_Kho.Controls.Add(this.btn_Them);
            this.groupText_Kho.Controls.Add(this.label4);
            this.groupText_Kho.Controls.Add(this.txtDonGia);
            this.groupText_Kho.Controls.Add(this.label5);
            this.groupText_Kho.Controls.Add(this.lbThanhTien);
            this.groupText_Kho.Controls.Add(this.txtSoLuong);
            this.groupText_Kho.Controls.Add(this.cb_TenSanPham);
            this.groupText_Kho.Controls.Add(this.label3);
            this.groupText_Kho.Controls.Add(this.label2);
            this.groupText_Kho.Controls.Add(this.label1);
            this.groupText_Kho.Location = new System.Drawing.Point(52, 25);
            this.groupText_Kho.Name = "groupText_Kho";
            this.groupText_Kho.Size = new System.Drawing.Size(527, 85);
            this.groupText_Kho.TabIndex = 33;
            this.groupText_Kho.TabStop = false;
            this.groupText_Kho.Text = "Thông tin phiếu nhập";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(434, 57);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(87, 23);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thành tiền:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(231, 54);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(96, 20);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "VNĐ";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Location = new System.Drawing.Point(410, 29);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(0, 13);
            this.lbThanhTien.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(103, 54);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 20);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cb_TenSanPham
            // 
            this.cb_TenSanPham.FormattingEnabled = true;
            this.cb_TenSanPham.Location = new System.Drawing.Point(103, 26);
            this.cb_TenSanPham.Name = "cb_TenSanPham";
            this.cb_TenSanPham.Size = new System.Drawing.Size(224, 21);
            this.cb_TenSanPham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Location = new System.Drawing.Point(341, 57);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(87, 23);
            this.btn_Tinh.TabIndex = 10;
            this.btn_Tinh.Text = "Thành tiền";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(379, 434);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(200, 23);
            this.btn_In.TabIndex = 34;
            this.btn_In.Text = "In Phiếu Nhập Kho";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 469);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.groupText_Kho);
            this.Controls.Add(this.dtgvPhieuNhapKho);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapKho)).EndInit();
            this.groupText_Kho.ResumeLayout(false);
            this.groupText_Kho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhieuNhapKho;
        private System.Windows.Forms.GroupBox groupText_Kho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cb_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Button btn_In;
    }
}