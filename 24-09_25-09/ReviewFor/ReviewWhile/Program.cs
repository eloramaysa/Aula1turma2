using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto");
            var conteudoDoTexo = Console.ReadLine();
            var count = 0;
            while (count < conteudoDoTexo.Length)
            {
                Console.WriteLine(conteudoDoTexo[count]);
                count++;
            }
            Console.ReadKey();
        }

    }
}
