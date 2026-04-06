using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.SOLID
{
    public class Cube: IArea, IVolume
    {
        public double Side { get; set; }
        public double GetArea()
        { return 6 * Side * Side;  }

        public double GetVolume()
        { return Side* Side *Side; }
    }
}
