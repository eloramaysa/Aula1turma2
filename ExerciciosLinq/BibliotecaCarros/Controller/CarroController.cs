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

       /* public List<Carro> RetornaListaCarro()
        {
            return carroDb.ListaDeCarros.ToList<Carro>();
        }*/
        public  List<Carro> RelatorioMes(int mes)
        {
            return carroDb.ListaDeCarros.FindAll(i => i.DataVenda.Month == mes);
           
        }
    }
}
