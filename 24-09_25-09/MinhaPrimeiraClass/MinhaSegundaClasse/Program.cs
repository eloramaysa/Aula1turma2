﻿using MinhaSegundaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeFrutas = new List<Frutas>();

            listaDeFrutas.Add(new Frutas()
            {
                Nome ="Banana",Quantidade =5
            });
            listaDeFrutas.Add(new Frutas()
            {
                Nome = "Tomate",
                Quantidade = 2
            });

            listaDeFrutas.ForEach(i => Console.WriteLine($"Nome {i.Nome} Quantidade {i.Quantidade}"));
            Console.ReadKey();

        }
    }
}
