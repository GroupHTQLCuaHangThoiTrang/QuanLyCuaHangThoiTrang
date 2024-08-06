using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using DTO;

namespace AppQuanLyBanHang
{
    public partial class frmSanPham : Form
    {
        SamPhamBLL sp = new SamPhamBLL();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = sp.Load_AllSanPham();
            dtgv_Brand.DataSource = sp.Load_Brand();
            cbo_Brand.DataSource = sp.Load_Brand();
            cbo_Brand.DisplayMember = "brand_name";

            dtgv_Category.DataSource = sp.Load_Category();
            cbo_Category.DataSource = sp.Load_Category();
            cbo_Category.DisplayMember = "category_name";

            cboDanhMuc.Items.Add("--All--");
            var list_item = sp.Load_Category();
            foreach (var item in list_item)
            {
                cboDanhMuc.Items.Add(item.category_name);
            }
            cboDanhMuc.SelectedIndex = 0;
        }

        public void SortProduct()
        {
            if (cboDanhMuc.Text == "--All--")
            {
                dtgvSanPham.DataSource = sp.Load_AllSanPham();
            }
            if (cboDanhMuc.Text == "Áo")
            {
                dtgvSanPham.DataSource = sp.Load_Ao();
            }
            if (cboDanhMuc.Text == "Quần")
            {
                dtgvSanPham.DataSource = sp.Load_Quan();
            }
            if (cboDanhMuc.Text == "Túi xách")
            {
                dtgvSanPham.DataSource = sp.Load_Tuixach();
            }
            if (cboDanhMuc.Text == "Đồng Hồ")
            {
                dtgvSanPham.DataSource = sp.Load_Dongho();
            }
            if (cboDanhMuc.Text == "Giày")
            {
                dtgvSanPham.DataSource = sp.Load_Giay();
            }
        }

        private void cboDanhMuc_TextChanged(object sender, EventArgs e)
        {
            SortProduct();
        }

