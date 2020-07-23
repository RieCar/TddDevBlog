using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TddDevBlog.API.Business
{
    public class RomanNumberConverter
    {
        Dictionary<char, int> map = new Dictionary<char, int>() 
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 },       
        };

        public int ConvertRomanToInt(string roman)
        {
            int number = 0; 
            for (var i = 0; i < roman.Length; i++)
            {
                if(i + 1 < roman.Length && map[roman[i]] < map[roman[i + 1]])
                {
                    number -= map[roman[i]]; 
                }
                else
                {
                    number += map[roman[i]];
                }
            }
            return number; 
        }
    }
}
