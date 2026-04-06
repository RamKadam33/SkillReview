using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.SOLID
{
    public class AreaCalculator
    {
        public double CalculateArea(IArea shape)
        {
            return shape.GetArea();
        }
    }
}
