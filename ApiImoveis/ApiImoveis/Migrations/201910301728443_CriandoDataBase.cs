namespace ApiImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Complemento = c.String(),
                        Proprietario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNasc = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
            DropTable("dbo.Imovels");
        }
    }
}
