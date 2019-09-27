using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCervejas { get; set; }
        public int contador=1;
        public  SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>()
            {
                new Cerveja()
                {
                    Id= contador++,
                    Nome= "Budweiser",
                    Alcool =0.000,
                    Litros = 0.550, 
                    Valor = 6.99
                },
                  new Cerveja()
                {
                    Id= contador++,
                    Nome= "Skol",
                    Alcool = 0.00,
                    Litros = 0.250,
                    Valor = 2.80
                },
                   new Cerveja()
                {
                    Id= contador++,
                    Nome= "Antarctica",
                    Alcool = 0.00,
                    Litros = 1,
                    Valor = 10.90
                },
                 new Cerveja()
                {
                    Id= contador++,
                    Nome= "Patagonia",
                    Alcool = 0.000,
                    Litros = 0.350,
                    Valor = 3.50
                },
                 new Cerveja()
                {
                    Id= contador++,
                    Nome= "Stella",
                    Alcool = 0.0084,
                    Litros = 0.210,
                    Valor =2.19
                }
            };
        }
    }
}
