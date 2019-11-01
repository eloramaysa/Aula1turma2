using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiImoveis.Models
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string Complemento { get; set; }

        
        public int Proprietario { get; set; }

        public int Numero { get; set; }


        [JsonIgnore]
        public virtual /*lazyloading*/ Proprietario ProprietarioRef { get; set; } 


    }
}