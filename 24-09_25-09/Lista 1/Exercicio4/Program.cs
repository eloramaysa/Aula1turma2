using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        /* Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado
pelo usuário.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto:");
            string texto = Console.ReadLine();
            Console.WriteLine($"O seu texto tem {texto.Length} caracteres");
            Console.ReadLine();
        }
    }
}
