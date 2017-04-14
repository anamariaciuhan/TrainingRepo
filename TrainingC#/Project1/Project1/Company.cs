using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Company
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Company()
        {
            Address = new Address();
        }

        public override string ToString()
        {
            return "Name: " + Name+ Environment.NewLine+"Address: " + Address;
        }
    }
}
