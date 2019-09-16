using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingForeach();
            Console.ReadKey();
        }
        private static void UsingForeach()
        {
            Console.WriteLine("Informe o seu nome");

            var substituicao=  string.Empty;
            var texto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçoes; 
vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            var text = "Informe uma palavra para realizar a busca";
            var palavra = ValidText(text);
            var textoComSplit = texto.Split(';');
            foreach (var item in textoComSplit)
            {
                if (palavra == item)
                {
                    Console.WriteLine("Palavra encontrada");
                     substituicao = palavra;
                }
                    
            }
            //texto = texto.Replace(substituicao, "Elora");
            //Console.WriteLine(texto);

        }

        private static string ValidText(String text)
        {
            var answer = string.Empty;
            try
            {
                Console.WriteLine(text);
                answer = Console.ReadLine();
            }
            catch 
            {
                answer = ValidText(text);
            }
            return answer;
        }
            
       
    }
}
