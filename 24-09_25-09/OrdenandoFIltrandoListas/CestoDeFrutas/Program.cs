using CestoDeFrutas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Carregando A cesta
            var cestaDeFrutas = new List<Fruta>();

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 90
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 350
            });
            #endregion

            // #region #endregion 

            #region Listas OrderBy
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));
            Console.WriteLine("-----------------------------------------------------------------------");

            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));
            Console.WriteLine("-------------------------------------------------------------------------");

            //Vai ordenar por ordem alfabética
            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));
            #endregion

            #region   Listas Filtradas
            Console.WriteLine("--------------------------Filtro Peso-----------------------------------");
            var filtro = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            filtro.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");

            //frutinha recebe cada fruta de nossa cesta 
            (from frutinha in cestaDeFrutas // Aqui temos a colecao de frutas
             where frutinha.Nome == "Manga" // aqui escolhemos somente a fruta que tenha esse nome
             select frutinha)//neste ponto junta-se as informações que foi filtrado e retorno
             .ToList<Fruta>() // convertemos uma lista amiga novamente 
                .ForEach(i => Console.WriteLine($"Fruta escolhida: {i.Nome}")); // imprimimos estas informações pelo console
            #endregion

            #region Filtro Cores
            Console.WriteLine("----------------------Filtro Cores ---------------------------------");

         
            var mostrandoFindALL = cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho").OrderBy(x => x.Nome);

            mostrandoFindALL.ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta: {i.Nome}"));


            #endregion

            Console.WriteLine("===========Find com Order By========================");
            // find retorna apenas um item da lista e vai pegar o primeiro que vai estar na sua lista de acordo com a condição determinada

            var cestaOrderByFind = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id {cestaOrderByFind.Id} Nome {cestaOrderByFind.Nome}");
            Console.ReadKey();
        }
    }
}
