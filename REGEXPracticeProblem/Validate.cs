using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXPracticeProblem
{
    internal class Validate
    {
        public string pattern = @"ab{2,3}";
        public void validateString(string fName)
        {
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine("Input string is correct : " + fName);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }
    }
}
