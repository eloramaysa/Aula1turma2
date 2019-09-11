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
            int numPrimo = 1;

            for (int i = 1; i<=100; i++) { 

                if(numPrimo%i == 0 && numPrimo % 2 != 0 && numPrimo == i) {
                    Console.WriteLine(numPrimo);
           
                }
                numPrimo = numPrimo + 1;
            }
            Console.ReadKey();


        }  
            }
            }
        

       
