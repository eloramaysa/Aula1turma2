using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NomesAPI.Models;
namespace NomesAPI.Controllers
{
    public class ListaNomeController : ApiController
    {
       static List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome= "Elóra", Idade=21},
            new Pessoa(){Nome= "Marcos", Idade=22},
            new Pessoa(){Nome= "Datsa", Idade=15},
            new Pessoa(){Nome= "Yagho", Idade=11},
            new Pessoa(){Nome= "Rosimeri", Idade=47},
            new Pessoa(){Nome= "Leo", Idade=45},
            
        };

        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }

        public List<Pessoa> Post(Pessoa values)
        {
            Pessoa pessoa = values;

            listaDePessoas.Add(pessoa);

            return listaDePessoas.OrderBy(x => x.Idade).ToList<Pessoa>();
        }

    }
}
