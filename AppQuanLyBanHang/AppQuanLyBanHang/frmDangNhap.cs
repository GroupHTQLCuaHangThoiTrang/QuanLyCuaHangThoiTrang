using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace AppQuanLyBanHang
{
    public partial class frmDangNhap : Form
    {

        UserBLL userbll = new UserBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lb_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();
            quenMatKhau.ShowDialog();
        }
        private void lb_DangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }


        public static string _email;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string email = tb_tentk.Text;
            string matkhau = tb_MatKhau.Text;

            if (tb_tentk.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap ten tai khoan!");
                return;
            }
            else if (tb_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau vao!");
                return;
            }
            else
            {
                if(!userbll.CheckCorrect_Email(tb_tentk.Text))
                {
                    MessageBox.Show("Email đăng nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!userbll.CheckCorrect_Password(tb_tentk.Text, tb_MatKhau.Text))
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _email = tb_tentk.Text;
                        //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMain frm = new frmMain();
                        frm.Show();
                    }
                }
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
