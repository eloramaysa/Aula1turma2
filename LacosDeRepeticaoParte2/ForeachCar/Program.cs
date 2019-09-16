using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachCar
{
    class Program
    {
        static void Main(string[] args)
        {
            InformationsCar();
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo de busca com split informando o modelo apresenta a marca e o ano do carro 
        /// </summary>
        private static void InformationsCar()
        {
            var conteudo = "Modelo:Gol,Marca:Volkswagen,Ano:2015;Modelo:Uno,Marca:FIAT,Ano:2010;Modelo:Etios,Marca:Toyota,Ano:2018";
            //cria uma lista a cada ; encontrado separando por cada tipo de carro. 
            var informationList = conteudo.Split(';');

            Console.WriteLine("Carros cadastrados:");
            foreach (var item in informationList)
            {
                //separa cada item por novos termos a cada , encontrada e pega a posicao 0 nesse caso a que tem o modelo do carro 
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um modelo de carro do sistema");
            var modeloBusca = Console.ReadLine();

           

            }

        }
        private static string[] RetornaVeiculo(string conteudo, string nomeVeiculo)
        {
            var informacoesLista = conteudo.Split(',');
            foreach (var item in informacoesLista)
            {
                var separandoInformacoes = item.Split(',');
                var nomeDoCarro = ObterValor(separandoInformacoes[0]);

                
            }
            return new string[0];
        }
        private static string ObterValor(string colecao)
        {
            return colecao.Split(':')[1];
        }
        
    }

}
