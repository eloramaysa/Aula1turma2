using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityRevision.Model;
namespace EntityRevision.Controller
{
    public class CervejaController
    {
        CervejaContextDb contextDb = new CervejaContextDb();

        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDb.Cervejas.Add(item);
                contextDb.SaveChanges();
            }

           
        }
        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDb.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
