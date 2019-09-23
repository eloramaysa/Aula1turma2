using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPessoas
{
    public class Pessoa
    {
        public int Id { get; set;}

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set;}

        public double ValorCarteira { get; set;}
    }
}
