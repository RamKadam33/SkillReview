using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Builder
{
    internal class ComputerDirector
    {
        public void Construct(Builder builder)
        {
            builder.buildCPU();
            builder.buildRAM();
            builder.buildStorage();
        }
    }
}
