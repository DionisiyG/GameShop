using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
   public  interface IOrderService
    {
        void AddProduct(Products product, int quantity);
        void RemovePrduct(Products product);
        void CountTotalPrice();
        void Clear();
        //IList<ProductDto> AddToCart(Products product, string id);
    }
}
