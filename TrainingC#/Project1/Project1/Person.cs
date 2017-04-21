using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Occupation { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        

        public Person()
        {
            Address = new Address();
        } 
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName+ Environment.NewLine+ "Address: " + Address;
        }



    }
}
