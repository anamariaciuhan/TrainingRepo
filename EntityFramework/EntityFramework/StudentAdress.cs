//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentAdress
    {
        public int StudentAdressId { get; set; }
        public int StudentID { get; set; }
        public string Address1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    
        public virtual Student Student { get; set; }
    }
}