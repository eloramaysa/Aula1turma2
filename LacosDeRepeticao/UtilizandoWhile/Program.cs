using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0; 

            //enquanto a condição for verdade executa 
            while (count < 10000)
            {

                Console.WriteLine($"Número: {count}");
                //Vai pulando de 5 em 5 
                count+=5; 

            }

            Console.WriteLine("terminou o loop");
            Console.ReadKey();
        }
    }
}
