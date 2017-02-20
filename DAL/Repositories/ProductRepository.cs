using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ProductRepository : BaseRepository<Products>, IRepository<Products>
    {
        public ProductRepository(OnlineStoreEntities3 context)
        {
            this.db = context;
        }
        public void Create(Products product)
        {
            db.Products.Add(product);
        }

        public void Delete(int id)
        {
            Products product = db.Products.Find(id); ;
            if(product != null)
            {
                db.Products.Remove(product);
            }
        }

        public Products Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Products> GetAll()
        {
            return db.Products;
        }

        public void Update(Products product)
        {
            db.Entry(product).State = EntityState.Modified;
        }
    }
}
