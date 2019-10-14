using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRevision.Model
{
    public class Cerveja
    {
        [Key]
        public int Id { get; set; }

        //Quantidade maxima de caracteres para o campo nome
        [StringLength(50)]

        //Campo obrigatória não pode estar vazio vai pro banco como not null
        [Required]
        public string Nome { get; set; }


        [StringLength(30)]
        public string Tipo { get; set; }

        public double Teor { get; set; }



    }
}
