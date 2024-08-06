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
using DTO;
using AppQuanLyBanHang.Lib;
using Aspose.Words;
using Aspose.Words.Tables;
using System.IO;

namespace AppQuanLyBanHang
{
    public partial class frmKho : Form
    {
        KhoBLL kh = new KhoBLL();

        SamPhamBLL sp = new SamPhamBLL();

        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dtgvPhieuNhapKho.DataSource = null;
            dtgvPhieuNhapKho.DataSource = kh.Load_Kho();

            cb_TenSanPham.DataSource = null;
            cb_TenSanPham.DataSource = sp.Load_AllSanPham();
            cb_TenSanPham.DisplayMember = "product_name";

            foreach (Control control in groupText_Kho.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
            lbThanhTien.Text = "";

        }

        private void dtgvPhieuNhapKho_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == _previousIndex)
            {
                _sortDirection ^= true; // toggle direction
            }
            dtgvPhieuNhapKho.DataSource = SortData((List<Product>)dtgvPhieuNhapKho.DataSource, dtgvPhieuNhapKho.Columns[e.ColumnIndex].Name, _sortDirection);
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Bunker kho = new Bunker();
            //List<KhoDTO> dsk = kh.Load_Kho();
            //kho.bunker_id = dsk.Count()+1;
            kho.product_id = kh.Get_IdProduct_ByProductName(cb_TenSanPham.Text);
            kho.price = Convert.ToDouble(txtDonGia.Text);
            kho.soluong = Convert.ToInt32(txtSoLuong.Text);
            if (kh.Add_Bunker(kho))
            {
                MessageBox.Show("Thêm phiếu nhập kho thành công");
                kh.Update_Bunker(kho);
                frmKho_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập kho thất bại");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            lbThanhTien.Text = Convert.ToString(Convert.ToDouble(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text));
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            string pathToResources = Path.Combine(Application.StartupPath, "Resources");
            string filePath = Path.Combine(pathToResources, "PhieuNhapKho.dotx");
            Document baoCao = new Document(filePath);

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "NgayThangNam" }, new[] { string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "TenCuaHang" }, new[] { "Cửa hàng quản lý bán quần áo" });
            baoCao.MailMerge.Execute(new[] { "DiaChi" }, new[] { "140 Lê Trọng Tấn" });

            //Bước 3: Điền thông tin lên bảng
            Table bangPhieuNhap = baoCao.GetChild(NodeType.Table, 0, true) as Table;
            int hangHienTai = 1;
            List<KhoDTO> khos = kh.Load_Kho();
            bangPhieuNhap.InsertRows(hangHienTai, hangHienTai, khos.Count() - 1);

            double tongTien = 0;
            for (int i = 0; i < khos.Count(); i++)
            {
                string ten = kh.Get_NameProduct_ByProductId(khos[i].product_id);
                //double thanhtien = (Convert.ToInt32(khos[i].soluong) * Convert.ToDouble(khos[i].price));
                tongTien += Convert.ToDouble(khos[i].thanhtien);
                //string tt = thanhtien.ToString();
                int x = i + 1;
                bangPhieuNhap.PutValue(hangHienTai, 0, x.ToString());
                bangPhieuNhap.PutValue(hangHienTai, 1, ten);
                bangPhieuNhap.PutValue(hangHienTai, 2, khos[i].soluong.ToString());
                bangPhieuNhap.PutValue(hangHienTai, 3, khos[i].price.ToString());
                bangPhieuNhap.PutValue(hangHienTai, 4, khos[i].thanhtien.ToString());
                hangHienTai++;
            }
            string tong = tongTien.ToString();
            baoCao.MailMerge.Execute(new[] { "TongTien" }, new[] { tong });

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("PhieuNhapKho.dotx");

        }
    }
}
