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
    

        // Customers expose a method for adding an Order

        
        
        public void  AddOrder(Order order)
        {
            /* foreach (Order item in Orders)

             {
                 if (!Orders.Contains(order))

                     Orders.Add(order);
             } */
             

            Orders.Add(order);
        }

           
        

        public List<string> GetCustomerOrders()
        {

            var CustomerOrders = Orders.Select(o => o.OrderNumber+" :  "+o.orderDate).ToList();

            return CustomerOrders;
        }

        

    }
}
