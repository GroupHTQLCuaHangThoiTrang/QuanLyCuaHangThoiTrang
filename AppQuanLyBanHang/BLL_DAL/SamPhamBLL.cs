using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL_DAL
{
    public class SamPhamBLL
    {
        WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext();
        public SamPhamBLL() { }

        public List<ProductDTO> Load_AllSanPham()
        {
            var list_sanpham = from s in ql.Products
                               select new ProductDTO
                               {
                                   product_id = s.product_id,
                                   product_name = s.product_name,
                                   brand_id = s.brand_id,
                                   category_id = s.category_id,
                                   short_des = s.short_des,
                                   full_des = s.full_des,
                                   price = s.price,
                                   price_discount = s.price_discount,
                                   avatar = s.avatar,
                                   soluong = s.soluong
                               };

            return list_sanpham.ToList();
        }

        public List<ProductDTO> Load_Ao()
        {

            var list_ao = from s in ql.Products
                          join l in ql.Categories on s.category_id equals l.category_id
                          where l.category_name == "Áo"
                          select new ProductDTO
                          {
                              product_id = s.product_id,
                              product_name = s.product_name,
                              brand_id = s.brand_id,
                              category_id = s.category_id,
                              short_des = s.short_des,
                              full_des = s.full_des,
                              price = s.price,
                              price_discount = s.price_discount,
                              avatar = s.avatar,
                              soluong = s.soluong
                          };

            return list_ao.ToList();

        }

        public List<ProductDTO> Load_Quan()
        {

            //var list_quan = from sp in ql.Products
            //                join l in ql.Categories on sp.category_id equals l.category_id
            //                where l.category_name == "Quần"
            //                select sp;
            var list_quan = from s in ql.Products
                            join l in ql.Categories on s.category_id equals l.category_id
                            where l.category_name == "Quần"
                            select new ProductDTO
                            {
                                product_id = s.product_id,
                                product_name = s.product_name,
                                brand_id = s.brand_id,
                                category_id = s.category_id,
                                short_des = s.short_des,
                                full_des = s.full_des,
                                price = s.price,
                                price_discount = s.price_discount,
                                avatar = s.avatar,
                                soluong = s.soluong
                            };

            return list_quan.ToList();

        }

        public List<ProductDTO> Load_Tuixach()
        {

            var list_tuixach = from s in ql.Products
                            join l in ql.Categories on s.category_id equals l.category_id
                            where l.category_name == "Túi xách"
                            select new ProductDTO
                            {
                                product_id = s.product_id,
                                product_name = s.product_name,
                                brand_id = s.brand_id,
                                category_id = s.category_id,
                                short_des = s.short_des,
                                full_des = s.full_des,
                                price = s.price,
                                price_discount = s.price_discount,
                                avatar = s.avatar,
                                soluong = s.soluong
                            };

            return list_tuixach.ToList();

        }
        public List<ProductDTO> Load_Dongho()
        {

            var list_dongho = from s in ql.Products
                              join l in ql.Categories on s.category_id equals l.category_id
                              where l.category_name == "Đồng Hồ"
                              select new ProductDTO
                              {
                                  product_id = s.product_id,
                                  product_name = s.product_name,
                                  brand_id = s.brand_id,
                                  category_id = s.category_id,
                                  short_des = s.short_des,
                                  full_des = s.full_des,
                                  price = s.price,
                                  price_discount = s.price_discount,
                                  avatar = s.avatar,
                                  soluong = s.soluong
                              };
            //var list_dongho = from sp in ql.Products where sp.category_id == 4 select sp;
            return list_dongho.ToList();

        }

        public List<ProductDTO> Load_Giay()
        {

            var list_giay = from s in ql.Products
                            join l in ql.Categories on s.category_id equals l.category_id
                            where l.category_name == "Giày"
                            select new ProductDTO
                            {
                                product_id = s.product_id,
                                product_name = s.product_name,
                                brand_id = s.brand_id,
                                category_id = s.category_id,
                                short_des = s.short_des,
                                full_des = s.full_des,
                                price = s.price,
                                price_discount = s.price_discount,
                                avatar = s.avatar,
                                soluong = s.soluong
                            };

            return list_giay.ToList();

        }

        public List<BrandDTO> Load_Brand()
        {

            var list_brand = from br in ql.Brands
                             select new BrandDTO
                             {
                                 brand_id = br.brand_id,
                                 brand_name = br.brand_name,
                                 avatar = br.avatar
                             };

            return list_brand.ToList();

        }

        public string Get_BrandName_ByProductName(int _id)
        {

            var name = (from s in ql.Products
                        join b in ql.Brands on s.brand_id equals b.brand_id
                        where s.brand_id == _id
                        select b.brand_name).FirstOrDefault();
            return name;

        }

        public bool Add_Brand(Brand pBrand)
        {
            try
            {
                ql.Brands.InsertOnSubmit(pBrand);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete_Brand(int pBrand_id)
        {
            try
            {
                Brand br = ql.Brands.Where(s => s.brand_id== pBrand_id).Single();
                ql.Brands.DeleteOnSubmit(br);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update_Brand(Brand pBrand)
        {
            try
            {
                Brand br = ql.Brands.Where(s => s.brand_id == pBrand.brand_id).Single();
                br.brand_name = pBrand.brand_name;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CategoryDTO> Load_Category()
        {

            var list_Category = from ct in ql.Categories
                                select new CategoryDTO
                                {
                                    category_id = ct.category_id,
                                    category_name = ct.category_name,
                                    avatar = ct.avatar
                                };

            return list_Category.ToList();

        }

        public bool Add_Category(Category pCate)
        {
            try
            {
                ql.Categories.InsertOnSubmit(pCate);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete_Category(int pCate_id)
        {
            try
            {
                Category cate = ql.Categories.Where(s => s.category_id == pCate_id).Single();
                ql.Categories.DeleteOnSubmit(cate);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update_Category(Category pCate)
        {
            try
            {
                Category cate= ql.Categories.Where(s => s.category_id== pCate.category_id).Single();
                cate.category_name= pCate.category_name;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string Get_CategoryName_ByProductName(int _id)
        {

            var name = (from s in ql.Products
                        join b in ql.Categories on s.category_id equals b.category_id
                        where s.category_id == _id
                        select b.category_name).FirstOrDefault();
            return name;

        }

        public bool Check_ProductName(string _name)
        {

            var product = ql.Products.FirstOrDefault(p => p.product_name == _name);
            if (product != null)
            {
                //Tồn tại sản phẩm
                return true;
            }
            //Không tồn tại sản phẩm
            return false;

        }

        public int Get_IdBrand_ByBrandName(string _brand_name)
        {

            int id = (from b in ql.Brands where b.brand_name == _brand_name select b.brand_id).FirstOrDefault();

            return id;

        }

        public int Get_IdCategory_ByCategoryName(string _cate_name)
        {
            int id = (from b in ql.Categories where b.category_name == _cate_name select b.category_id).FirstOrDefault();

            return id;
        }

        public bool Add_Product(Product _p)
        {

            if (Check_ProductName(_p.product_name))
            {
                //Trùng tên sản phẩm
                return false;
            }
            else
            {
                try
                {
                    List<ProductDTO> dssp = Load_AllSanPham();

                    _p.product_id = dssp.Count();
                    ql.Products.InsertOnSubmit(_p);
                    ql.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }
        //xóa sản phẩm
        public bool Delete_Product(int _p)
        {

            try
            {
                Product productz = ql.Products.Where(s => s.product_id == _p).Single();
                ql.Products.DeleteOnSubmit(productz);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Update_Product(int _p, string ten, double gia, int brand)
        {

            try
            {
                Product productz = ql.Products.Where(s => s.product_id == _p).Single();
                productz.product_name = ten;
                productz.price = gia;
                productz.brand_id = brand;
                ql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
