using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.SOLID
{
    public class Triangle:IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