        private void dtgvSanPham_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == _previousIndex)
            {
                _sortDirection ^= true; // toggle direction
            }
            dtgvSanPham.DataSource = SortData((List<Product>)dtgvSanPham.DataSource, dtgvSanPham.Columns[e.ColumnIndex].Name, _sortDirection);
            _previousIndex = e.ColumnIndex;
        }
        private int _previousIndex;
        private bool _sortDirection;

        public List<Product> SortData(List<Product> list, string column, bool ascending)
        {
            return ascending ?
                list.OrderBy(_ => _.GetType().GetProperty(column).GetValue(_)).ToList() :
                list.OrderByDescending(_ => _.GetType().GetProperty(column).GetValue(_)).ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool check = sp.Delete_Product(Convert.ToInt32(dtgvSanPham.Rows[dtgvSanPham.CurrentRow.Index].Cells[0].Value.ToString()));
            if (check == true)
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SortProduct();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvSanPham.Rows[dtgvSanPham.CurrentRow.Index].Cells[0].Value);
            string ten = txtTenSanPham.Text.ToString();
            double gia = Convert.ToDouble(txtGiaSanPham.Text);
            int brand = 0;
            List<BrandDTO> brands = sp.Load_Brand();
            for (int i = 0; i < brands.Count(); i++)
            {
                if (String.Compare(brands[i].brand_name, cbo_Brand.Text.ToString(), false) == 0)
                {
                    brand = brands[i].brand_id;
                    break;
                }
            }
            bool check = sp.Update_Product(id, ten, gia, brand);
            if (check == true)
            {
                MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SortProduct();
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSanPham.Text = dtgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtGiaSanPham.Text = dtgvSanPham.CurrentRow.Cells[6].Value.ToString();
            int brandID = Convert.ToInt32(dtgvSanPham.CurrentRow.Cells[2].Value);
            cbo_Brand.Text = sp.Get_BrandName_ByProductName(brandID);
            int cateID = Convert.ToInt32(dtgvSanPham.CurrentRow.Cells[3].Value);
            cbo_Category.Text = sp.Get_CategoryName_ByProductName(cateID);
            txtGiaDiscount.Text = dtgvSanPham.CurrentRow.Cells[7].Value.ToString();
            txt_Soluong.Text = dtgvSanPham.CurrentRow.Cells[9].Value.ToString();
            string img = dtgvSanPham.CurrentRow.Cells[8].Value.ToString();
            try
            {
                string baseDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;

                string relativePath = Path.Combine("Resources", img);
                string imagePath = Path.Combine(baseDirectory, relativePath);
                
                Image avatar = Image.FromFile(imagePath); //"C:\\Users\\Asus\\Documents\\HOCTAP\\Phat trien phan mem\\AppQuanLyBanHang\\AppQuanLyBanHang\\Resources\\"+img
                pic_SanPham.Image = avatar;
                pic_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pic_SanPham.Image = null;
            }

            txt_shortdes.Text = dtgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txt_fulldes.Text = dtgvSanPham.CurrentRow.Cells[5].Value.ToString();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct(dtgvSanPham);
            frm.ShowDialog();

            if(frm.IsDisposed)
            {
                dtgvSanPham.DataSource = sp.Load_AllSanPham();
            }    
            //Product newpr = new Product();
            //newpr.product_name = txtTenSanPham.Text;
            //newpr.brand_id = sp.Get_IdBrand_ByBrandName(cbo_Brand.Text);
            //newpr.category_id = sp.Get_IdCategory_ByCategoryName(cbo_Category.Text);
            //newpr.short_des = txt_shortdes.Text;
            //newpr.full_des = txt_fulldes.Text;
            //newpr.price_discount = Convert.ToInt32(txtGiaDiscount.Text);
            //newpr.price = Convert.ToInt32(txtGiaSanPham.Text);
            //newpr.soluong = Convert.ToInt32(txt_Soluong.Text);
            //if (sp.Add_Product(newpr))
            //{
            //    MessageBox.Show("Thêm thành công!");
            //    dtgvSanPham.DataSource = sp.Load_AllSanPham();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại!");
            //}
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in group_Text.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }

            foreach (Control control in group_Text.Controls)
            {
                if (control is RichTextBox)
                {
                    ((RichTextBox)control).Text = string.Empty;
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.category_name = txt_CateName.Text;
            if(sp.Add_Category(cate))
            {
                MessageBox.Show("Thêm loại sản phẩm mới thành công");
                dtgv_Category.DataSource = null;
                dtgv_Category.DataSource = sp.Load_Category();
            }    
            else
            {
                MessageBox.Show("Thêm loại sản phẩm mới thất bại");
            }    
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgv_Category.CurrentRow.Cells[0].Value.ToString());
            if (sp.Delete_Category(id))
            {
                MessageBox.Show("Xóa thành công!");
                dtgv_Category.DataSource = null;
                dtgv_Category.DataSource = sp.Load_Category();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }    
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.category_id = Convert.ToInt32(dtgv_Category.CurrentRow.Cells[0].Value);
            cate.category_name = txt_CateName.Text;
            if(sp.Update_Category(cate))
            {
                MessageBox.Show("Sửa thành công");
                dtgv_Category.DataSource = null;
                dtgv_Category.DataSource = sp.Load_Category();
            }    
            else
            {
                MessageBox.Show("Sửa thất bại");
            }    
        }

        private void dtgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CateName.Text = dtgv_Category.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_Them_Brand_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            br.brand_name = txt_BrandName.Text;
            if (sp.Add_Brand(br))
            {
                MessageBox.Show("Thêm loại sản phẩm mới thành công");
                dtgv_Brand.DataSource = null;
                dtgv_Brand.DataSource = sp.Load_Brand();
            }
            else
            {
                MessageBox.Show("Thêm loại sản phẩm mới thất bại");
            }
        }

        private void btn_Sua_Brand_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            br.brand_id = Convert.ToInt32(dtgv_Brand.CurrentRow.Cells[0].Value);
            br.brand_name= txt_BrandName.Text;
            if (sp.Update_Brand(br))
            {
                MessageBox.Show("Sửa thành công");
                dtgv_Brand.DataSource = null;
                dtgv_Brand.DataSource = sp.Load_Brand();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Xoa_Brand_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgv_Brand.CurrentRow.Cells[0].Value.ToString());
            if (sp.Delete_Brand(id))
            {
                MessageBox.Show("Xóa thành công!");
                dtgv_Brand.DataSource = null;
                dtgv_Brand.DataSource = sp.Load_Brand();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dtgv_Brand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BrandName.Text = dtgv_Brand.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
