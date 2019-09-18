using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
    {
        public class Program
        {


            /* 1) metodo que mostra uma arvore
    2) metodo de calculo de area de um quadrado
    3) metodo para listar as cervejas 
    4) metodo para listar 5 marca de carros no minimo*/
            static void Main(string[] args)
            {


                Arvore();
                Console.ReadKey();
                Console.Clear();
                Area();
                Console.ReadKey();
                Console.Clear();
                Cervejas();
                Console.ReadKey();
                Console.Clear();
                Carros();
                Console.ReadKey();
                Console.Clear();


            }
            /// <summary>
            /// Metodo para exibir uma arvore
            /// </summary>
            public static void Arvore()
            {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@"                         *  @*%.                        
                      *%############&                      
                      %##############                    
         ,%@   ,%@@. ,%%#@@#&%#@@###@                    
      %######@#########@* %%,@&@%######@.                  
     @##########@#####@* %@@  %@#&@######@######&          
       @######%@#######&@@#######%@#########@#######@#        
         %@##@&%####%##%@ *@@%@%################@        
       .###@@%@@#@#%##@@####################@##@       
    .################@##%####################@@##@%      
    ###################@#########################@     
   #############&@###@@#@########@#######%@#######       
  @##############@@& #@%###@####@#####@####%@@#######      
  ######@#@%######%  @@#%#####&%@####################    
  #@@#######@#####@##&&@##############@####@############%  
    ##############%################@###@@#############@  
     #@###########@@###################################@   
     %%################@@@####@###################,*%%     
       @@#@ @########&#####@@@@@@%#############@#####        
             @%####% ##### @%%%%%@@,%############.        
                &@##########%%%%%@    ####& &%###@        
                           @%%%%%    *####@#    %          
                           @%&%%@     ##@#                 
                           @%@%%@                          
                           @%%%%@                          
                          @@@%%%@                          
                         #@%@@%%%,                   ");


            }
            /// <summary>
            /// Metodo para calcular a area de um quadrado 
            /// </summary>
            public static void Area()
            {
                Console.ForegroundColor = ConsoleColor.White;
                var mensagem = "Informe o valor do lado do quadrado para ser calculado a area: ";

                var valor = ValidaDouble(mensagem);
                var area = valor * valor;
                Console.WriteLine($"O valor do área é: {area}");
            }
            /// <summary>
            /// Metodo para validar um valor double
            /// </summary>
            /// <param name="mensagem"></param>
            /// <returns>Valor</returns>
            public static double ValidaDouble(string mensagem)
            {
                var valor = 0.0;
                try
                {
                    Console.WriteLine(mensagem);
                    valor = double.Parse(Console.ReadLine());
                }
                catch
                {
                    valor = ValidaDouble(mensagem);
                }
                return valor;
            }
            /// <summary>
            /// Metodo para listar cervejas
            /// </summary>
            public static void Cervejas()
            {
                var cerveja = new List<string>
            {
                "Skol","Budweiser","Brahma","Antarctica","Bohemia"
            };

                cerveja.ForEach(item => Console.WriteLine(item));

            }
            /// <summary>
            /// Metodo para listar marcas de carros
            /// </summary>
            public static void Carros()
            {
                var carros = new List<string>
            {
                "Volkswagen","Honda","Toyota","FIAT","Ford","Hyundai","Audi","Chevrolet","Renault"
            };

                carros.ForEach(item => Console.WriteLine(item));
            }

        }
    }


