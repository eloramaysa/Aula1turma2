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
        private LocacaoContext contextDB = new LocacaoContext();
      
        public LivrosController()
        {
            
        }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instaciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = contextDB.IdContadorLivros++;
            contextDB.ListaDeLivros.Add(parametroLivro);
        }


        /// <summary>
        /// Metodo que retorna a lista interna de livros 
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        public void RemoverLivroPorID(int identificadoId)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro 
            var livroSelecionado = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoId);
            if (livroSelecionado != null)
                livroSelecionado.Ativo = false;
        }
    }
}
