using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Elora Maysa";
            var countFind = 0;
            for (int i = 1; i < 10; i++)
            {
                var stringBuilder = $"{nome[i - 1]}-{nome[i]}-{nome[i + 1]}";
                Console.WriteLine(stringBuilder);
                if (stringBuilder.Contains("o-r")) countFind++;
                
            }
            Console.WriteLine($"A quantidade total de {countFind}");
            Console.ReadKey();
        }
    }
}
