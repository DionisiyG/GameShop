using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class CategoryRepository : BaseRepository<Categories>, IRepository<Categories>
    {
        public CategoryRepository(OnlineStoreEntities4 context)
        {
            this.db = context;
        }
        public void Create(Categories category)
        {
            db.Categories.Add(category);
        }

        public void Delete(int id)
        {
            Categories category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
            }
        }

        public Categories Get(string id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Categories> GetAll()
        {
            return db.Categories;
        }

        public void Update(Categories category)
        {
            db.Entry(category).State = EntityState.Modified;
        }

        public Categories GetProductsByCategories(string id)
        {
            Categories prodsByCategs = db.Categories.Where(x=> x.Id == id).FirstOrDefault();
            return prodsByCategs;
        }       
    }
}
