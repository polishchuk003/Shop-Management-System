namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quality = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerModels", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.ItemModels", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.CustomerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Manufacturer = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryModels", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.CategoryModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillModels", "ItemId", "dbo.ItemModels");
            DropForeignKey("dbo.ItemModels", "CategoryId", "dbo.CategoryModels");
            DropForeignKey("dbo.BillModels", "CustomerId", "dbo.CustomerModels");
            DropIndex("dbo.ItemModels", new[] { "CategoryId" });
            DropIndex("dbo.BillModels", new[] { "CustomerId" });
            DropIndex("dbo.BillModels", new[] { "ItemId" });
            DropTable("dbo.CategoryModels");
            DropTable("dbo.ItemModels");
            DropTable("dbo.CustomerModels");
            DropTable("dbo.BillModels");
        }
    }
}
