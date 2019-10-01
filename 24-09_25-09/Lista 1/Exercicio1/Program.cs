using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        /*Criar um console app que apresente as boa vindas mostre um texto, e depois indique que o mesmo
        deverá apertar qualquer tecla para finalizar. */
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem Vindo!");
            Console.WriteLine(" \n"+ Text());
            Console.WriteLine("\n Aperte para em qualquer tecla para sair");
            Console.ReadKey();
        }
        private static string Text()
        {
            return @"Receita de Macarrão instantâneo, ou o bom e velho miojão, não precisa ser feito só com o tempero de pozinho. Quer dar uma caprichada no seu? 
cebola picada e acrescente rúcula, tomate seco e mussarela de búfala. 
Junte tudo ao miojo cozido e acerte o sal e a pimenta do reino. Não use o tempero pronto.";
        }
    }
}
