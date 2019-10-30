namespace ApiImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovasAlteracoes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Imovels", "Proprietario");
            AddForeignKey("dbo.Imovels", "Proprietario", "dbo.Proprietarios", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imovels", "Proprietario", "dbo.Proprietarios");
            DropIndex("dbo.Imovels", new[] { "Proprietario" });
        }
    }
}
