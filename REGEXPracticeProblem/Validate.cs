using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace REGEXPracticeProblem
{
    internal class Validate
    {
        public string pattern = @"ab{2,3}";
        public string sequence = @"[a-z]+_[a-z]+";

        //CHECK STRING
        public void validateString(string str)
        {
            if (Regex.IsMatch(str, pattern))
            {
                Console.WriteLine("Input string is correct : " + str);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }

        //LOWERCASE SEQUENCE
        public void ValidLowercaseSequence(string data)
        {
            if (Regex.IsMatch(data, sequence))
            {
                Console.WriteLine("Input string is correct : " + data);
            }
            else
            {
                Console.WriteLine("Input string is incorrect");
            }
        }
    }
}
