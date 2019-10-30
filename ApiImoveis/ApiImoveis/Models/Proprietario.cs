using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiImoveis.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Imovel> Imovels { get; set; }
    }
}