namespace ApiImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiImoveis.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApiImoveis.Models.MigrationContext context)
        {
            //  This method will be called after migrating to the latest version.

              context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
              {
                  Nome = "Maria",
                  Email = "maria@gmail.com",
                  DataNasc = DateTime.Parse("12/04/1984")
              }) ;

              context.SaveChanges();

              context.Imoveis.AddOrUpdate(p => new { p.Logradouro, p.Numero, p.Complemento},   new Models.Imovel()
              {
                  Logradouro = "Rua casa",
                  Bairro = "Um exemplo",
                  Municipio = "Cidade",
                  Proprietario = 1,
                  CEP="9000879",
                  Numero=1852

              }) ;
        }
    }
}
