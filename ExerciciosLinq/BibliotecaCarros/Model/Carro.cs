using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarros.Model
{
   public class Carro
    {
        public int Id { get; set; }

        public string CarroNome { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataVenda { get; set; }
    }
}
