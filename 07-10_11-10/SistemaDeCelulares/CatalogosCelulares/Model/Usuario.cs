using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogosCelulares.Model
{
   public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public String Nome { get; set; }

        [MaxLength(30)]
        [Required]
        public String Login { get; set; }

        [MaxLength(30)]
        [Required]
        public String Senha { get; set; }


    }
}
