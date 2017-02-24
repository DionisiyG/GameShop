using BLL;
using DAL;
using DAL.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        EFUnitOfWork db = new EFUnitOfWork(); 
        [HttpPost]
        public void ShopMenu(Orders order)
        {
            db.Orders.Create(order);
            db.Save();
        }

        //public string ShopMenu()
        //{
        //    return "Test shop controller";
        //}
    }
}