using SkilReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    internal class Comparison
    {

        [Test]
        public void Compare() { 
        int a=10; int b=10;
            string c= "Ram";string d= "Kadam"; string e= "Ram";

            bool f= a==b;
            bool g=a.Equals(b);
            bool h=c.Equals(d);
            bool i=c==d;
            bool k = c.Equals(e);
            bool j=c==e;
        }
        [Test]
        public void Currency()
        {
            string a = "₹100,021";
           string b= a.RemoveCurrencySymbols();

            ReadOnlyTest demo1 = new ReadOnlyTest();
            ReadOnlyTest demo2 = new ReadOnlyTest();

            demo1.Show();
            Console.WriteLine();
            demo2.Show();

        }
        [Test]
        public void Compare2()
        {
            Person person1 = new Person { Name = "Alice", Age = 30 };
            Person person2 = new Person { Name = "Alice", Age = 30 };
            Person person3 = new Person { Name = "Bob", Age = 25 };

            bool areEqual1 = person1.Equals(person2); 
            bool areEqual2 = person1.Equals(person3); 
            bool areSameReference1 = object.ReferenceEquals(person1, person2); 
            bool areSameReference2 = object.ReferenceEquals(person1, person1); 
        }
        }
}
