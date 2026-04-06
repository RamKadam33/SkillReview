using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Builder
{
    public class Computer
    {//product
        private String cpu;
        private String ram;
        private String storage;

        public void SetCPU(String cpu) { this.cpu = cpu; }

        public void SetRAM(String ram) { this.ram = ram; }

        public void SetStorage(String storage)
        {
            this.storage = storage;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Computer Configuration:\n"
                               + "CPU: " + cpu + "\n"
                               + "RAM: " + ram + "\n"
                               + "Storage: " + storage + "\n");
        }
    }
}
