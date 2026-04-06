using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview.Collections
{
    public class SortedListTest
    {
        [Test]
        public void TestSortedList()
        {
            SortedList list = new SortedList();

            list.Add("apple", 1);
            list.Add("banana", 2);
            list.Add("cherry", 3);

            list["date"] = 4;

            int count = list.Count;
            Console.WriteLine("Count: " + count);

            bool containsBanana = list.ContainsKey("banana");
            bool containsFig = list.Contains("fig");
            bool containsValue2 = list.ContainsValue(2);
            Console.WriteLine("Contains 'banana'? " + containsBanana);
            Console.WriteLine("Contains 'fig'? " + containsFig);
            Console.WriteLine("Contains value 2? " + containsValue2);

            object keyAt0 = list.GetKey(0);
            object valueAt0 = list.GetByIndex(0);
            Console.WriteLine("Key at index 0: " + keyAt0);
            Console.WriteLine("Value at index 0: " + valueAt0);

            int indexOfCherry = list.IndexOfKey("cherry");
            int indexOfValue4 = list.IndexOfValue(4);
            Console.WriteLine("Index of 'cherry': " + indexOfCherry);
            Console.WriteLine("Index of value 4: " + indexOfValue4);

            list.Remove("banana");
            list.RemoveAt(0);

            list.SetByIndex(0, 100);

           

            IList keyList = list.GetKeyList();
            IList valueList = list.GetValueList();

            Console.WriteLine("KeyList:");
            foreach (object key in keyList)
                Console.WriteLine(key);

            Console.WriteLine("ValueList:");
            foreach (object value in valueList)
                Console.WriteLine(value);

            DictionaryEntry[] entries = new DictionaryEntry[list.Count];
            list.CopyTo(entries, 0);
            Console.WriteLine("Copied entries:");
            foreach (DictionaryEntry entry in entries)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            SortedList clonedList = (SortedList)list.Clone();
            Console.WriteLine("Cloned list:");
            foreach (DictionaryEntry entry in clonedList)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            list.TrimToSize();

            bool isFixedSize = list.IsFixedSize;
            bool isReadOnly = list.IsReadOnly;
            bool isSynchronized = list.IsSynchronized;
            Console.WriteLine("IsFixedSize: " + isFixedSize);
            Console.WriteLine("IsReadOnly: " + isReadOnly);
            Console.WriteLine("IsSynchronized: " + isSynchronized);

            list.Clear();
            int countAfterClear = list.Count;
            Console.WriteLine("Count after Clear: " + countAfterClear);
        }
    }
}