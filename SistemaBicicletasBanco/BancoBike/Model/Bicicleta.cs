using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBike.Model
{
    public class Bicicleta : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Modelo { get; set; }

        [MaxLength(50)]
        [Required]
        public string Marca { get; set; }

        [Required]
        public double Preco { get; set; }

        

    }
}
