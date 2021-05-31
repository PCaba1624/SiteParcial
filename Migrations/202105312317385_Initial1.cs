namespace SiteParcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Afiliados", "CUIT", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Afiliados", "CUIT", c => c.Int(nullable: false));
        }
    }
}
