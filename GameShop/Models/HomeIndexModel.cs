using BLL;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

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

        public IList<ProductDto> Products { get; internal set; }
        //public IList<ProductViewModel> ViewProducts { get; internal set; }
    }
}