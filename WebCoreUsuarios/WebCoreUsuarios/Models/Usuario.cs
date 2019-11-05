using System;
using System.Collections.Generic;

namespace WebCoreUsuarios.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string LoginUsu { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int? UsuCriacao { get; set; }
        public int? UsuAlteracao { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
