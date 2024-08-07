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
    public partial class frmNhanvien : Form
    {
        UserBLL userbll = new UserBLL();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            dtgvNhanvien.DataSource = userbll.Load_User();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập First name");
                return;
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email");
                return;
            }
            else
            {
                try
                {
                    User newuser = new User();
                    newuser.user_first_name = txtFirstname.Text;
                    newuser.user_last_name = txtLastname.Text;
                    newuser.email = txtEmail.Text;
                    newuser.password = txtPassword.Text;

                    if (rdo_Admin.Checked)
                    {
                        newuser.is_admin = true;
                    }
                    else if (rdo_Nhanvien.Checked)
                    {
                        newuser.is_admin = false;
                    }

                    if (userbll.Add_User(newuser))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dtgvNhanvien.DataSource = userbll.Load_User();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thêm thất bại! Lỗi: {ex.Message}");
                }
            }
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bool check = userbll.Delete_User(Convert.ToInt32(dtgvNhanvien.Rows[dtgvNhanvien.CurrentRow.Index].Cells[0].Value.ToString()));
            if (check == true)
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvNhanvien.DataSource = userbll.Load_User();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            User _user = new User();
            _user.user_id = Convert.ToInt32(dtgvNhanvien.CurrentRow.Cells[0].Value);
            _user.user_first_name = txtFirstname.Text;
            _user.user_last_name = txtLastname.Text;
            _user.email = txtEmail.Text;
            _user.password = txtPassword.Text;
            if(rdo_Admin.Checked)
            {
                _user.is_admin = true;
            }
            else if(rdo_Nhanvien.Checked)
            {
                _user.is_admin = false;
            }

            if(userbll.Update_User(_user))
            {
                MessageBox.Show("Cập nhật thành công!");
                dtgvNhanvien.DataSource = userbll.Load_User();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }    
        }

        private void dtgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                txtFirstname.Text = dtgvNhanvien.CurrentRow.Cells[1].Value.ToString();
                txtLastname.Text = dtgvNhanvien.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dtgvNhanvien.CurrentRow.Cells[3].Value.ToString();
                txtPassword.Text = dtgvNhanvien.CurrentRow.Cells[4].Value.ToString();
                bool is_admin = (bool)(dtgvNhanvien.CurrentRow.Cells[5].Value);
                if(is_admin == true)
                {
                    rdo_Admin.Checked = true;
                }
                else
                {
                    rdo_Nhanvien.Checked = true;
                }
            }    
        }
    }
}
