﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrosExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  var teste = @"alguma coisa
mais alguma informação aqui ";
            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            //quebra de linha
            var teste3 = teste1 + "\r\n" + teste2;

            Console.WriteLine(teste3);*/

            var testeTemplate = @"Nome do usuário:{0} 
Idade: {1} 
Descrição: {2}";

            var finishText = string.Format(testeTemplate, 
                Console.ReadLine(), 
                Console.ReadLine(), 
                Console.ReadLine());

            Console.WriteLine(finishText);

           // Console.WriteLine(teste);
            Console.ReadKey();

        }
    }
}
