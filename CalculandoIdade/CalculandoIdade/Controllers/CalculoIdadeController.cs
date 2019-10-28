using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna o nome da aplicação
        /// </summary>
        /// <returns>Retorna o que o nosso app faz</returns>
        public string Get()
        {
            return "Teste";
        }

        public string Get(int anoNascimento,string usuario = "Default")
        {
            

            if( (DateTime.Now.Year - anoNascimento) >=18)
            {
                return $"Ola {usuario} você é Maior de idade";
            }
            else
            {
                return $"Ola {usuario} você é Menor de idade";
            }

           
        }
    }
}
