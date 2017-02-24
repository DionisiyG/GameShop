using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class OnlineStoreEntities4 : DbContext
    {
        public OnlineStoreEntities4(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
    }
}
