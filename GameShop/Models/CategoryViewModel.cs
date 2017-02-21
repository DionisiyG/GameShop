using BLL.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class CategoryViewModel
    {
        private Categories categoriesData = null;
        public CategoryViewModel()
        {
        }
        public CategoryViewModel(Categories categoriesData)
        {
            this.categoriesData = categoriesData;
        }

        public string Id
        {
            get
            {
                if (this.categoriesData == null) return null;
                return categoriesData.Id;
            }
        }

        public string CategoryName
        {
            get
            {
                if (this.categoriesData == null) return null;
                return this.categoriesData.CategoryName;
            }
            set
            {
                if (this.categoriesData == null) return;
                this.categoriesData.CategoryName = value;
            }
        }

        public void GetAllCategories(ICategoryService provider)
        {
            provider.GetAllCategories();
        }
    }
}