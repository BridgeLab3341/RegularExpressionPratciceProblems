using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionPracticeProblems
{
    internal class PracticeProblems
    {
        public void MatchString()
        {
            Console.WriteLine("Write a String That contains 'a' and 'b' ");
            string input =Convert.ToString(Console.ReadLine());
            string pattern = "^[a]{1}[b]{2,}";
            Regex regex= new Regex(pattern);
            if(regex.IsMatch(input))
            {
                Console.WriteLine("The given string {0} matches With Pattern",input);
            }
            else
            {
                Console.WriteLine("The Given string {0} Not Matches With Pattern",input);
            }
        }
    }
}
