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
           
            double raio, area; 
            Console.WriteLine("Informa o valor do raio do círculo");

            raio= Convert.ToDouble(Console.ReadLine());

            area = 2 * Math.PI * raio;

            Console.WriteLine("A área do círculo é "+ area);
            Console.ReadKey();

        }
    }
}
