using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto= "Xiaomi Lite 6",
                    Quantidade = 8,
                    Valor= 1200.75

                },
                 new Venda()
                {
                    Produto= "Slim",
                    Quantidade = 5,
                    Valor= 2800.96
                    

                },
                new Venda()
                {
                    Produto = "Iphone",
                    Quantidade = 1,
                    Valor=9999.99
                }
            };
            Console.WriteLine("Media de produtos vendidos nesse mês");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Média total de vendas neste mês em R$");
            Console.WriteLine(vendas.Average(x => (x.Quantidade*x.Valor)));
            Console.ReadKey();
         }   
    }
}
