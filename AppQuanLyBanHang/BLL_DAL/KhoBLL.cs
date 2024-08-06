using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL_DAL
{
    public class KhoBLL
    {

        WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext();
        public KhoBLL() { }

        public List<KhoDTO> Load_Kho()
        {
            var list_kho = from s in ql.Bunkers
                               select new KhoDTO
                               {
                                   bunker_id = s.bunker_id,
                                   product_id = s.product_id,
                                   price = s.price,
                                   soluong = s.soluong,
                                   thanhtien = s.price * s.soluong
                               };

            return list_kho.ToList();
        }

        public int Get_IdProduct_ByProductName(string _product_name)
        {
            int id = (from b in ql.Products where b.product_name == _product_name select b.product_id).FirstOrDefault();

            return id;
        }

        public string Get_NameProduct_ByProductId(int? _product_id)
        {
            string ten = (from b in ql.Products where b.product_id == _product_id select b.product_name).FirstOrDefault();

            return ten;
        }

        public bool Add_Bunker(Bunker _b)
        {
            try
            {
                List<KhoDTO> dsk = Load_Kho();
                _b.bunker_id = dsk.Count() + 1;
                ql.Bunkers.InsertOnSubmit(_b);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void Update_Bunker(Bunker _b)
        {
            Product productz = ql.Products.Where(s => s.product_id == _b.product_id).Single();
            productz.soluong = productz.soluong + _b.soluong;
            ql.SubmitChanges();
        }



    }
}
