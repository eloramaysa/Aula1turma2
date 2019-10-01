using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass.Model
{
    //Bicicleta seria o objeto 
    //O objeto é constituido por partes 
    class Bicicleta
    {
        //get vai mostrar uma informação, set permite modificar o valor, ou dar a informação; 
        public string Marca { get; set; }
        public int Pneus { get; } = 2;
    }
}
