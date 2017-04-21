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

        }

       /* public string AddDuplicateOrder(string duplicateOrder)
        {

            if (duplicateOrder == OrderNumber)
                OrderNumber = duplicateOrder;

            return duplicateOrder;
        }*/

        public string OrderNumber { get; set; }

        public DateTime orderDate { get; set; }
   

    }
}
