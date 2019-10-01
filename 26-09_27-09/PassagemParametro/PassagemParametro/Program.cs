using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemParametro
{
    class Program
    {
        static void Hebeficar(out int idade)
        {
            idade = 16000; 

        }
        static void Main(string[] args)
        {
            int ii = 30;
            //ref significa que o que for fazer com ii vai ser feito com idade
            // out é a mesma coisa mas não precisa inicializar a variavel 
            Hebeficar(out ii);
            //Console.WriteLine(ii);
           
            int resultadoConversao = 0;
            //TryParse converte e valida se caso o string foi kkk ou null resulta em 0 
            int.TryParse(Console.ReadLine(), out resultadoConversao);
            Console.WriteLine(resultadoConversao);
            Console.ReadKey();
        }            
    }
}
