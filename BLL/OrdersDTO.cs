using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdersDTO
    {
        public string Id { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsHandled { get; set; }
        public string UsersId { get; set; }
    }
}
