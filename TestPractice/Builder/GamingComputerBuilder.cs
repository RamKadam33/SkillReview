using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Builder
{//Implementation of builder
    internal class GamingComputerBuilder:Builder
    {
        private readonly Computer Computer = new Computer();

        public void buildCPU()
        {
            Computer.SetCPU("Gaming CPU");
        }

        public void buildRAM() { Computer.SetRAM("16GB DDR4"); }

        public void buildStorage()
        {
            Computer.SetStorage("1TB SSD");
        }

        public Computer getResult() { return Computer; }
    }
}
