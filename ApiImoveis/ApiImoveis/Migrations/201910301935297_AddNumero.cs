namespace ApiImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "Numero", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Imovels", "Numero");
        }
    }
}
