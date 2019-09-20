using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
   public class LivrosController
        
    {
        /// <summary>
        /// Metodo para adicionar livros na classe livros 
        /// </summary>
        public LivrosController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Nome = "Meu primeiro Livro"
            });
            Livros.Add(new Livro()
            {
                Nome = "Meu segundo Livro"
            });
        }
        /// <summary>
        /// Metodo que cria lista com todos os livros inseridos
        /// </summary>
        public List<Livro> Livros { get; set; }
    }
}
