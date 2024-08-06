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
    public partial class frmHoaDon : Form
    {
        HoadonBLL hdbll = new HoadonBLL();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtgv_HoaDon.DataSource = hdbll.load_Order();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            dtgv_HoaDon.DataSource = hdbll.load_Order();
        }
    }
}
