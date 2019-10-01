using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        /*Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada. */
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra");
            string palavra = Console.ReadLine();
            Console.WriteLine($"O primeiro caracter da sua palavra é {palavra [0]} e o último caracter é {palavra[palavra.Length -1]}");
            Console.ReadKey();
        }
    }'0
}
