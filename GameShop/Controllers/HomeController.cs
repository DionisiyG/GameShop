
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

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService categoryService = null;

        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;      
        }
        EFUnitOfWork db = new EFUnitOfWork("OnlineStoreEntities4");
        //OnlineStoreEntities4 db1 = new OnlineStoreEntities4();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            var t = db.Categories.GetAll().ToList();
            return View(t);
        }

        public ActionResult PartialCategory(CategoryViewModel category)//CategoryViewModel category
        {
            //categoryService.GetCategories().ToList();
            category = categoryService.GetAllCategories().Select(el => new CategoryViewModel(el)).ToList();
            return PartialView(category);
        }
    }
}