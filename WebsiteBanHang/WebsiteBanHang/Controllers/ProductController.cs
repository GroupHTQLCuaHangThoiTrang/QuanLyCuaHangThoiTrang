using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        WebsiteBanQuanAoEntities2 objWebsiteBanHangEntities = new WebsiteBanQuanAoEntities2();
        // GET: Product

      
        public ActionResult Detail(int Id)
        {
            var objProduct = objWebsiteBanHangEntities.Product.Where(n=>n.product_id==Id ).FirstOrDefault();
            return View(objProduct);
        }

        public ActionResult Index()
        {
            var lstProducts = objWebsiteBanHangEntities.Product.ToList();

            return View(lstProducts);
        }
        public ActionResult Order()
        {
            var lstOrder = objWebsiteBanHangEntities.Orders.ToList();

            return View(lstOrder);
        }

        public ActionResult Create()
        {
            return View(new Product() { price = 0, price_discount = 0 });
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            WebsiteBanQuanAoEntities2 db = new WebsiteBanQuanAoEntities2();
            //Lưu dữ liệu vào db
            if (string.IsNullOrEmpty(model.product_name) == true)
            {
                ModelState.AddModelError("", "Tên sản phẩm không được để trống!!!");
                return View(model);
            }
            if (model.price <= 0)
            {
                ModelState.AddModelError("", "Giá bán phải lớn hơn 0!!!");
                return View(model);
            }
            //Lưu
            db.Product.Add(model);
            db.SaveChanges();
            if (model.product_id > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Lỗi không lưu được vào DB!!!");
                return View(model);
            }
        }

        public ActionResult Edit(int Id)
        {
            var productModel = objWebsiteBanHangEntities.Product.Where(n => n.product_id == Id).FirstOrDefault();
            return View(productModel);
        }
        [HttpPost]
        public ActionResult Edit(Product model)
        {
            //Lưu dữ liệu vào db
            if (string.IsNullOrEmpty(model.product_name) == true)
            {
                ModelState.AddModelError("", "Tên sản phẩm không được để trống!!!");
                return View(model);
            }
            if (model.price <= 0)
            {
                ModelState.AddModelError("", "Giá bán phải lớn hơn 0!!!");
                return View(model);
            }
            //Tìm đối tượng cần sửa
            var EditModel = objWebsiteBanHangEntities.Product.Where(n => n.product_id == model.product_id).FirstOrDefault();
            //Gắn giá trị mới cho đối tượng
            EditModel.product_name = model.product_name;
            EditModel.avatar = model.avatar;
            EditModel.category_id = model.category_id ;
            EditModel.short_des = model.short_des;
            EditModel.full_des = model.full_des;
            EditModel.price = model.price;
            EditModel.price_discount = model.price_discount;
            EditModel.type_id = model.type_id;
           
            EditModel.brand_id = model.brand_id;
            var id = objWebsiteBanHangEntities.SaveChanges();
            if (id > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Lỗi không lưu được vào DB!!!");
                return View(model);
            }
        }

        public ActionResult Delete(int Id)
        {
            var productModel = objWebsiteBanHangEntities.Product.Where(n => n.product_id== Id).FirstOrDefault();
            objWebsiteBanHangEntities.Product.Remove(productModel);
            objWebsiteBanHangEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}