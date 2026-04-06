using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    internal class OrderArray
    {
        [Test]
        public void order()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length -i- 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Print sorted array
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
