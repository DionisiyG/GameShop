using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using DAL;
using AutoMapper;

namespace BLL
{
    public class CategoryManager : ICategoryService
    {
        IUnitOfWork Database { get; set; }
        public CategoryManager(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CategoriesDTO> GetAllCategories()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Categories, CategoriesDTO>());
            return Mapper.Map<IEnumerable<Categories>, List<CategoriesDTO>>(Database.Categories.GetAll());
            //return Database.Categories.GetAll();
        }

        public CategoriesDTO GetProductsWithCategories(string id)
        {
            //var category = Database.Categories.GetProductsByCategories(id);
           //Mapper.Initialize(cfg => cfg.CreateMap<Categories, CategoriesDTO>());
           // return Mapper.Map<Categories, CategoriesDTO>(category);
            return null;
        }
    }
}
    