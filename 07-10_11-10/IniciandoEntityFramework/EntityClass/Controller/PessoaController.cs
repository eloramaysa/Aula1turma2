using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
   public class PessoaController
    {
        //Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        //IQueryable nossa primeira interface com a Classe, essa classe contem várias funcionalidades prontas para usar igual
        //ao banco de dados como select
        public IQueryable<Pessoa> GetPessoas()//Nome dado ao nosso metodo 
        {
            return contextDB.ListaDePessoas; //retornamos nossa lista de pessoas
        }
        /// <summary>
        /// Metodo para adicionar Pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
       public void AddPessoa(Pessoa item)
        {
            contextDB.ListaDePessoas.Add(item);
            //Realiza o insert já dentro do banco de dados
            contextDB.SaveChanges();
        }
    }
}
