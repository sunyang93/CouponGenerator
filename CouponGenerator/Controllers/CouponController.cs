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
            string xmlSchema = @"<xs:schema attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/CouponGenerator.Models"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Order"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Product"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element type=""xs:float"" name=""Price""/>
                          <xs:element type=""xs:string"" name=""ProductCode""/>
                          <xs:element type=""xs:string"" name=""StoreCode""/>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element type=""xs:float"" name=""Quantity""/>
                    <xs:element type=""xs:float"" name=""TotalPrice""/>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element type=""xs:string"" name=""OrderNo""/>
        <xs:element type=""xs:float"" name=""TotalPrice""/>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
            ViewBag.XmlSchema = xmlSchema;
            return View();
        }

        public IActionResult Schema()
        {

            return View();
        }
    }
}
