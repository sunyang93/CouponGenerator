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
        [HttpPost("rules")]
        public IActionResult CreateRule()
        {
            return Ok();
        }

        [HttpGet("rules/{id}",Name ="GetConponRule")]
        public IActionResult GetRule(string id)
        {
            return Ok();
        }
    }
}
