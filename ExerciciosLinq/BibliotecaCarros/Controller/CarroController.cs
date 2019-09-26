using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCarros.Model;

namespace BibliotecaCarros.Controller
{
    public class CarroController
    {
        private CarroContext carroDb = new CarroContext();

        /// <summary>
        /// Metodo para listar toda a lista dos carros
        /// </summary>
        /// <returns></returns>
        public List<Carro> RetornaListaCarro()
        {
            return carroDb.ListaDeCarros.OrderBy(x => x.DataVenda).ToList<Carro>();
        }
        /// <summary>
        /// Metodo que retorna lista de carros de acordo com o mes informado por parametro
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public  List<Carro> RelatorioMes(int mes)
        {
            return carroDb.ListaDeCarros.FindAll(i => i.DataVenda.Month == mes).OrderBy(x => x.DataVenda).ToList<Carro>();


        }
        /// <summary>
        /// Metodo que mostra os dados da lista formatado 
        /// </summary>
        /// <param name="carro"></param>
        public void MostraInformacoes(Carro carro)
        {
            //Template que apreseta as informações organizadas
            string template = "Id: {0,-3} Carro: {1,8} Quantidade: {2,2} Valor: {3,7} Data de Venda: {4,10}";

            string textoFormatado = string.Format(template, carro.Id, carro.CarroNome, carro.Quantidade, carro.Valor.ToString("C"), carro.DataVenda.ToShortDateString());

            Console.WriteLine(textoFormatado);

        }
     
    }
}
