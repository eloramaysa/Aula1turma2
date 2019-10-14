using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBike.Controller;
using BancoBike.Model;
using Newtonsoft.Json;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletaController bicicletaController = new BicicletaController();

       // static BicicletaContext bicicletaContext = new BicicletaContext();
        static void Main(string[] args)
        {
            Menu();   
        }

        public static void Menu()
        {
            int result = int.MinValue;
            while (result !=0 )
            {
                Console.WriteLine("--------Sistema Bicicleta---------");
                Console.WriteLine("Informe a opção que deseja");
                Console.WriteLine("1- Listar");
                Console.WriteLine("2- Adicionar");
                Console.WriteLine("3- Atualizar");
                Console.WriteLine("4- Remover");
                Console.WriteLine("0 - Sair");
                result = int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        ListarBikeOrd();
                        break;
                    case 2:
                        InserirBike();
                        break;
                    case 3:
                        AtualizarBike();
                        break;
                    case 4:
                        RemoverBike();
                        break;
                    default:
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        /// <summary>
        /// Metodo para Listar bicicletas ativa
        /// </summary>
        public static void Lista()
        {
            bicicletaController.GetBicicletas().ToList<Bicicleta>().
                ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));
        }

        /// <summary>
        /// Metodo para listar Bicicleta ordenada de maior preço e menor preço
        /// </summary>
        public static void ListarBikeOrd()
        {
            Console.WriteLine("------Lista de Bicicletas-----");
            var listaBike = bicicletaController.OrdenandoBike().ToList<Bicicleta>();
              
            listaBike.ForEach(x => Console.WriteLine($"Marca: {x.Marca} Modelo: {x.Marca} Preço: {x.Preco}"));
           
            var listaSum = bicicletaController.TotalBike();

            string listaOrdenada = JsonConvert.SerializeObject(listaBike);

            string listaSumJson = JsonConvert.SerializeObject(listaSum);

            
            //write string to file
            var date = DateTime.Now.ToString("yyyyMMddhhmmssffff");
            string path = ($"C:\\Users\\900080\\source\\repos\\eloramaysa\\Aula1turma2\\SistemaBicicletasBanco\\AquivosJSON\\lista{date}.txt");
            string caminho = ($"C:\\Users\\900080\\source\\repos\\eloramaysa\\Aula1turma2\\SistemaBicicletasBanco\\AquivosJSON\\soma{date}.txt");
            
            File.WriteAllText(path, listaOrdenada);
            File.WriteAllText(caminho, listaSumJson);
            

            Console.WriteLine("\n Deseja saber o preço total de bicicleta: 1 Sim 2 Nao");
            var resp = int.Parse(Console.ReadLine());
            if (resp == 1) Console.WriteLine($"Valor total: R$ {listaSum}");
            
        }

        /// <summary>
        /// Metodo para insertir bicicleta
        /// </summary>
        public static void InserirBike()
        {
            Bicicleta bikeAdd = new Bicicleta();

            Console.WriteLine("Informe a Marca da bicicleta");
            bikeAdd.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo da bicicleta");
            bikeAdd.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço da bicicleta");
            bikeAdd.Preco = double.Parse(Console.ReadLine());

            var resp = bicicletaController.InserirBicicleta(bikeAdd);
            if (!resp)
            {
                Console.WriteLine("Erro ao cadastrar bicicleta");
                return;
            }
            Console.WriteLine("Bicicleta cadastrada com sucesso");
        }

        /// <summary>
        /// Metodo para atualizar bike
        /// </summary>
        public static void AtualizarBike()
        {
            Lista();

            Console.WriteLine("Informe o id que deseja atualizar");

            int id = int.Parse(Console.ReadLine());

            var bicicleta = bicicletaController.GetBicicletas().FirstOrDefault(x => x.Id == id);
            if (bicicleta == null) 
            {
                Console.WriteLine("Id Não encontrado");
                    return;
            }
            Console.WriteLine("Informe a Marca da bicicleta");
            bicicleta.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo da bicicleta");
            bicicleta.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço da bicicleta");
            bicicleta.Preco = double.Parse(Console.ReadLine());

            var resp = bicicletaController.AtualizarBicicleta(bicicleta);
            if (!resp)
            {
                Console.WriteLine("Erro ao atualizar bicicleta");
                return;
            }
            Console.WriteLine("Bicicleta atualizada com sucesso");


        }

        /// <summary>
        /// Metodo para remover bicicleta
        /// </summary>
        public static void RemoverBike()
        {
            Lista();

            Console.WriteLine("Informe o Id da Bicicleta que deseja remover");
            int id = int.Parse(Console.ReadLine());
            var result = bicicletaController.GetBicicletas().FirstOrDefault(x => x.Id == id);
            if(result == null)
            {
                Console.WriteLine("Id não encontrado");
                return;
            }
            var resp = bicicletaController.RemoverBicleta(id);
            if (!resp)
            {
                Console.WriteLine("Erro ao remover bicicleta");
                return;
            }
            Console.WriteLine("Bicicleta Removida com sucesso");


        }


    }
}
