using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TddDevBlog.API.Business
{
    public class Converter
    {

        public double ConvertCelsiusToFarhenheit( double celsius)
        {
            var fahrenheit = (celsius * 9) / 5 + 32;

            return fahrenheit; 
        }

    }
}
