using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public static class AppData
    {
        public const string AmazonSearchUrl = @"https://www.amazon.com/s?url=search-alias%3Daps&field-keywords={0}";
        public const string GoogleSearchUrl = @"https://www.google.com/search?q={0}";
        public const string EbaySearchUrl = @"https://www.ebay.com/sch/{0}";
        public const string CustomSearchUrl = @"https://www.google.com/search?q={0}";

        public static string SearchText = "";

        public static string SearchTextEncoded()
        {
            string result = "";

            // Break the string into words and concatenate with + for url
            foreach(string word in SearchText.Split(' '))
            {
                result += word + "+";
            }

            return result;
        }
    }
}
