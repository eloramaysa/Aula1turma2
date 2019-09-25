using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
          
    {
        //Classe onde está presente todos os dados do programa 
        public int IdContadorLivros { get; set; } = 200;

        public int IdContadorUsuarios { get; set; } = 100;

        /// <summary>
        /// Metodo construtor que prepara nossa classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>
            {
                new Livro()
                {
                    Nome = "Meu primeiro Livro",
                    Id = IdContadorLivros++

                },
                new Livro()
                {
                    Nome = "Meu segundo Livro",
                    Id = IdContadorLivros++
                },
                new Livro()
                {
                    Nome = "Meu terceiro Livro",
                    Id = IdContadorLivros++
                }
            };

            ListaDeUsuarios = new List<Usuario>
            {
                new Usuario()
                {
                    Login = "admin",
                    Senha = "admin",
                    Id = IdContadorUsuarios++

                },
                new Usuario()
                {
                    Login = "user",
                    Senha = "user",
                    Id = IdContadorUsuarios++
                },
                new Usuario()
                {
                    Login = "admin",
                    Senha = "123",
                    Id = IdContadorUsuarios++
                }
            };

        }
        public List<Livro> ListaDeLivros { get; set; }

        public List<Usuario> ListaDeUsuarios { get; set; }

    }
}
