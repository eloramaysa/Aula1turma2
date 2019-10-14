using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
    public class AlunoController
    {
        EntityDbAlunos contextDB = new EntityDbAlunos();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.ListaDeAlunos;
        }

        public void AddAluno(Aluno item)
        {
            contextDB.ListaDeAlunos.Add(item);

            contextDB.SaveChanges();
          
        }
    }
}
