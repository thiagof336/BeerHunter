namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacaoClasseFornecedor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedors", "Login", c => c.String());
            AddColumn("dbo.Fornecedors", "Senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedors", "Senha");
            DropColumn("dbo.Fornecedors", "Login");
        }
    }
}
