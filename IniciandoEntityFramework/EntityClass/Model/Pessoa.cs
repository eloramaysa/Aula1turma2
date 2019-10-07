using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
   public class Pessoa
    {
        //criar uma notação (Annotations)
        
        [Key] //Aqui temos uma notação que indica que nossa chave primára é campo abaixo no caso o Id
        public int Id { get; set;}
        public string Nome { get; set; }

    }
}
