using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        /* Criar um console app que apresente as boas vindas, solicite o nome do usuário completo e
mostre uma mensagem de boas vindas com o nome do usuário.*/
        static void Main(string[] args)
        {
            var nomeCompleto = WelcomeAndName();
            var nomes = nomeCompleto.Split(' ');
            //var nome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            var primeiroNome = nomes[0];
            var sobrenome = nomes[1];
            Console.WriteLine($"Seja bem vindo(a) {primeiroNome} seu sobrenome é {sobrenome} ");
            Console.ReadKey();

        }
        /// <summary>
        /// Método para Dar boas vindas e pedir o nome do usuário 
        /// </summary>
        /// <returns></returns>
        private static string WelcomeAndName()
        {
            Console.WriteLine("Seja bem Vindo! Qual o seu nome completo");
            return Console.ReadLine();
        }

    }
}
