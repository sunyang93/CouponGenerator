using CouponGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace CouponGenerator.Controllers
{
    /// <summary>
    /// 优惠券
    /// </summary>
    public class CouponController : Controller
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 优惠券规则
        /// </summary>
        /// <returns></returns>
        public IActionResult Rule()
        {
            return View();
        }

        public IActionResult Schema()
        {
            return View();
        }
    }
}
