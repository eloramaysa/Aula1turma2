using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogosCelulares.Controller;
using CatalogosCelulares.Model;
namespace CellDu
{
    class Program
    {
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            Menu();
        }
        /// <summary>
        /// Metodo que armazeno o menu de opções para o usuário
        /// </summary>
        public static void Menu()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Sistema de Celular");
                Console.WriteLine("Informe a opção que deseja:");
                Console.WriteLine("1- Inserir novo celular");
                Console.WriteLine("2 - Listar celulares");
                Console.WriteLine("3- Atualizar celular");
                Console.WriteLine("4 - Remover celular");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        ListarCelular();
                        break;
                    case 3:
                        AtualizarCelular();
                        break;
                    case 4:
                        RemoverCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para voltar para o menu");
                Console.ReadKey(true);
                Console.Clear();
            }

        }


        /// <summary>
        /// Metodo para inserir novo celular no sistema
        /// </summary>
        public static void InserirCelular()
        {
            Console.WriteLine("---Inserir celular---");
            Console.WriteLine("Informe a Marca do celular");
            var marca = Console.ReadLine();

            Console.WriteLine("informe o Modelo do celular");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do celular");
            var preco = Double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });

            if (resultado) Console.WriteLine("Celular cadastrado com sucesso ");
            else Console.WriteLine("Erro ao cadastrar o aparelho!");
        }


        /// <summary>
        /// Metdo que atualiza o celular na lista de celulares
        /// </summary>
        public static void AtualizarCelular()
        {
            Console.WriteLine("---Atualizar celular---");

            ListarCelular();

            Console.WriteLine("\n Informe o Id para alteração de registro");
            var celularID = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que será atualizado
            var celular = celulares.GetCelulares().FirstOrDefault(x => x.Id == celularID);

            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("\nInforme a Marca do celular");
            celular.Marca = Console.ReadLine();

            Console.WriteLine("informe o Modelo do celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do celular");
            celular.Preco = Double.Parse(Console.ReadLine());

            var resultado = celulares.AtualizarCelular(celular);

            if (resultado) Console.WriteLine("Celular atualizado com sucesso ");
            else Console.WriteLine("Erro ao atualizar o aparelho!");

        }
        
        /// <summary>
        /// Metodo para remover um celular da lista
        /// </summary>
        public static void RemoverCelular()
        {
            Console.WriteLine("---Remover celular---");

            ListarCelular();

            Console.WriteLine("\n Informe o Id para remoção do registro");
            var celularID = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularID);
            if (resultado) Console.WriteLine("Removido com Sucesso!");
            else Console.WriteLine("Erro ao remover o aparelho");

        }


        /// <summary>
        /// Metodo para listar todos os celulares ativos 
        /// </summary>
        public static void ListarCelular()
        {
            Console.WriteLine("--Lista de Celulares--");
            celulares.GetCelulares().ToList<Celular>().
                ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));
        }
    }
}
