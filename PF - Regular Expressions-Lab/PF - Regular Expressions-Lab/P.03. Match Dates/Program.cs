﻿using System;
using System.Text.RegularExpressions;

namespace P._03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string input = Console.ReadLine();

            Regex rg = new Regex(pattern); 
            MatchCollection matchCollection = rg.Matches(input);

            foreach (Match item in matchCollection)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
