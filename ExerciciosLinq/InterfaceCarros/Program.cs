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

            Console.WriteLine("----------------Relação Anual de Venda de Carros----------------------");

            carroController.RetornaListaCarro().ForEach(i => carroController.MostraInformacoes(i));

            Console.WriteLine(" => Informe o mês que deseja emitir o relatório (1 a 12) ");
            var mes = int.Parse(Console.ReadLine());

            Console.Clear();

            while (mes > 0 && mes < 13)
            {
                var lista = carroController.RelatorioMes(mes);
                lista.ForEach(i => carroController.MostraInformacoes(i));
                Console.WriteLine($"---------------------Informações sobre o Mês {mes} -------------------- - ");

                Console.WriteLine($"\r\nNo mês {mes} a quantidade total de vendas foi de: " + lista.Sum(x => x.Quantidade) +" carros");

                Console.WriteLine("\nLucrando um valor total de: " + lista.Sum(x => x.Valor).ToString("C"));

                Console.WriteLine("\nA média de vendas total nesse período foi de: " + lista.Average(x => (x.Quantidade * x.Valor)).ToString("C"));
                Console.WriteLine("\n A média unitária de vendas nesse período foi de: " + lista.Average(x => x.Valor).ToString("C"));

                Console.WriteLine($"\n A maior venda do mês foi de: " + lista.Max(x => x.Quantidade) + " carro(s) do Modelo: " + lista.Max(x => x.CarroNome));

                Console.WriteLine($"\n A menor venda do mês  foi de: " + lista.Min(x => x.Quantidade) + " carro(s) do Modelo: " + lista.Min(x => x.CarroNome));

                Console.WriteLine("\n => Deseja saber o relatório de outro mês? Sim: Informe 1 a 12, Não: 0");
                mes = int.Parse(Console.ReadLine());
                Console.Clear();
            }

        }


    }
}
