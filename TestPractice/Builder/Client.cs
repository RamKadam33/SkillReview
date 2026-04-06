using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Builder
{
    public class Client
    {
       
        [Test]
         public void BuilderPattern()
         { 
            GamingComputerBuilder gamingBuilder
                = new();
            ComputerDirector director = new();

            director.Construct(gamingBuilder);
            Computer gamingComputer = gamingBuilder.getResult();
            gamingComputer.DisplayInfo();
            Assert.Pass();

        }
    }
}
