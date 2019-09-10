//bibliotecas que são utilizadas 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nome e pasta em que o projeto está localizado 
namespace Locacao_Livro
{
    //A classe onde inicializa todo o procedimento 
    class Program
    {
        //Main primeiro método a ser executado
        static void Main(string[] args)
        {
            //CONSOLE classe do sistema, dando diversas funções que intaragem com o console do windows
            //diferença entre write e writeLine, o write line pula uma linha 
            Console.WriteLine("Informe o livro a ser consultado:");
            //parte do código que recebe as informações de registro do livro e coloca na variavel 
            var numeroDoLivro = Console.ReadLine();
        
            if(numeroDoLivro == "1233456")
            {
                Console.WriteLine("Livro indisponível");
                Console.ReadKey();
                //finaliza o metodo 
                return;
            }
            else
            {
                Console.WriteLine("Livro disponível");
            }
            Console.ReadKey();



        }
    }
}
