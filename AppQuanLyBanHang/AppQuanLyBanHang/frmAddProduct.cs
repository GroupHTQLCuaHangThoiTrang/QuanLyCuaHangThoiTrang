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
    public partial class frmAddProduct : Form
    {

        SamPhamBLL sp = new SamPhamBLL();

        DataTable table = new DataTable();
        private DataGridView _dtgv_product;
        public frmAddProduct(DataGridView dtgv_product)
        {
            InitializeComponent();
            _dtgv_product = dtgv_product;
            LoadDS();
        }

        public void LoadDS()
        {
            cbo_Brand.DataSource = sp.Load_Brand();
            cbo_Brand.DisplayMember = "brand_name";

            cbo_Category.DataSource = sp.Load_Category();
            cbo_Category.DisplayMember = "category_name";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Product newpr = new Product();
            newpr.product_name = txt_ProductName.Text;
            newpr.brand_id = sp.Get_IdBrand_ByBrandName(cbo_Brand.Text);
            newpr.category_id = sp.Get_IdCategory_ByCategoryName(cbo_Category.Text);
            newpr.short_des = txt_shortdes.Text;
            newpr.full_des = txt_fulldes.Text;
            newpr.price_discount = Convert.ToInt32(txt_GiaDiscount.Text);
            newpr.price = Convert.ToInt32(txt_Gia.Text);
            newpr.avatar = txt_Avatar.Text;
            newpr.soluong = Convert.ToInt32(txt_Soluong.Text);
            if (sp.Add_Product(newpr))
            {
                MessageBox.Show("Thêm thành công!");
                _dtgv_product.DataSource = sp.Load_AllSanPham();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void frmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Lưu hình ảnh vào đường dẫn cụ thể
                    string resourcesFolderPath = Path.Combine(Application.StartupPath, "Resources");
                    Directory.CreateDirectory(resourcesFolderPath);
                    string imageName = Path.GetFileName(openFileDialog.FileName);
                    string destinationFilePath = Path.Combine(resourcesFolderPath, imageName);

                    // Copy hình ảnh đến đường dẫn cụ thể
                    File.Copy(openFileDialog.FileName, destinationFilePath, true);

                    txt_Avatar.Text = imageName;
                }
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
