using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachWithSplitList();


            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre uma array de caracteres, ou seja um texto, palavra.. 
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();
            foreach (var item in conteudoDoTexto)
            {
                //continue vai retornar para o foreach
                if (item == 'e') continue;
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// Metodo de busca com split e informando o nome 
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe o seu nome");
            var conteudoDoTexto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçoes; 
vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();
            //O split vai criar itens com base nos espaços, para cada espaço de diferença vai criar um item ex [0] Aqui [1] vou...,
            var conteudoDoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoDoTextoSplit)
            {
                if(palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
                
            }
        }

        private static void ForeachWithSplitList()
        {
            var conteudo = "nome:Elora,idade:21;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var informationList = conteudo.Split(';');
            Console.WriteLine("Usários cadastrados no sistema");

            foreach (var item in informationList)
            {
                Console.WriteLine(item.Split(',')[0]);
               
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();
            foreach (var item in informationList)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($" {nome} está com {idade} anos de idade");
                }
            }
            Console.ReadKey();
        }
    }
}
