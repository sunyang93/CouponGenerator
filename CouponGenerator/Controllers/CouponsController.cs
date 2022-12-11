using CouponGenerator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CouponGenerator.Controllers
{
    /// <summary>
    /// 优惠券
    /// </summary>
    [Route("api/conpons")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Order> GetCoupons()
        {
            var order = new Order
            {
                OrderNo="123fsfs",
                TotalPrice = 12.24M,
                Items = new List<OrderItem>()
                {
                    new OrderItem()
                    {
                        Product=new Product()
                        {
                            Price=12.2M,
                            ProductCode="Fdss",
                            StoreCode="fsfs"
                        },
                        Quantity=12.435M,
                        TotalPrice=24343.454M
                    }
                }
            };
            return Ok(order);
        }
    }
}
