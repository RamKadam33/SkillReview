using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SkilReview
{
    public static class ExtensionMethods
    {
        public static string RemoveCurrencySymbols(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            
            var currencySymbols = CultureInfo
                .GetCultures(CultureTypes.AllCultures)
                .Select(c => c.NumberFormat.CurrencySymbol)
                .Where(s => !string.IsNullOrEmpty(s))
                .Distinct()
                .ToArray();

            string result = input;
            foreach (var symbol in currencySymbols)
            {
                result = result.Replace(symbol, "");
            }
            result = Regex.Replace(result, @"[,\s\u00A0]", "");
            return result.Trim();
        }

        
    }
}
