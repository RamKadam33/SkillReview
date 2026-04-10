using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Collections
{
    internal class HashTable
    {// C# program to demonstrates the use 
     // of IsSynchronized and Count property
        [Test]
        public void Hashtablee()
        {


            Hashtable h1 = new Hashtable();
            h1.Add("1", "Welcome");
            h1.Add("2", "to");
            h1.Add("3", "geeks");
            h1.Add("4", "for");
            h1.Add("5", "geeks");
            h1.Add("a", 6);


            Hashtable h2 = Hashtable.Synchronized(h1);

           
            Console.WriteLine("h1 Hashtable is {0}.",
                    h1.IsSynchronized ? "synchronized" : "not synchronized");

            Console.WriteLine("h2 Hashtable is {0}.",
                    h2.IsSynchronized ? "synchronized" : "not synchronized");

            // Using Count Property
            Console.WriteLine("Total Number of Elements in h1: " + h1.Count);
        }
        [Test]
        public void Hashtablei() 
        {
           


                // Creating a Hashtable and 
                // giving it a size of 4
                Hashtable myTable = new Hashtable(4);

                // Adding elements in Hashtable
                myTable.Add("1", "C");
                myTable.Add("2", "C#");
                myTable.Add("3", "DS");
                myTable.Add("4", "Java");
                myTable.Add("5", "HTML");
                myTable.Add("6", "CSS");             

                Console.WriteLine(myTable.IsFixedSize);
            Hashtable Shallow = new Hashtable();
            Shallow = (Hashtable)myTable.Clone();
            Console.WriteLine("Cloned Table :");
            foreach (DictionaryEntry item in Shallow)
            {
                Console.WriteLine("Key " + item.Key +
                             " Value " + item.Value);
            }
            bool compare= myTable.Equals(myTable);
            bool equal=  myTable.Equals(Shallow);
           bool containValue= myTable.ContainsValue("C");
           bool containsKey=    myTable.ContainsKey("2");
           myTable.Remove("1");
            Console.WriteLine($"Count after removed : {myTable.Count!=6}");
           bool contains= myTable.Contains("1");
            myTable.Clear();            
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);

        }
        }
    
}

