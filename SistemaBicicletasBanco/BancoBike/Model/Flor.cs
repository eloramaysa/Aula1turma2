using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBike.Model
{
    public class Flor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public double Valor { get; set; }

    }
}
