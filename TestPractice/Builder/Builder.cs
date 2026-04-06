using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Builder
{
    public interface Builder
    {
        //builder interface
        void buildCPU();
        void buildRAM();
        void buildStorage();
        Computer getResult();
    }
}
