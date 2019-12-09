namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Classedesalvarfotos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImagensNuvems",
                c => new
                    {
                        ImagensNuvemID = c.Int(nullable: false, identity: true),
                        EnderecoImagem = c.String(),
                    })
                .PrimaryKey(t => t.ImagensNuvemID);
            
            AddColumn("dbo.Avaliacaos", "ImagensID_ImagensNuvemID", c => c.Int());
            AddColumn("dbo.Cervejas", "ImagensID_ImagensNuvemID", c => c.Int());
            AddColumn("dbo.Fornecedors", "ImagensID_ImagensNuvemID", c => c.Int());
            AddColumn("dbo.Usuarios", "ImagensID_ImagensNuvemID", c => c.Int());
            CreateIndex("dbo.Avaliacaos", "ImagensID_ImagensNuvemID");
            CreateIndex("dbo.Cervejas", "ImagensID_ImagensNuvemID");
            CreateIndex("dbo.Fornecedors", "ImagensID_ImagensNuvemID");
            CreateIndex("dbo.Usuarios", "ImagensID_ImagensNuvemID");
            AddForeignKey("dbo.Cervejas", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems", "ImagensNuvemID");
            AddForeignKey("dbo.Fornecedors", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems", "ImagensNuvemID");
            AddForeignKey("dbo.Avaliacaos", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems", "ImagensNuvemID");
            AddForeignKey("dbo.Usuarios", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems", "ImagensNuvemID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems");
            DropForeignKey("dbo.Avaliacaos", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems");
            DropForeignKey("dbo.Fornecedors", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems");
            DropForeignKey("dbo.Cervejas", "ImagensID_ImagensNuvemID", "dbo.ImagensNuvems");
            DropIndex("dbo.Usuarios", new[] { "ImagensID_ImagensNuvemID" });
            DropIndex("dbo.Fornecedors", new[] { "ImagensID_ImagensNuvemID" });
            DropIndex("dbo.Cervejas", new[] { "ImagensID_ImagensNuvemID" });
            DropIndex("dbo.Avaliacaos", new[] { "ImagensID_ImagensNuvemID" });
            DropColumn("dbo.Usuarios", "ImagensID_ImagensNuvemID");
            DropColumn("dbo.Fornecedors", "ImagensID_ImagensNuvemID");
            DropColumn("dbo.Cervejas", "ImagensID_ImagensNuvemID");
            DropColumn("dbo.Avaliacaos", "ImagensID_ImagensNuvemID");
            DropTable("dbo.ImagensNuvems");
        }
    }
}
