using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiImoveis.Models
{
    public class MigrationContext : DbContext
    {
        public virtual DbSet<Proprietario> Proprietarios { get; set; }

        public virtual DbSet<Imovel> Imoveis { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proprietario>()
              .HasMany(e => e.Imovels)
              .WithRequired(e => e.ProprietarioRef) //eager loading
              .HasForeignKey(e => e.Proprietario)
              .WillCascadeOnDelete(false);


        }

    }
}