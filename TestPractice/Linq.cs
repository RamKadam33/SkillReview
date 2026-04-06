using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    public class Linq
    {
        [Test]
        public void linq() { 
        
        Dictionary<string, int> studentMarks = new Dictionary<string, int>
        {
            { "Alice", 85 },
            { "Bob", 92 },
            { "Charlie", 78 },
            { "Diana", 90 },
            { "Ethan", 88 },
            { "Fiona", 81 },
            { "George", 32 },
            { "Hannah", 95 },
            { "Ian", 84 },
            { "Julia", 91 },
            { "Kevin", 33 },
            { "Laura", 91 },
            { "Mike", 33 },
            { "Nina", 80 },
            { "Oscar", 34 },
            { "Paula", 93 },
            { "Quentin", 82 },
            { "Rachel", 86 },
            { "Sam", 79 },
            { "Tina", 94 }
        };
        string[] failedStudent=studentMarks.Where(e=>e.Value<35).Select(e=>e.Key.ToString()).ToArray();
            Console.WriteLine($"Failed students are :");
            foreach (string s in failedStudent) 
            Console.WriteLine(s);

            var studentsWithSameMark = studentMarks.GroupBy(kvp => kvp.Value).Where(g => g.Count() > 1).Select(g => new { Mark = g.Key, Students = g.Select(kvp => kvp.Key).ToList() });
            Console.WriteLine($"Students with same marks are :");
            foreach (var group in studentsWithSameMark)
            {
                Console.WriteLine($"Mark: {group.Mark}, Students: {string.Join(", ", group.Students)}");
            }
            var topper = studentMarks.OrderBy(kvp => kvp.Value).Last();

            Console.WriteLine($"Topper: {topper.Key}, Marks: {topper.Value}");
        }

    }
}
