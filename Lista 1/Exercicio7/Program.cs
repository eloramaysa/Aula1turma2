using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        /*Criar um console app conte a quantidade de "a","e","i","o" e "u" dentro de um texto informado
pelo usuário.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto");
            string texto = Console.ReadLine();
            FindChar(texto);
        }

        public static void FindChar(String texto)
        {
            int tamanhoTexto = texto.Length;
            int contador = 0;
            int contA = 0;
            int contE = 0;
            int contI = 0;
            int contO = 0;
            int contU = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u') contador++;
                if (texto[i] == 'A' || texto[i] == 'E' || texto[i] == 'I' || texto[i] == 'O' || texto[i] == 'U') contador++;
                if (texto[i] == 'a' || texto[i] == 'A') contA++;
                if (texto[i] == 'e' || texto[i] == 'E') contE++;
                if (texto[i] == 'i' || texto[i] == 'I') contI++;
                if (texto[i] == 'o' || texto[i] == 'O') contO++;
                if (texto[i] == 'u' || texto[i] == 'U') contU++;

            }
            Console.WriteLine($"A quantidade de vogais é {contador}");
            string question = " \n Você deseja saber a quantidade de cada letra? Sim 1 Não 2";
            int resposta = getOption(question); 
            while (resposta != 2 && resposta != 1)
            {
                resposta = getOption(question);
            }
            if (resposta == 1)
            {
                Console.WriteLine($" \n A quantidade de letras A é {contA}");
                Console.WriteLine($"A quantidade de letras E é {contE}");
                Console.WriteLine($"A quantidade de letras I é {contI}");
                Console.WriteLine($"A quantidade de letras O é {contO}");
                Console.WriteLine($"A quantidade de letras U é {contU}");
            }

            Console.ReadKey();

        }

        public static int getOption(string question)
        {
            int result = 0;
            try
            {
                Console.WriteLine(question);
                result = int.Parse(Console.ReadKey().KeyChar.ToString());
            } catch
            {
              result = getOption(question);
            }
            return result;
        }
    }
}
