using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrosExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            //gerar numero aleatorio usa classe Random 

            Random rdm = new Random();
           

            for (int i = 0; i < 10; i++)
            {
                // gera um numero aleatorio de 0 a 100
                int valorAleatorio = rdm.Next(100);
                //verifica se a lista nao contem esse numero gerado 
                if (!numeros.Contains(valorAleatorio)) numeros.Add(valorAleatorio);
                // caso contenha n vai adicionar vai decrementar e voltar para o for e repetir a contagem do numero
                else i--; 
            }
            numeros.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
