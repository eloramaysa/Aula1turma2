using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoNomes.Controller;
using BancoNomes.Model;
namespace ListaDeNomes
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            var resposta = int.MinValue;
            while (resposta != 0 )
            {
                Console.WriteLine("Informe a opção que deseja:");
                Console.WriteLine("1- Listar Nomes");
                Console.WriteLine("2 - Inserir Nomes");
                Console.WriteLine("0 - Sair");
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        ListarNomes();
                        break;
                    case 2:
                        AdicionarNome();
                        break;
                    default:
                        break;
                }

                Console.ReadKey(true);
                Console.Clear();
            }
            
        }

        public static void AdicionarNome()
        {
            Console.WriteLine("Informe o Nome:");
              var nome = Console.ReadLine();

           var resultado = pessoa.AdicionarPessoa(new Pessoa() { Nome = nome});
            if (resultado) Console.WriteLine("Adição realizada com sucesso!");

            Console.WriteLine("Deseja Inserir Novo nome? Sim 1 Não 2");
            var resposta = int.Parse(Console.ReadLine());
            
            if (resposta == 1) AdicionarNome();


        }

        public static void ListarNomes()
        {
            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine($"Nome: {x.Nome}"));
        }
    }
}
