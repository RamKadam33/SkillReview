using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Collections
{

    class HashSet
    {
        [Test]
        public  void hasss()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Union of two sets
            set1.UnionWith(set2);
            Console.WriteLine("After Union: " + string.Join(", ", set1));

            // Intersection of two sets
            set1.IntersectWith(new HashSet<int> { 3, 5 });
            Console.WriteLine("After Intersection: " + string.Join(", ", set1));

            // Difference of sets
            set1.ExceptWith(new HashSet<int> { 5 });
            Console.WriteLine("After Difference: " + string.Join(", ", set1));
        }
    }
}
