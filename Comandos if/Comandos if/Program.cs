using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine(nome + " Você é maior de idade");
            }
            else
            {
                Console.WriteLine(nome + " Você é menor de idade");

            }
            Console.ReadKey();
            
        }
    }
}
