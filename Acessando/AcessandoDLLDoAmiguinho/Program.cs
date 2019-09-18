using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;  


namespace AcessandoDLLDoAmiguinho
{
    class Program
    {
        

        static void Main(string[] args)
        {

            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine(" 1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Mostrar marcas de cerveja");
            Console.WriteLine("4 - Mostrar marcas de carro");
            Console.WriteLine("5 - Sair do Sistema");
            var menuEscolhido = 0;
            try
            {
                menuEscolhido = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                MenuSistema();
            }


            switch (menuEscolhido)
            {
                case 1:
                    {
                        Console.Clear();
                        CalculandoArea();
                        Retornando();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        var desenho = new AnimacoesEmFrames();
                        desenho.PrintTree();
                        Retornando();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        var cerveja = new ListarCerva();
                        cerveja.ListarCerveja();
                        Retornando();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        var carros = new ListaCarros();
                        carros.ListarMarcas();
                        Retornando(); 
                    }
                    break;
                case 5:
                    {

                        Console.WriteLine("Saindo...");

                        return;
                    }

                default:
                    Console.Clear(); MenuSistema();
                    break;
            }

        }
        public static void Retornando()
        {
            Console.ReadKey();
            Console.Clear();
            MenuSistema();
        }
        public static void CalculandoArea()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var mensagem = "Informe o lado do quadrado:";
            var ladoQuadrado = ValidaArea(mensagem);
            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha área: {bibliotecaCalculos.CalculaArea(ladoQuadrado)}");

        }
        public static int ValidaArea(string mensagem)
        {
            var valor = 0;
            try
            {
                Console.WriteLine(mensagem);
                valor = int.Parse(Console.ReadLine());
            }
            catch
            {
                valor = ValidaArea(mensagem);

            }
            return valor;
        }

    }
}
