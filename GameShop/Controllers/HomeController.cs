
using GameShop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DAL.Repositories;
using DAL;
using BLL.Interfaces;
using BLL;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService categoryService;
        IProductsService productService;

        public HomeController()
        {

        }
        public HomeController(ICategoryService categoryService, IProductsService productService)
        {
            this.categoryService = categoryService;      
            this.productService = productService;
        }
        
        public ActionResult Index(string id = null)
        {
            HomeIndexModel homeModel = new HomeIndexModel(categoryService);
            homeModel.Products = productService.GetMainProducts(id);// convert to
            return View(homeModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        
    }
}