namespace MVC_Assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movietable",
                c => new
                    {
                        Mid = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        DateOfRelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Mid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movietable");
        }
    }
}
