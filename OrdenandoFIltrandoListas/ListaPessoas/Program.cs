using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adicionando Pessoas
            var listaDePessoas = new List<Pessoa>
            {
                new Pessoa()
                {
                    Id = 1,
                    Nome = "Spears",
                    DataDeNascimento=DateTime.Parse("07/11/2004"),
                    ValorCarteira =  846.96
                },
                new Pessoa()
                {
                    Id = 2,
                    Nome = "Swanson",
                    DataDeNascimento=DateTime.Parse("20/06/2003"),
                    ValorCarteira =   233.09
                },
                new Pessoa()
                {
                    Id = 3,
                    Nome = "Gay",
                    DataDeNascimento=DateTime.Parse("03/12/2001"),
                    ValorCarteira =911.92
                },
                 new Pessoa()
                {
                    Id = 4,
                    Nome = "Gregory",
                    DataDeNascimento=DateTime.Parse("02/01/2000"),
                    ValorCarteira = 469.01
                },
                 new Pessoa()
                {
                    Id = 5,
                    Nome = "Olson",
                    DataDeNascimento=DateTime.Parse("18/07/2001"),
                    ValorCarteira = 261.90
                },
                 new Pessoa()
                {
                    Id = 6,
                    Nome = "Garza",
                    DataDeNascimento=DateTime.Parse("01/04/2000"),
                    ValorCarteira =  360.41
                },
                  new Pessoa()
                {
                    Id = 7,
                    Nome = "Sweet",
                    DataDeNascimento=DateTime.Parse("12/03/2003"),
                    ValorCarteira =  312.76
                },
                   new Pessoa()
                {
                    Id = 8,
                    Nome = "Cline",
                    DataDeNascimento=DateTime.Parse("26/03/2002"),
                    ValorCarteira = 484.51
                },
                      new Pessoa()
                {
                    Id = 8,
                    Nome = "Cline",
                    DataDeNascimento=DateTime.Parse("26/03/2002"),
                    ValorCarteira = 484.51
                },
                new Pessoa()
                {
                    Id = 9,
                    Nome = "Oliver",
                    DataDeNascimento=DateTime.Parse("05/07/2004"),
                    ValorCarteira = 513.76
                },
                new Pessoa()
                {
                    Id = 10,
                    Nome = "Vang",
                    DataDeNascimento=DateTime.Parse("10/07/2000"),
                    ValorCarteira =  271.05
                },
                new Pessoa()
                {
                    Id = 11,
                    Nome = "Maddox",
                    DataDeNascimento=DateTime.Parse("29/05/2004"),
                    ValorCarteira =  783.97
                },
                 new Pessoa()
                {
                    Id = 12,
                    Nome = "Garrett",
                    DataDeNascimento=DateTime.Parse("03/06/2006"),
                    ValorCarteira =   154.11
                },
                 new Pessoa()
                {
                    Id = 13,
                    Nome = "Mcintosh",
                    DataDeNascimento=DateTime.Parse("06/07/2006"),
                    ValorCarteira = 902.80
                },
                 new Pessoa()
                {
                    Id = 14,
                    Nome = "Yang",
                    DataDeNascimento=DateTime.Parse("29/04/2005"),
                    ValorCarteira =  550.48
                },
                 new Pessoa()
                {
                    Id = 15,
                    Nome = "Hendricks",
                    DataDeNascimento=DateTime.Parse("05/09/2003	"),
                    ValorCarteira =410.56
                },
                  new Pessoa()
                {
                    Id = 16,
                    Nome = "Cain",
                    DataDeNascimento=DateTime.Parse("12/01/2002	"),
                    ValorCarteira =221.13
                },
                    new Pessoa()
                {
                    Id = 17,
                    Nome = "Blackburn",
                    DataDeNascimento=DateTime.Parse("10/05/2000	"),
                    ValorCarteira =135.67
                },
                     new Pessoa()
                {
                    Id = 18,
                    Nome = "Howe",
                    DataDeNascimento=DateTime.Parse("27/09/2005"),
                    ValorCarteira = 360.14
                },
                      new Pessoa()
                {
                    Id = 19,
                    Nome = "Pratt",
                    DataDeNascimento=DateTime.Parse("18/09/2000"),
                    ValorCarteira =  991.83
                },
                         new Pessoa()
                {
                    Id = 20,
                    Nome = "Sherman	",
                    DataDeNascimento=DateTime.Parse("20/02/2003"),
                    ValorCarteira =  667.00
                },
            };
            #endregion

            #region Filtros Por Nome e Idade 
            Console.WriteLine("Nomes em ordem Alfabética");
            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i =>
            Console.WriteLine($" Id {i.Id } Nome: {i.Nome} Data de Nascimento: {i.DataDeNascimento} Carteira: R$ {i.ValorCarteira}"));
            Console.ReadKey();
            Console.Clear();
           


            Console.WriteLine("Nomes em ordem do mais novo para o mais velho");
            listaDePessoas.OrderByDescending(x => x.DataDeNascimento).ToList<Pessoa>().ForEach(i => 
            Console.WriteLine($" Id {i.Id } Nome: {i.Nome} Data de Nascimento: {i.DataDeNascimento} Carteira: R$ {i.ValorCarteira}"));
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Filtro Carteira > 500 reais
            Console.WriteLine("Nome das pessoas que tem mais de 500 reais na carteira:");
            listaDePessoas.FindAll(x=> x.ValorCarteira > 500).ToList<Pessoa>().ForEach(i =>
            Console.WriteLine($" Id {i.Id } Nome: {i.Nome} Data de Nascimento: {i.DataDeNascimento} Carteira: R$ {i.ValorCarteira}"));
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Filtros 18 anos e 16 anos  
            Console.WriteLine("Nome das pessoas que são maiores de 18 anos ou tem 18 anos");
            listaDePessoas.FindAll(x=> (DateTime.Now.Year - x.DataDeNascimento.Year) >=18).ToList<Pessoa>().ForEach(i =>
            Console.WriteLine($" Id {i.Id } Nome: {i.Nome} Data de Nascimento: {i.DataDeNascimento} Carteira: R$ {i.ValorCarteira}"));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Nome das pessoas que são menores de 16 anos");
            listaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataDeNascimento.Year) <= 16).ToList<Pessoa>().ForEach(i =>
            Console.WriteLine($" Id {i.Id } Nome: {i.Nome} Data de Nascimento: {i.DataDeNascimento} Carteira: R$ {i.ValorCarteira}"));
            Console.ReadKey();
            #endregion
        }
    }
}
