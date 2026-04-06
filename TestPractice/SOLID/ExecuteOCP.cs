using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.SOLID;

namespace TestPractice.SOLID
{
    public class ExecuteOCP
    {
        [Test]
        public  void OCP()
        {
            AreaCalculator calculator = new AreaCalculator();

            IArea rectangle = new Rectangle { Width = 5, Height = 10 };
            IArea circle = new Circle { Radius = 3 };
            IArea triangle = new Triangle { Base = 4, Height = 6 };

            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(rectangle)}");
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(circle)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(triangle)}");
        }
    }
}
