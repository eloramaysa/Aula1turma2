using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMaior18
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = @"nome:Felipe,idade:27;nome:Giomar,idade:17; 
nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45;nome:Ana,idade:18;nome:Maria,idade:14";

            SepararConteudo(conteudo);
            Console.ReadKey();
        }
        private static void SepararConteudo(String conteudo)
        {
            var cadastroSeparado = conteudo.Split(';');
          Console.WriteLine("Pessoas maiores de idade\r\n");
            foreach (var item in cadastroSeparado)
            {
               
                var topicosSeparados = item.Split(',');
                var nome = topicosSeparados[0].Split(':')[1];
                var idade = int.Parse(topicosSeparados[1].Split(':')[1]);
                if(idade>= 18) Console.WriteLine($"{nome} é maior de idade e tem {idade} anos"); 
            }

        }
        
    }
}
