using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogosCelulares.Model
{
    public class Celular : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String Modelo { get; set; }

        [MaxLength(30)]
        [Required]
        public String Marca { get; set; }

        [Required]
        public double Preco { get; set; }


    }
}
