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
        public string Get(string nome, int peso, double altura)
        {
            var imc = peso / (altura * altura);
            var resposta ="";
   
                if ( imc < 17)
            {
                resposta = "Peso muito abaixo do normal";
            }
            if (imc > 17 && imc< 18.49)
            {
                resposta = "Peso abaixo do normal";
            }
            if(imc >18.5 && imc< 24.99)
            {
                resposta = "Peso normal";
            }
            if(imc >25 && imc < 29.99)
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

            return $"Olá {nome} seu imc é {imc} e ele foi calculado de acordo com sua Altura:{altura} m e Peso:{peso} kg e você está com: {resposta}";
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

            return $"Olá {pessoa.Nome} seu imc é {imc} e ele foi calculado de acordo com sua Altura:{pessoa.Altura} m e Peso:{pessoa.Peso} kg e você está com: {resposta}";

        }



    }
}
