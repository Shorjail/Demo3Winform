namespace Demo3WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProcessName = c.String(),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProcessRoutes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.ProcessParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParameterName = c.String(),
                        ParameterValue = c.String(),
                        Version = c.Int(nullable: false),
                        ProcessId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Processes", t => t.ProcessId, cascadeDelete: true)
                .Index(t => t.ProcessId);
            
            CreateTable(
                "dbo.ProcessRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RouteName = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcessRoutes", "Id", "dbo.Products");
            DropForeignKey("dbo.Processes", "RouteId", "dbo.ProcessRoutes");
            DropForeignKey("dbo.ProcessParameters", "ProcessId", "dbo.Processes");
            DropIndex("dbo.ProcessRoutes", new[] { "Id" });
            DropIndex("dbo.ProcessParameters", new[] { "ProcessId" });
            DropIndex("dbo.Processes", new[] { "RouteId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProcessRoutes");
            DropTable("dbo.ProcessParameters");
            DropTable("dbo.Processes");
        }
    }
}
