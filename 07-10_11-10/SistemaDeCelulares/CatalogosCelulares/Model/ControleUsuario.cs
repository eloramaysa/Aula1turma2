using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogosCelulares.Model
{
   public class ControleUsuario
    {
        //Definimos o valor default 'true' para nossos registros
        public bool Ativo { get; set; } = true;

        public int UsuarioCriacao { get; set; } = 0;

        public int UsuarioAlteracao { get; set; } = 0;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAlteracao { get; set; } = DateTime.Now; //Não precisa usar new porque o Now ele é estático ou seja já está alocado na memória


    }
}
