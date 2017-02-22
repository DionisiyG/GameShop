
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

        public HomeController()
        {

        }

        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;      
        }

        //EFUnitOfWork db = new EFUnitOfWork("OnlineStoreEntities4");
        //OnlineStoreEntities4 db1 = new OnlineStoreEntities4();
        //public ActionResult Test()
        //{
        //    var t = db.Categories.GetAll().ToList();
        //    return View(t);
        //}

        public ActionResult Index()
        {
            HomeIndexModel homeModel = new HomeIndexModel(categoryService);        
            return View(homeModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public PartialViewResult _CategoriesPartial()
        {         
            IEnumerable<CategoriesDTO> categoriesDto = categoryService.GetAllCategories();
            Mapper.Initialize(cfg => cfg.CreateMap<CategoriesDTO, CategoryViewModel>());
            var category = Mapper.Map<IEnumerable<CategoriesDTO>, List<CategoryViewModel>>(categoriesDto);

            return PartialView("_CategoriesPartial", category);
        }
    }
}