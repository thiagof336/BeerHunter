namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class beerhunter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacaos",
                c => new
                    {
                        AvaliacaoID = c.Int(nullable: false, identity: true),
                        Preco_N = c.Double(nullable: false),
                        Local_N = c.Double(nullable: false),
                        Temperatura_N = c.Double(nullable: false),
                        Comentario = c.String(),
                        CadastraCervejaID_CadatraCervejaID = c.Int(),
                        UsuarioID_UsuarioID = c.Int(),
                    })
                .PrimaryKey(t => t.AvaliacaoID)
                .ForeignKey("dbo.CadastraCervejas", t => t.CadastraCervejaID_CadatraCervejaID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID_UsuarioID)
                .Index(t => t.CadastraCervejaID_CadatraCervejaID)
                .Index(t => t.UsuarioID_UsuarioID);
            
            CreateTable(
                "dbo.CadastraCervejas",
                c => new
                    {
                        CadatraCervejaID = c.Int(nullable: false, identity: true),
                        PrecoCerveja = c.Double(nullable: false),
                        CervejaID_CervejaID = c.Int(),
                        FornecedorID_FornecedorID = c.Int(),
                    })
                .PrimaryKey(t => t.CadatraCervejaID)
                .ForeignKey("dbo.Cervejas", t => t.CervejaID_CervejaID)
                .ForeignKey("dbo.Fornecedors", t => t.FornecedorID_FornecedorID)
                .Index(t => t.CervejaID_CervejaID)
                .Index(t => t.FornecedorID_FornecedorID);
            
            CreateTable(
                "dbo.Cervejas",
                c => new
                    {
                        CervejaID = c.Int(nullable: false, identity: true),
                        NomeCerveja = c.String(),
                        Tipo = c.String(),
                        TeorAlcoolico = c.Double(nullable: false),
                        Lupulo = c.String(),
                        Fabricante = c.String(),
                    })
                .PrimaryKey(t => t.CervejaID);
            
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        FornecedorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FornecedorID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nomeusuario = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        EnderecoID = c.Int(nullable: false, identity: true),
                        Bairro = c.String(),
                        Cep = c.Int(nullable: false),
                        Localidade = c.String(),
                        Uf = c.String(),
                        Logradouro = c.String(),
                        numero = c.Int(nullable: false),
                        FornecedorID_FornecedorID = c.Int(),
                    })
                .PrimaryKey(t => t.EnderecoID)
                .ForeignKey("dbo.Fornecedors", t => t.FornecedorID_FornecedorID)
                .Index(t => t.FornecedorID_FornecedorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "FornecedorID_FornecedorID", "dbo.Fornecedors");
            DropForeignKey("dbo.Avaliacaos", "UsuarioID_UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Avaliacaos", "CadastraCervejaID_CadatraCervejaID", "dbo.CadastraCervejas");
            DropForeignKey("dbo.CadastraCervejas", "FornecedorID_FornecedorID", "dbo.Fornecedors");
            DropForeignKey("dbo.CadastraCervejas", "CervejaID_CervejaID", "dbo.Cervejas");
            DropIndex("dbo.Enderecoes", new[] { "FornecedorID_FornecedorID" });
            DropIndex("dbo.CadastraCervejas", new[] { "FornecedorID_FornecedorID" });
            DropIndex("dbo.CadastraCervejas", new[] { "CervejaID_CervejaID" });
            DropIndex("dbo.Avaliacaos", new[] { "UsuarioID_UsuarioID" });
            DropIndex("dbo.Avaliacaos", new[] { "CadastraCervejaID_CadatraCervejaID" });
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Fornecedors");
            DropTable("dbo.Cervejas");
            DropTable("dbo.CadastraCervejas");
            DropTable("dbo.Avaliacaos");
        }
    }
}
