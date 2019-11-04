using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebCoreImoveis.Model
{
    public class Imovel : UsuarioControle
    {
        [Key]
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Numero { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Complemento { get; set; }

        public int Proprietario { get; set; }

        [JsonIgnore]
        public virtual Proprietario ProprietarioRef { get; set; }
    }
}
