using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebCoreImoveis.Model
{
    public class ImoveisContext : DbContext
    {
        public ImoveisContext(DbContextOptions<ImoveisContext> options)
          : base(options)
        {

        }

        public DbSet<Imovel> Imovels { get; set; }

        public DbSet<Proprietario> Proprietarios { get; set; }


       
    }
}
