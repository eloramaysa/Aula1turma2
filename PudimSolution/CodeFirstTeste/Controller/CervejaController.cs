using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDb cervejaContext = new CervejaContextDb(@"data source=(localDb)\MSSQLLocalDb;initial catalog=EntityRevision.Model.CervejaContextDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cerveja item)
        {
            cervejaContext.Cervejas.Add(item);
            cervejaContext.SaveChanges();
        }
    }
}
