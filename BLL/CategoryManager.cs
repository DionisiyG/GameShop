using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using DAL;

namespace BLL
{
    public class CategoryManager : ICategoryService
    {
        IUnitOfWork Database = null;
        public CategoryManager(IUnitOfWork uow)
        {
            Database = uow;
        }
        public IEnumerable<Categories> GetAllCategories()
        {
            return Database.Categories.GetAll();
        }
    }
}
