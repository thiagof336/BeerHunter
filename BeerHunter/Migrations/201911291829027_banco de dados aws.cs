﻿namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bancodedadosaws : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Fornecedors", "Nome");
            DropColumn("dbo.Fornecedors", "Login");
            DropColumn("dbo.Fornecedors", "Senha");
            DropColumn("dbo.Usuarios", "Nome");
            DropColumn("dbo.Usuarios", "Nomeusuario");
            DropColumn("dbo.Usuarios", "Email");
            DropColumn("dbo.Usuarios", "Senha");
            DropColumn("dbo.Enderecoes", "Bairro");
            DropColumn("dbo.Enderecoes", "Localidade");
            DropColumn("dbo.Enderecoes", "Uf");
            DropColumn("dbo.Enderecoes", "Logradouro");
            DropColumn("dbo.Enderecoes", "numero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enderecoes", "numero", c => c.Int(nullable: false));
            AddColumn("dbo.Enderecoes", "Logradouro", c => c.String());
            AddColumn("dbo.Enderecoes", "Uf", c => c.String());
            AddColumn("dbo.Enderecoes", "Localidade", c => c.String());
            AddColumn("dbo.Enderecoes", "Bairro", c => c.String());
            AddColumn("dbo.Usuarios", "Senha", c => c.String());
            AddColumn("dbo.Usuarios", "Email", c => c.String());
            AddColumn("dbo.Usuarios", "Nomeusuario", c => c.String());
            AddColumn("dbo.Usuarios", "Nome", c => c.String());
            AddColumn("dbo.Fornecedors", "Senha", c => c.String());
            AddColumn("dbo.Fornecedors", "Login", c => c.String());
            AddColumn("dbo.Fornecedors", "Nome", c => c.String());
        }
    }
}
