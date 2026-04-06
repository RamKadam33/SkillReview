using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;

namespace TestPractice.Collections
{
    public class ArraylistTest
    {
        [Test]
        public void arrayListTest()
        {
            ArrayList arrayList = new ArrayList();
           
            arrayList.Add(10);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(true);
            Assert.AreEqual(4, arrayList.Count);
            Assert.AreEqual(10, arrayList[0]);
            Assert.AreEqual("Hello", arrayList[1]);
            Assert.AreEqual(3.14, arrayList[2]);
            Assert.AreEqual(true, arrayList[3]);

            arrayList.AddRange(new object[] { 20, "World", false });
            Assert.AreEqual(7, arrayList.Count);
            

            Assert.AreEqual("Hello", arrayList[1]);
            arrayList[2] = 2.71;
            Assert.AreEqual(2.71, arrayList[2]);

            Assert.IsTrue(arrayList.Contains("Hello"));
            Assert.AreEqual(4, arrayList.IndexOf(20));
            Assert.AreEqual(6, arrayList.LastIndexOf(false));

            arrayList.Insert(1, "Inserted");
            Assert.AreEqual("Inserted", arrayList[1]);
            Assert.AreEqual(8, arrayList.Count);

            arrayList.InsertRange(2, new object[] { "A", "B" });
            Assert.AreEqual("A", arrayList[2]);
            Assert.AreEqual("B", arrayList[3]);

            Assert.AreEqual(10, arrayList.Count);

            arrayList.Remove("Hello");
            Assert.IsFalse(arrayList.Contains("Hello"));
            Assert.AreEqual(9, arrayList.Count);
            Assert.IsTrue(arrayList.Contains("World") || arrayList.Contains("B"));

            arrayList.RemoveAt(0);
            Assert.AreNotEqual(10, arrayList[0]);
            Assert.AreEqual(8, arrayList.Count);

            arrayList.RemoveRange(0, 2);
            Assert.AreEqual("B", arrayList[0]);
            Assert.AreEqual(6, arrayList.Count);

            arrayList.Reverse();
            Assert.AreEqual(false, arrayList[0]);
            Assert.AreEqual(2.71, arrayList[4]);
            int capacity = arrayList.Capacity;
            arrayList.TrimToSize();
            Assert.AreEqual(arrayList.Count, 6);
             capacity = arrayList.Capacity;

            object[] arr = arrayList.ToArray();
            Assert.AreEqual(arrayList.Count, arr.Length);

            arrayList.Clear();
            Assert.AreEqual(0, arrayList.Count);

             capacity = arrayList.Capacity;
            Assert.GreaterOrEqual(capacity, 0);
         
        }
    }
}
