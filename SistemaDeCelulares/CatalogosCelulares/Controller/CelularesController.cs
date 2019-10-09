using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogosCelulares.Model;
namespace CatalogosCelulares.Controller
{
    public class CelularesController
    {
        //Instacia da context
        CelularesContextDB contextDB = new CelularesContextDB();

        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativos</returns>
        //Listagem
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que atualiza um registro valido do nosso sistema 
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        //Atualização 
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);

            if (celular == null)
                return false;

            else
            {
                //Encontrou e atualiza automaticamente no banco de dados 
                item.DataAlteracao = DateTime.Now;
            }

            contextDB.SaveChanges();
            return true;
        }


        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido </returns>
        //Inserção
        public bool InserirCelular(Celular item)
        {
            //metodo que identifica espaços em branco ou valor null 
            if (string.IsNullOrWhiteSpace(item.Marca)) return false;

            if (string.IsNullOrWhiteSpace(item.Modelo)) return false;

            if (item.Preco <= 0) return false;

            contextDB.Celulares.Add(item);

            contextDB.SaveChanges();
            return true;

        }


        /// <summary>
        /// Metodo utilizado para apenas desativas o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso</returns>
        //'Remoção'
        public bool RemoverCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);
            if (celular == null) return false;

            celular.Ativo = false; // desativamos o item 

            contextDB.SaveChanges();

            return true;
        }
    }
}
