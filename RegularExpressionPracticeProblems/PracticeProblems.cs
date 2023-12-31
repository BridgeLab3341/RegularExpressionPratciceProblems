﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
        public void FindSequenceOfLowerCase()
        {
            Console.WriteLine("Enter a sequences of lowercase letters joined by an underscore.");
            string input=Convert.ToString(Console.ReadLine());
            string pattern = "^[a-z]+(?:_[a-z])";
            Regex regex= new Regex(pattern);
            if(regex.IsMatch(input))
            {
                Console.WriteLine("The {0} Lowercase letters are valid",input);
            }
            else
            {
                Console.WriteLine("The {0} Lowercase letters are Not valid", input);
            }
        }
        public void FetchHTMLTags()
        {
            string input = "<p>The<code>Regex</code>is a compiled representation of a regular expression.</p>";
            string pattern = @"<[^/][^>]*>|<\/[^>]+>";
            Regex regex = new Regex(pattern);
            // Find all matches in the input string
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine("HTML tags found in the input string:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        public void CountNumberOfOccurences()
        {
            String  s = "foxes are omnivorous mammals belonging to several genera\r\nof the family Canidae fox";
            string pattern = "(fox) ?";
            Regex regex = new Regex(pattern);
            MatchCollection matches=regex.Matches(s);
            int count = 0;
            foreach (Match data in matches)
            {
                Console.WriteLine(data);
                count++;
            }
            Console.WriteLine(count);
        }
        public void FindValidFileNamesImageExtension()
        {
            string[] filePath = { "image.jpg", "photo.png", "picture.gif", "document.docx", "data.csv", "backup.zip" };
            string pattern = "^[A-Za-z0-9]+[.]+(jpg|jpeg|png|gif)$";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Valid image file names");
            Console.WriteLine("-----------------------");
            foreach (string fileName in filePath)
            {
                if(regex.IsMatch(fileName))
                {
                    Console.WriteLine(fileName);
                }
            }
        }
        public void ValidateWebsiteAddressFormate()
        {
            string[] input = {"https://www.example.com","http://example.com","www.example.com","example.com", "http://invalid","ftp://ftp.example.com"};
            string pattern = @"^(https?://)?(www\.)?([a-zA-Z0-9-]+\.){1,}[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Valid Website Address formates");
            Console.WriteLine("------------------------------");
            foreach (string web in input)
            {
                if( regex.IsMatch(web))
                {
                    Console.WriteLine(web);
                }
            }
        }
    }
}
