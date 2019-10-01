using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
namespace ApresentandoAsCervejas
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionarCervejas(new Cerveja()
            {
                Id = cervejaController.RetornaListaDeCerveja().Count + 1,
                Nome = "Skol",
                Alcool= 0.025,
                Litros = 2, 
                Valor = 8.99
            }
            );


    

            cervejaController.RetornaListaDeCerveja().ForEach(i => Console.WriteLine($"{i.Id} {i.Nome} {i.Litros} {i.Valor} {i.Alcool}"));


            Console.WriteLine("Total de cervejas " + cervejaController.getTotal());

            Console.WriteLine("Total litro " + cervejaController.getTotalLItro());


            Console.ReadKey();
        }
    }
}
