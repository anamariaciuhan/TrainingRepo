using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Student:Person_v2
    {

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        : base(firstName, lastName, dateOfBirth)
        { }
        public string SchoolName { get; set; }

        //public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
    
}
}
