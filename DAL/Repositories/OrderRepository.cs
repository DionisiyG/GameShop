using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{
    public class OrderRepository : BaseRepository<Orders>, IRepository<Orders>
    {      
        public OrderRepository(OnlineStoreEntities3 context)
        {
            this.db = context;
        }

        public void Create(Orders order)
        {
            db.Orders.Add(order);
        }

        public void Delete(int id)
        {
            Orders order = db.Orders.Find(id);
            if(order != null)
            {
                db.Orders.Remove(order);
            }
        }

        public Orders Get(int id)
        {
            return db.Orders.Find(id);
        }

        public IEnumerable<Orders> GetAll()
        {
            return db.Orders;
        }

        public void Update(Orders order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
    }
}
