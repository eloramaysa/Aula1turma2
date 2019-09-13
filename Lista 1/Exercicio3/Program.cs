using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
 /*Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
deverá apresentar quando maior ou igual a 18 anos a seguinte informação:
"Parabéns {nome} você já esta na fase adulta."
caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade."*/
        static void Main(string[] args)
        {
            var nome = Name();
            Age(nome);
            Console.ReadKey();
        }
        /// <summary>
        /// Método para perguntar o nome do usuário 
        /// </summary>
        /// <returns> nome do usuário</returns>
        private static string Name()
        {
            Console.WriteLine("Olá! Informe o seu nome:"); 
            return Console.ReadLine();
        }
        /// <summary>
        /// Método para saber a idade do usuário 
        /// </summary>
        /// <param name="nome"></param>
        private static void Age(string nome)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18) Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
        }
    }
}
