using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoOEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa(new Pessoa()
            { Nome = "Elóra"
            });

            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();

        }
    }
}
