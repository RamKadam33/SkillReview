using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview
{
    public class ReadOnlyTest
    {
        public const double Pi = 3.14159;
        public static DateTime StartTime;
        public readonly Guid InstanceId;

        static ReadOnlyTest()
        {
            StartTime = DateTime.Now;
        }

        public ReadOnlyTest()
        {
            InstanceId = Guid.NewGuid();
                 }
        
        public void Show()
        {
            Console.WriteLine($"const Pi: {Pi}");
            Console.WriteLine($"static readonly StartTime: {StartTime}");
            Console.WriteLine($"readonly InstanceId: {InstanceId}");
         
        }


        

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }
    }

}
