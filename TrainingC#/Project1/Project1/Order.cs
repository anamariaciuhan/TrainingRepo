using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Order
    {

        public Order(string orderNumber, DateTime orderDate )
        {
            OrderNumber = orderNumber;
            this.OrderDate = orderDate;

        }

     

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }
   
       

    }
}
