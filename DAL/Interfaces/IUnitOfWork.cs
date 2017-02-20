using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   public interface IUnitOfWork : IDisposable
    {
        IRepository<Categories> Categories { get;  }
        IRepository<Orders> Orders { get;  }
        IRepository<Products> Products { get;  }
        IRepository<AspNetUsers> Customers { get;  } //AspNetUsers == Customers

        void Save();
    }
}
