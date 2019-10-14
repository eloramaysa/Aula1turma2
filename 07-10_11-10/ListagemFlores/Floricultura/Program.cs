using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoFlores.Controller;
using BancoFlores.Model;
namespace Floricultura
{
    class Program
    {
        static FlorController flor = new FlorController();
        static void Main(string[] args)
        {
            int resp = int.MinValue;
            while (resp !=0)
            {
                Console.WriteLine("Informe a opção");
                Console.WriteLine("1- Cadastrar Flor");
                Console.WriteLine("2- Listar Flores");
                Console.WriteLine("3- Total de Flores");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        AdicionarFlor();
                        break;
                    case 2:
                        ListarFlor();
                        break;
                    case 3:
                        Console.WriteLine($"O Total de Flores é: {flor.SomaFlores()}");
                        break;
                    default:
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
            }
            

        }
        static void ListarFlor()
        {
            flor.GetFlores().ToList<Flor>().ForEach(x => Console.WriteLine($"Nome da Flor: {x.Nome} Quantidade: {x.Quantidade}"));
        }



        static void AdicionarFlor()
        {
            Flor florAdd = new Flor();
            Console.WriteLine("Informe o nome da Flor");
            florAdd.Nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de Flores:");
            florAdd.Quantidade = int.Parse(Console.ReadLine());

             var resultado= flor.AdicionarFlor(florAdd);

            if (!resultado)
            {
                Console.WriteLine("Erro ao cadastrar a flor");
                return;
            }
            Console.WriteLine("Flor cadastrada com sucesso");
            Console.WriteLine("Deseja cadastrar outra flor 1 Sim 2 Nao");
            var cadastrar = int.Parse(Console.ReadLine());

            if (cadastrar == 1) AdicionarFlor();

         }

    }
}
