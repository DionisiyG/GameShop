using AutoMapper;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using DTO;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            this.InitMaps();

            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);


        }

        public void InitMaps()
        {
           // Mapper.Initialize(cfg => cfg.CreateMap<Products, ProductDto>());
        }
    }
}
