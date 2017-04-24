using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Customer
    {

        public string Name { get; set; }

        public List<Order> Orders
        {
            get;

            set ;
        }

        public Customer() {

            Orders = new List<Order>();


        }


        

      //  var distinct = Orders.GroupBy(x => x.OrderNumber).Select(y => y.First()).ToList();

        public void  AddOrder(Order order)
        {
            Orders.Add(order);
            
        }

        
           
        

        public List<string> GetCustomerOrders()
        {
            // Trying to add an Order with an existing OrderNumber should replace the existing Order (not add a duplicate)

            var CustomerOrders = Orders.Select(o => o.OrderNumber+" :  "+o.OrderDate).Distinct().ToList();

            return CustomerOrders;
        }

        

    }
}
