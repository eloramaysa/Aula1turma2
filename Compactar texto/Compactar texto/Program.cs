using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compactar_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = " oi meu nome e elora e me chamo elora e meu primeiro nome e elora";

                Console.WriteLine($"Texto contem: {primeiroTexto.Length}caractere");
            

            primeiroTexto = primeiroTexto.Replace("elora", "1");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length}caractere");
            Console.ReadKey();
        }
    }
}
