using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowInitAppText();
            string nome = string.Empty;
            int idade = 0;
            char sexo= char.MinValue;
            string descricao = string.Empty; 
            while ( AskToContinue() == 1)
            {
                nome= AskToName();
                idade = AgeAnswer(nome);
                sexo = AskToSex();
                descricao = Decription();

            }
            
            Console.WriteLine($"\n Seu nome é: {nome} seu sexo é {sexo} e a sua idade é: {idade} anos");
            Console.WriteLine($"\n Sobre você: {descricao}");
            Console.ReadKey();

        }

        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema 
        /// </summary>
        //void não retorna nada, apenas mostra 
        private static void ShowInitAppText()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Seja Bem Vindo!");
            Console.WriteLine("----------------");
        }
        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns> retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("\n Vamos Conversar? sim(1) não(2)");
            //Uma única interação, não precisa apertar o número e o enter: User Experience, Usar interface. Deixar o sistema intuitivo
            //readKey espera uma única tecla
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }
        /// <summary>
        /// Metodo para saber a idade do usuário
        /// </summary>
        //não precisa retornar nada, pode ser void nesse caso e realizar tudo no método
        private static int AgeAnswer(String nome )
        {
            Console.WriteLine("\n Quantos anos Você tem?");
            var idade = int.Parse(Console.ReadLine());
            
            if (idade >= 18)
                Console.WriteLine($" {nome} Você é maior de idade e pode consumir bebida alcoolica");

            else
                Console.WriteLine($" {nome} Você é menor de idade e não pode consumir bebida alcoolica");
            return idade;

        }
        /// <summary>
        /// Metodo para perguntar o nome
        /// </summary>
        /// <returns>Retorna o nome informado</returns>
        private static string AskToName()
        {
            Console.WriteLine("\n Qual o seu nome?");
           return Console.ReadLine();

        }
        /// <summary>
        /// Metodo para saber o sexo do usuario
        /// </summary>
        /// <returns></returns>
        private static char AskToSex()
        {
            Console.WriteLine("\n Qual o seu sexo Feminino(F), Masculino(M), Outro (O)");
            return Console.ReadKey().KeyChar;
        }
        /// <summary>
        /// Metodo para saber sobre o usuario 
        /// </summary>
        /// <returns></returns>
        private static string Decription()
        {
            Console.WriteLine("\n Fale um pouco sobre você: ");
            return Console.ReadLine();
        }
    }
}
