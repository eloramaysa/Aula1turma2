using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPrimo = 2;

            for (int i = 2; i <= 100; i++)
            {
                while (true)
                {
                    if (numPrimo % i != 0)
                    {
                        Console.WriteLine(numPrimo);
                    }
                    numPrimo++;
                }
               

            }
            Console.ReadKey();
        }

        /* int i = 2;
         while (i <= 500)
         {
             int j = 2;
             while (j < i && i % j != 0)
                 j++;
             if (i == j)
                 Console.WriteLine(i.ToString());
             i++;
         }
         Console.ReadKey();

     } */

    }
}


