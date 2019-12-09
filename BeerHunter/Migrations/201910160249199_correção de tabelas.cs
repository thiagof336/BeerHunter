namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correçãodetabelas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avaliacaos", "CadastraCervejaID_CadatraCervejaID", "dbo.CadastraCervejas");
            RenameColumn(table: "dbo.Avaliacaos", name: "CadastraCervejaID_CadatraCervejaID", newName: "CadastraCervejaID_CadastraCervejaID");
            RenameIndex(table: "dbo.Avaliacaos", name: "IX_CadastraCervejaID_CadatraCervejaID", newName: "IX_CadastraCervejaID_CadastraCervejaID");
            DropPrimaryKey("dbo.CadastraCervejas");
            AddColumn("dbo.CadastraCervejas", "CadastraCervejaID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CadastraCervejas", "CadastraCervejaID");
            AddForeignKey("dbo.Avaliacaos", "CadastraCervejaID_CadastraCervejaID", "dbo.CadastraCervejas", "CadastraCervejaID");
            DropColumn("dbo.CadastraCervejas", "CadatraCervejaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CadastraCervejas", "CadatraCervejaID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Avaliacaos", "CadastraCervejaID_CadastraCervejaID", "dbo.CadastraCervejas");
            DropPrimaryKey("dbo.CadastraCervejas");
            DropColumn("dbo.CadastraCervejas", "CadastraCervejaID");
            AddPrimaryKey("dbo.CadastraCervejas", "CadatraCervejaID");
            RenameIndex(table: "dbo.Avaliacaos", name: "IX_CadastraCervejaID_CadastraCervejaID", newName: "IX_CadastraCervejaID_CadatraCervejaID");
            RenameColumn(table: "dbo.Avaliacaos", name: "CadastraCervejaID_CadastraCervejaID", newName: "CadastraCervejaID_CadatraCervejaID");
            AddForeignKey("dbo.Avaliacaos", "CadastraCervejaID_CadatraCervejaID", "dbo.CadastraCervejas", "CadatraCervejaID");
        }
    }
}
