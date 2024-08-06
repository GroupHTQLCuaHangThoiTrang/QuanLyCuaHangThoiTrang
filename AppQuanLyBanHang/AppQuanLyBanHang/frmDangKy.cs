using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AppQuanLyBanHang
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public bool checkedAccount(string ac)//check mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$ ");
        }
        public bool CheckEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com.(.vn|)$");
        }
        //Modify modify = new Modify();
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            //string tenTk = tb_tenTK.Text;
            //string MatKhau = tb_MatKhau.Text;
            //string xacNhanMatKhau = tb_XacNhanMK.Text;
            //string Email = tb_Email.Text;

            //if (xacNhanMatKhau != MatKhau)
            //{
            //    MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
            //    return;
            //}

            //if (modify.Userss("Select * from TaiKhoan where Email = '" + Email + "'").Count != 0)
            //{
            //    MessageBox.Show("Email này đã được đăng kí , vui lòng nhập email khác");
            //}
            //try
            //{
            //    string query = "Insert into TaiKhoan values ('" + tenTk + "','" + MatKhau + "','" + Email + "')";
            //    modify.Command(query);
            //    this.Hide();
            //    frmDangNhap mn = new frmDangNhap();
            //    mn.ShowDialog();
            //    mn = null;
            //    this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Tên Tài Khoản này đã được đăng ký, vui lòng đăng kí tài khoản khác!");
            //}
        }
    }
}
