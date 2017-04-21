using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Address
    {
        public int Number { get; set; } 
        public string Street { get; set; } 
        public string City { get; set; } 
        public string PostalCode { get; set; } 
        public string Country { get; set; } 

 

        public override string ToString()
        {
            return Number + "; " + Street + "; " + City + "; " + PostalCode + "; " + Country;
        }
    }
}
