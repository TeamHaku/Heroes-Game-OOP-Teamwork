using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\Junk\Map.html");
            StringBuilder allLines = new StringBuilder();

            foreach (string line in lines)
            {
                string lineCopy = line.Replace(" ", "").Trim();
                allLines.Append(lineCopy);
            }

            string htmlString = allLines.ToString();
            Console.WriteLine(htmlString);
            Match match = Regex.Match(htmlString, @"<tr>(.*?)<\/tr>");

            Console.WriteLine(match.Length);
            //while (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //    match.NextMatch();
            //}

        }
    }
}
