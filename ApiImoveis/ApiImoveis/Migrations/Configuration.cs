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
                  Nome = "Exemplo",
                  Email = "exemplo@gmail.com",
                  DataNasc = DateTime.Parse("12/04/1984")
              }) ;

              context.SaveChanges();

              context.Imoveis.AddOrUpdate(p => new { p.Logradouro, p.Numero, p.Complemento},   new Models.Imovel()
              {
                  Logradouro = "Rua 2 de setembro",
                  Bairro = "Itoupava",
                  Municipio = "Blumenau",
                  Proprietario = context.Proprietarios.FirstOrDefault(x => x.Nome == "Exemplo").Id,
                  CEP="89107000",
                  Numero=203                                                                      

              }) ;
        }
    }
}
