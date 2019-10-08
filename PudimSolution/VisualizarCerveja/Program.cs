using CodeFirstTeste.Controller;
using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizarCerveja
{
   public class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AddCerveja(new Cerveja() { Nome = "Cerveja Stella" });
            
            Console.ReadKey();
        }
    }
}
