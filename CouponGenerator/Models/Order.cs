using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace CouponGenerator.Models
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNo { get; set; } = null!;

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 订单项
        /// </summary>
        public List<OrderItem> Items { get; set; } = null!;
    }

    /// <summary>
    /// 订单项
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// 商品
        /// </summary>
        public Product Product { get; set; } = null!;

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }
    }

    /// <summary>
    /// 商品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        public string ProductCode { get; set; } = null!;

        /// <summary>
        /// 店铺编码
        /// </summary>
        public string StoreCode { get; set; } = null!;

        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
    }
}
