using BLL;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class HomeIndexModel
    {
        ICategoryService categoryService;

        public HomeIndexModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public HomeIndexModel() { }

        public IEnumerable<CategoriesDTO> CategoriesDto
        {
            get
            {
                if(categoryService != null)
                    return categoryService.GetAllCategories();
                return new List<CategoriesDTO>();
            }
        }
    }
}