namespace BeerHunter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inclusao_id_api : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImagensNuvems", "IdApi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImagensNuvems", "IdApi");
        }
    }
}
