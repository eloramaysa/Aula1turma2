using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        /*Criar um console app que quando informado o texto contendo banana ele troque esta informação
por laranja.*/ 
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto contendo a palavra banana");
            string texto = Console.ReadLine();
            Console.WriteLine(texto.Replace("banana" , "laranja"));
            Console.ReadKey();
        }
    }
}
