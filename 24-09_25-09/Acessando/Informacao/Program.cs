using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;
namespace Informacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }
        /// <summary>
        /// Metodo que exibe o Menu do sistema e verifica e encaminha para o próximo método de acordo com resposta
        /// </summary>
        private static void MenuSistema()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetBufferSize(2, 2);
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine(" 1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Mostrar marcas de cerveja");
            Console.WriteLine("4 - Mostrar marcas de carro");
            Console.WriteLine("5 - Sair do Sistema");
            var menuEscolhido = 0;
            try {
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
                        CalculaArea();
                        Retornando();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        Arvore.ArvoreDesenho();
                        Retornando();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        ListaCerveja.Cervejas();
                        Retornando();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        ListaCarros.Carros();
                        Retornando();
                    }
                    break;
                case 5:
                    {
                       
                        Console.WriteLine("Saindo...");
                       
                        return;
                    }

                default: Console.Clear(); MenuSistema();
                    break;
            }

        }
        /// <summary>
        /// Metodo que limpa a tela e mostra o menu novamente após terminar uma ação 
        /// </summary>
        public static void Retornando()
        {
            Console.ReadKey();
            Console.Clear();
            MenuSistema();
        }
        /// <summary>
        /// Metodo que recebe o valor da área e consulta a biblioteca para calcular a area
        /// </summary>
        public static void CalculaArea()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var mensagem ="Informe o lado do quadrado:";
            var ladoQuadrado = ValidaArea(mensagem);
            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área: {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
          
        }
        /// <summary>
        /// Metodo para validar o valor recebido da area
        /// </summary>
        /// <param name="mensagem"></param>
        /// <returns></returns>
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
