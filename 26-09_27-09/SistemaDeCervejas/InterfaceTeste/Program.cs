using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
namespace InterfaceTeste
{
    class Program
    {
        private static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {

            MostraMenu();

      
        }

        public static void MostraMenu()
        {
            Console.WriteLine("Sistema de Cerveja: ");
            Console.WriteLine("Selecione a opção que deseja:");
            Console.WriteLine("1 - Listar cervejas;");
            Console.WriteLine("2 - Total de cervejas que possui na Lista");
            Console.WriteLine("3 - Total de litros de cerveja que possui na Lista");
            Console.WriteLine("4 - Adicionar cerveja");
            Console.WriteLine("5- Verificar teor álcoolico");
            Console.WriteLine("0 - Sair");
            var resposta = int.MinValue;
            while (resposta != 0)
            {
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1: 
                        ListarCervejas();
                        LimparTela();
                         break;
                    case 2:
                        Console.WriteLine("Total de cervejas que tem na sua lista é: " + cervejaController.TotalCerveja());
                        LimparTela();
                        break;
                    case 3:
                        Console.WriteLine("Total de litros:" + cervejaController.TotalLitros());
                        LimparTela();
                        break;
                    case 4:
                        AdicionaCerveja();
                        LimparTela();
                        break;
                    case 5:
                        TeorVerifica();
                        LimparTela();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
        public static void LimparTela()
        {
            Console.ReadKey();
            Console.Clear();
            MostraMenu();
        }
            
        public static void ListarCervejas()
        {
            cervejaController.ListagemCervejas().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome da Cerveja: {i.Nome} Litros: {i.Litros} Valor Unitário: {i.Valor} Teor Álcoolico (L): {i.Alcool}"));

        }
        public static void AdicionaCerveja()
        {
            var obj = new Cerveja();
            Console.WriteLine("Informe o Nome da cerveja:");
            obj.Nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade em L");
            obj.Litros = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Valor");
            obj.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o teor álcoolico em L");
            obj.Alcool = double.Parse(Console.ReadLine());

            cervejaController.AdicionarCerveja(obj);
            Console.WriteLine("Cerveja Adicionada com Sucesso!");

        }

        public static void TeorVerifica()
        {
            Console.WriteLine("Informe o seu peso");
            var peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu sexo M masculino F feminino");
            var sexo = char.Parse(Console.ReadLine());
            cervejaController.TeorAlcool(peso,sexo);
        }
            
    }
}
