using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Exceptions
    {


  
        public List<string> GetAccessPermissions(string token)
        {
            if (token != null && token.Length >= 10)
            {
                throw new MyInvalidTokenException("Token must be 10 or less characters long");
            }

            else if(string.IsNullOrEmpty(token)){

                throw new MyMissingTokenException("Token shouldn't be null or empty");

            }


            return new List<string> { "ReadLessons", "ReviewLessons" };
        }


    




    }
}
