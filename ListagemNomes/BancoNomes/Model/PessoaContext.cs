using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNomes.Model
{
   public class PessoaContext : DbContext
    {
       public DbSet<Pessoa> Pessoas { get; set; }

    }
}
