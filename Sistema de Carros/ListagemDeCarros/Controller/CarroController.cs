using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;
namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        private SistemaCarrosContext carrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Metodo que lista os dados presente na nossa estrutura de dados
        /// </summary>
        /// <returns> Retorna a nossa lista de carros</returns>
        public List<Carro > ListagemCarros()
        {
            return carrosContext.ListaDeCarros;
        }
    }
}
