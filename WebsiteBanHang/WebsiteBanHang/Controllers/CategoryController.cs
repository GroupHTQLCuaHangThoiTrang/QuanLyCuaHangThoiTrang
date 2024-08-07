using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class CategoryController : Controller
    {
        WebsiteBanQuanAoEntities2 objWebsiteBanHangEntities = new WebsiteBanQuanAoEntities2();
        // GET: Category
        public ActionResult Index()
        {
            var lstCategory = objWebsiteBanHangEntities.Category.ToList();

            return View(lstCategory);
        }
        public ActionResult ProductCategory(int Id)
        {
            var listProduct = objWebsiteBanHangEntities.Product.Where(n=>n.category_id == Id).ToList();
            return View(listProduct);
        }
    }
}