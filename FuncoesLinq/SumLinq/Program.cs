using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomarInteiroPrimitivos();
            // SomaInteirosLista();
            SomaBalasListaDeCriancas();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo e soma ela pelo sum
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos [] em um tipo primitivo podemos crar uma colecao destes valores
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            //Sum retorna a soma total dos valores presentes na lista
            Console.WriteLine(colecaoInteiros.Sum());  
        }


        /// <summary>
        /// Metodo que soma os valores em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            { 1,2,3,4,5};

           // listaDeInteiros.ForEach(i => Console.WriteLine(i));
            Console.WriteLine(listaDeInteiros.Sum());
        }


        /// <summary>
        /// Meetodo que soma a quantidade de bala das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome="Joazinho",
                    Balas=9
                },
                new Crianca()
                {
                    Nome="Pedrinho",
                    Balas=68
                }
            };
            Console.WriteLine("Quantidade total de bala das crianças");
            //Soma a quantidade de balas das crianças
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }

    }
}
