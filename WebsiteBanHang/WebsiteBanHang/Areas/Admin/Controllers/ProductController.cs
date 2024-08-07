using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        WebsiteBanQuanAoEntities2 ObjWebsiteBanHangEntities = new WebsiteBanQuanAoEntities2();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var lstProduct = ObjWebsiteBanHangEntities.Product.ToList();

            return View(lstProduct);
        }
        [HttpGet]
        public ActionResult Create()
        {
          
           return View();

        }
    }
}