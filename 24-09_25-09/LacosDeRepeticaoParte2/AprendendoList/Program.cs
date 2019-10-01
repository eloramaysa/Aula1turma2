using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
       static List<string> minhaListaPulgmatica = new List<String>()
            {
                "Felipe",
                "Irineu",
                "Serilop",
            };
        static void Main(string[] args)
        {

            Console.ForegroundColor= ConsoleColor.Magenta;
            
            AdicionarItensALista();
          
           
            ListaInformacoes();
            
            Console.ReadKey();
            
        }
        /// <summary>
        /// Metodo que adiciona um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.WriteLine("\r\nInforme um nome:");
            var nome = Console.ReadLine();
            minhaListaPulgmatica.Add(nome);
           
            Console.WriteLine($"Nome: {nome} foi adicionado a lista");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? sim(S) não(N)");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s") AdicionarItensALista();
            Console.Clear();
        }
        /// <summary>
        /// Metodo que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.WriteLine("Nomes Adicionados a lista:");
            foreach (var item in minhaListaPulgmatica) Console.WriteLine($"Nome: {item.ToUpper()} foi adicionado a lista");
        }
    }
}
