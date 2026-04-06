using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.SOLID
{
    public class Circle:IArea
    {
        public double Radius { get; set; }
        public  double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
