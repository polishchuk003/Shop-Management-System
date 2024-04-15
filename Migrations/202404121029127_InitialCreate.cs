namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quality = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Customer_CustomerId = c.Int(),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Item_ItemId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Manufacturer = c.String(),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "Item_ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Bills", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Items", new[] { "Category_CategoryId" });
            DropIndex("dbo.Bills", new[] { "Item_ItemId" });
            DropIndex("dbo.Bills", new[] { "Customer_CustomerId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Items");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
        }
    }
}
