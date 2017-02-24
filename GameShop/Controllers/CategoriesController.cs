using AutoMapper;
using BLL;
using BLL.Interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameShop.Controllers
{
    public class CategoriesController : Controller
    {
        ICategoryService categoryService;
        
        // GET: Categories
        public ActionResult InnerCategory(string id)
        {
            CategoriesDTO categoriesDto = categoryService.GetProductsWithCategories(id);
            return View(categoriesDto);
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