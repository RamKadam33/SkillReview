using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview.Collections
{
    public class ListTest
    {
        [Test]
        public void TestList()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.AddRange(new int[] { 1, 2, 3 });
            list.Clear();
            list.AddRange(new int[] { 10, 20, 30, 40, 50 });
            bool has20 = list.Contains(20);
            int index30 = list.IndexOf(30);
            list.Insert(1, 15);
            list.InsertRange(2, new int[] { 16, 17 });
            list.Remove(17);
            list.RemoveAt(0);
            list.RemoveRange(1, 2);
            list.Reverse();
            list.Sort();
            int[] arr = list.ToArray();
            int count = list.Count;
            int capacity = list.Capacity;
            list.Capacity = 100;
            int firstItem = list[0];
            list[0] = 99;
            int found = list.Find(x => x > 40);
            List<int> foundAll = list.FindAll(x => x > 30);
            list.ForEach(Console.WriteLine);
            Console.WriteLine("Final list:");
            foreach (var item in list)
               Console.WriteLine(item);
            Console.WriteLine("Has 20? " + has20);
            Console.WriteLine("Index of 30: " + index30);
            Console.WriteLine("Array: " + string.Join(", ", arr));
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Capacity: " + capacity);
            Console.WriteLine("First item: " + firstItem);
            Console.WriteLine("Found > 40: " + found);
            Console.WriteLine("FoundAll > 30: " + string.Join(", ", foundAll));
        }
    }
}
