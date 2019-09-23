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
        private int ContadorId = 200;
        /// <summary>
        /// Metodo para adicionar livros na classe livros 
        /// </summary>
        public LivrosController()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Nome = "Meu primeiro Livro",
                Id = ContadorId++
                
            });
            Livros.Add(new Livro()
            {
                Nome = "Meu segundo Livro",
                Id = ContadorId++
            });
        }


        /// <summary>
        /// Metodo que cria lista com todos os livros inseridos
        /// </summary>
        private List<Livro> Livros { get; set; }


        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instaciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = ContadorId++;
            Livros.Add(parametroLivro);
        }


        /// <summary>
        /// Metodo que retorna a lista interna de livros 
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return Livros;
        }
    }
}
