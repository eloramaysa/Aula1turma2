using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] notas = new double[4];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe a nota {i+1}");
              notas[i]= Convert.ToDouble(Console.ReadLine());
                
            }
        }
    }
}
