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
        public string tags = "<[^>]+>";
        public string formats = @"^[a-zA-Z0-9-_]+\.(jpg|jpeg|png|gif)$";


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

        //FIND HTML TAGS
        public void FindHTMLTags(string para)
        {
            MatchCollection matches = Regex.Matches(para,tags);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        //VALID FILES NAME
        public void ValidFilesName()
        {
            string[] filenames = { "image.jpg", "photo.png", "picture.jpeg", "snapshot.gif", "doc.docx", "file.pdf", "demo.txt" };
            Regex regex = new Regex(formats);
            foreach (string fileName in filenames)
            {
                if (regex.IsMatch(fileName))
                {
                    Console.WriteLine(fileName);
                }
            }
        }
    }
}
