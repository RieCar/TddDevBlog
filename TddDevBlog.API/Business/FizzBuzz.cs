using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TddDevBlog.API.Business
{
    public class FizzBuzz
    {

        public string Ask(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
                return " "; 
           

        }

    }
}
