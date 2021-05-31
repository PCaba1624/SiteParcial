namespace SiteParcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        CUIT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Afiliados");
        }
    }
}
