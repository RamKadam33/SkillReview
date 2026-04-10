using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview
{
    internal class Swapping
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void MyWaySwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        [Test]
        public void Aistanderd()
        {
            // Usage
            int x = 5;
            int y = 10;
            int m = 20;
            int n = 30;
            Swap(ref x, ref y); // variable should be initialized before passing to the method
            Console.WriteLine($"x = {x}, y = {y}");  // correct way
            MyWaySwap(m,n);
            Console.WriteLine($"m = {m}, n = {n}");    // not work

        }
        [Test]
        public void OutTest()
        {
            Dictionary<string, string> countryCodes = new Dictionary<string, string>
            {
                   { "US", "United States" },
                   { "IN", "India" },
                   { "UK", "United Kingdom" }
            };

            string codeToFind = "IN";
            string countryName;// variable should be declared before passing to the method no need to initialize
            bool found = countryCodes.TryGetValue(codeToFind, out countryName);

            if (found)
            {
                Console.WriteLine($"Country: {countryName}"); // Output: Country: India
            }
            else
            {
                Console.WriteLine("Country code not found.");
            }
        }
    }
}
