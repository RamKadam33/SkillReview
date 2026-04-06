using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview.Collections
{
    public class DictionaryTest
    {
        [Test]
        public void TestAllDictionaryMethods()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int> { { "a", 1 }, { "b", 2 }, { "c", 3 } };
            Dictionary<string, int> dictCopy = new Dictionary<string, int>(myDict);


            var keys = new List<string> { "x", "y", "z" };
            var newDict = new Dictionary<string, int>();
            foreach (var key in keys)
                newDict[key] = 0;
            Assert.AreEqual(3, newDict.Count);


            int value;
            bool found = myDict.TryGetValue("a", out value);
            Assert.IsTrue(found);
            Assert.AreEqual(1, value);

            Assert.AreEqual(3, myDict.Count);
           

            var keysView = myDict.Keys;
         

            bool removed = myDict.Remove("b");
            Assert.IsTrue(removed);
            Assert.IsFalse(myDict.ContainsKey("b"));
            Assert.AreEqual(2, myDict.Count);

            var lastKey = "";
            foreach (var key in myDict.Keys) 
                lastKey = key;
            var lastValue = myDict[lastKey];
            myDict.Remove(lastKey);
            Assert.IsFalse(myDict.ContainsKey(lastKey));
            Assert.AreEqual(1, myDict.Count);

            if (!myDict.ContainsKey("d")) 
                myDict["d"] = 4;
            Assert.AreEqual(4, myDict["d"]);

            var updateDict = new Dictionary<string, int> { { "e", 5 }, { "f", 6 } };
            foreach (var kvp in updateDict) 
                myDict[kvp.Key] = kvp.Value;
            Assert.IsTrue(myDict.ContainsKey("e"));
            Assert.IsTrue(myDict.ContainsKey("f"));
            Assert.AreEqual(5, myDict["e"]);
            Assert.AreEqual(6, myDict["f"]);

            var valuesView = myDict.Values;
            CollectionAssert.IsSubsetOf(new[] { 4, 5, 6 }, valuesView);

            myDict.Clear();
            Assert.AreEqual(0, myDict.Count);
        }
    }
}
