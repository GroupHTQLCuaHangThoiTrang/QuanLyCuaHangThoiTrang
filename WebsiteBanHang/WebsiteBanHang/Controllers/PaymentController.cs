using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class PaymentController : Controller
    {
        WebsiteBanQuanAoEntities2 objWebsiteBanHangEntities = new WebsiteBanQuanAoEntities2();
        // GET: Payment
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                //lay thong tin gio hang tu bien session
                var lstCart = (List<CartModel>)Session["cart"];
                //gan du lieu cho order

                //objorder.order_id = 3;
                using (var transaction = objWebsiteBanHangEntities.Database.BeginTransaction())
                {
                    try
                    {
                        // Xử lý từng mặt hàng trong giỏ hàng
                        foreach (CartModel item in lstCart)
                        {
                            // Tạo đơn hàng mới cho từng mặt hàng
                            Orders objorder = new Orders
                            {
                                user_id = Convert.ToInt32(Session["idUser"]),
                                order_name = "DonHang-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                                product_id = item.Product.product_id,
                                price = item.Product.price * item.Quantity, // Tính giá theo số lượng
                                status = 1,
                                created = DateTime.Now
                            };

                            // Thêm đơn hàng vào cơ sở dữ liệu
                            objWebsiteBanHangEntities.Orders.Add(objorder);

                            // Lấy sản phẩm từ cơ sở dữ liệu
                            Product prd = objWebsiteBanHangEntities.Product
                                .SingleOrDefault(t => t.product_id == objorder.product_id);

                            if (prd != null)
                            {
                                prd.soluong -= item.Quantity; // Cập nhật số lượng dựa trên số lượng mặt hàng
                            }

                            // Lưu thay đổi sau mỗi lần cập nhật đơn hàng và sản phẩm
                            objWebsiteBanHangEntities.SaveChanges();
                        }

                        // Xóa giỏ hàng sau khi tạo đơn hàng thành công
                        Session["cart"] = new List<CartModel>();

                        // Commit giao dịch sau khi tất cả các thay đổi đã hoàn tất
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback giao dịch nếu có lỗi xảy ra
                        transaction.Rollback();
                        // Xử lý lỗi (ví dụ: ghi log, thông báo cho người dùng, v.v.)
                        throw;
                    }
                }


                //lay orderId vua moi tao de luu vao bang OrderDetail
                //int intOrderId = objorder.order_id;
                //List<OrderDetail> lstOrderDetail = new List<OrderDetail>();
                //foreach (var item in lstCart)
                //{
                //    OrderDetail obj = new OrderDetail();
                //    obj.Quantity = item.Quantity;
                //    obj.OrderId = intOrderId;
                //    obj.ProductId = item.Product.Id;
                //    lstOrderDetail.Add(obj);

                //}


            }
            return View();
        }
    }
}