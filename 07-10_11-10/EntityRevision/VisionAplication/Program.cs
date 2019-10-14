using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityRevision.Model;
using EntityRevision.Controller;
namespace VisionAplication
{
    class Program
    {
        //1- Setar a aplicacao visual para startar o projeto
        //2 vamos adicionar o EntityFrameWork no console
        //3 Colocar em nosso using o system.data.entity 
        //4 Adicionar a referencia da nossa classLibrary 


        //static CervejaContextDb cerveja = new CervejaContextDb(); 
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {

            cervejaController.AddCerveja(new Cerveja() { Nome = "Cerveja Skol" });

            cervejaController.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
