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

        [CustomValidator("Nome")]
        public string Nome { get; set; }

        [CustomValidator("DataNasc")]
        public DateTime DataNasc { get; set; }

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<Imovel> Imovels { get; set; }
    }
}