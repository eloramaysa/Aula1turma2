using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNetCore.Model
{
     public class WebApiContextcs : DbContext
    {
        public WebApiContextcs(DbContextOptions<WebApiContextcs> options)
            :base(options)
        {

        }

        public DbSet<Bicicleta> bicicletas { get; set; }


    }
}
