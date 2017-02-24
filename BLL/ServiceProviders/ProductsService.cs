using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.Interfaces;
using AutoMapper;
using DAL;

namespace BLL.ServiceProviders
{
    public class ProductsService : IProductsService
    {
        IUnitOfWork Database { get; set; }

        public ProductsService(IUnitOfWork uow)
        {
            this.Database = uow;
        }

        public IList<ProductDto> GetMainProducts(string catId)
        {

            IList<Products> result = null;// =  Database.Products.GetAll();
            if (!string.IsNullOrWhiteSpace(catId))
                result = this.Database.Products.GetAll().Where
                    (el => el.Categories.Any(c => c.Id == catId)).ToList();
            else
                result = this.Database.Products.GetAll().ToList();
            Mapper.Initialize(cfg => cfg.CreateMap<Products, ProductDto>());
            return Mapper.Map<IEnumerable<Products>, List<ProductDto>>(result);
        }
    }
}

