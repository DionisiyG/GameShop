using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult ShopMenu()
        {
            return View();
        }

        //public string ShopMenu()
        //{
        //    return "Test shop controller";
        //}
    }
}