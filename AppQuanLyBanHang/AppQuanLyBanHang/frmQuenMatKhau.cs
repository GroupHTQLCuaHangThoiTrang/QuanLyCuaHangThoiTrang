using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyBanHang
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }

        //Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí");
            }
            else
            {
                //string query = "Select * from Users Where Email='" + email + "'";
                //if (modify.Userss(query).Count != 0)
                //{
                //    label2.ForeColor = Color.Blue;
                //    label2.Text = "Mat Khau: " + modify.Userss(query)[0].MatKhau;
                //}
                //else
                //{
                //    label2.ForeColor = Color.Red;
                //    label2.Text = "Email này đã đươc đăng ký";
                //}
            }
        }
    }
}
