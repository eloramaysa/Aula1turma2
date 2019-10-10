using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoNomes.Model;

namespace BancoNomes.Controller
{
    public class PessoaController
    {
        PessoaContext pessoaContext = new PessoaContext();

        public IQueryable<Pessoa> GetPessoas()
        {
            return pessoaContext.Pessoas;
        }

        public bool AdicionarPessoa(Pessoa item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;

            pessoaContext.Pessoas.Add(item);

            pessoaContext.SaveChanges();

            return true; 
        }
    }
}
