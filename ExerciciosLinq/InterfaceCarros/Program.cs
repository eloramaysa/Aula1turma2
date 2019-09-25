using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCarros.Controller;
namespace InterfaceCarros
{
     class Program
    {
        static CarroController carroController = new CarroController();
        static void Main(string[] args)
        {

            Console.WriteLine();

            Console.WriteLine("Informe o mês que deseja emitir o relatório (1 a 12) ");
            var mes = int.Parse(Console.ReadLine());


           var lista= carroController.RelatorioMes(mes);

            Console.WriteLine($"No mês: {mes} a quantidade total de vendas foi de:" + lista.Sum(x => x.Quantidade));
            
            Console.WriteLine("Lucrando um valor total de: " + lista.Sum(x => x.Valor).ToString("C"));

            Console.WriteLine("A média de vendas nesse período foi de: " + lista.Average(x => (x.Quantidade*x.Valor)).ToString("C"));

         
            Console.ReadKey();
        }

        
    }
}
