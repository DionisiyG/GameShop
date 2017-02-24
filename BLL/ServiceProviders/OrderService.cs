using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Interfaces;
using DTO;

namespace BLL.ServiceProviders
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }
        public OrderService(IUnitOfWork uow)
        {
            this.Database = uow;
        }
        
        //public IList<ProductDto> AddToCart(Products product, string id)
        //{
        //    //Products productToAdd = Database.Products.Get(id);
        //    //productToAdd = new Products
        //    //{
        //    //    ProductName = productToAdd.ProductName,
        //    //    Price = productToAdd.Price,
        //    //};
        //}
        public void AddProduct(Products product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CountTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void RemovePrduct(Products product)
        {
            throw new NotImplementedException();
        }
    }
}
