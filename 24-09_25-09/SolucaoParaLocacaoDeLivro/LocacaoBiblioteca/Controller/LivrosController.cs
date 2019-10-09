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
        LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instaciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public bool AdicionarLivro(Livro parametroLivro)
        {
            if (string.IsNullOrWhiteSpace(parametroLivro.Nome)) return false;
            contextDB.Livros.Add(parametroLivro);
            contextDB.SaveChanges();
            return true;
        }


        /// <summary>
        /// Metodo que retorna a lista interna de livros 
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public IQueryable<Livro> GetLivros()
        {
            return contextDB.Livros.Where(x => x.Ativo == true);
        }


        /// <summary>
        /// Metodo para alterar livro
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AlterarLivro(Livro item)
        {
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == item.Id);
            if (livro == null) return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }


        /// <summary>
        /// Metodo para desativar o livro
        /// </summary>
        /// <param name="identificadoId"></param>
        /// <returns></returns>
        public bool RemoverLivroPorID(int identificadoId)
        {
            var livroRemove = contextDB.Livros.FirstOrDefault(x => x.Id == identificadoId);
            if (livroRemove == null) return false;

            livroRemove.Ativo = false;

            contextDB.SaveChanges();
            return true;
        }
    }
}
