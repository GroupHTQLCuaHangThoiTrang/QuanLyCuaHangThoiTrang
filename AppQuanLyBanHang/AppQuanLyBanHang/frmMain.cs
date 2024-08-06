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
    public partial class frmMain : Form
    {
        UserBLL userbll = new UserBLL();
        public frmMain()
        {
            InitializeComponent();
        }

        

        public void LockForm()
        {
            if(!userbll.isAdmin(frmDangNhap._email))
            {
                tsmiQuanLy.Enabled = false;
            }    
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LockForm();
        }

        private void tsmiSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.ShowDialog();
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKho frm = new frmKho();
            frm.ShowDialog();
        }
    }
}
