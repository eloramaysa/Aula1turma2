using CalculoIMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace CalculoIMC.Controllers
{


    [EnableCors(origins: "*", headers: "*", methods: "*")]


    public class IMCController : ApiController
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome= "Teste"}
        };

        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }


        public string Post(Pessoa pessoa)
        {
            double imc = pessoa.Peso / (pessoa.Altura * pessoa.Altura);
            var resposta = "";

            if (imc < 17)
            {
                resposta = "Peso muito abaixo do normal";
            }
            if (imc > 17 && imc < 18.49)
            {
                resposta = "Peso abaixo do normal";
            }
            if (imc > 18.5 && imc < 24.99)
            {
                resposta = "Peso normal";
            }
            if (imc > 25 && imc < 29.99)
            {
                resposta = "Sobrepeso";
            }
            if (imc > 30 && imc < 34.99)
            {
                resposta = "Obesidade I";
            }
            if (imc > 35 && imc < 39.99)
            {
                resposta = "Obesidade II";
            }
            if (imc > 40)
            {
                resposta = "Obesidade III";
            };

            listaDePessoas.Add(pessoa);

            return $"Olá {pessoa.Nome} \r\n Seu IMC é: {imc.ToString("N2")} e ele foi calculado de acordo com sua Altura:{pessoa.Altura} m e Peso:{pessoa.Peso} kg \nVocê está com: {resposta}";

        }



    }
}
