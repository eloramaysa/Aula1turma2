using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        /* 1) metodo que mostra uma arvore
         2) metodo de calculo de area de um quadrado
         3) metodo para listar as cervejas 
         4) metodo para listar 5 marca de carros no minimo*/
        static void Main(string[] args)
        {
            //Arvore();
            Area();
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para exibir uma arvore
        /// </summary>
        public static void Arvore()
        {


   Console.WriteLine(@"                         *  @*%.                        
                      *%############&                      
                      %##############                    
         ,%@   ,%@@. ,%%#@@#&%#@@###@                    
      %######@#########@* %%,@&@%######@.                  
     @##########@#####@* %@@  %@#&@######@######&          
       @######%@#######&@@    %@#########@#######@#        
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
       @@#@ @########&   @@@@@@%#############@#####        
             @%####%      @%%%%%@@,%############.        
                &@        #%%%%%@    ####& &%###@        
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
            var valor = 0.0;
            Console.WriteLine("Informe o valor do lado do quadrado para ser calculado a area:");
            valor = double.Parse(Console.ReadLine());

            var area = valor * valor;
            Console.WriteLine($"O valor do área é: {area}");
        }

        public static void Cervejas()
        {
            var cerveja = new List<string>();
            
        }
    }
}
