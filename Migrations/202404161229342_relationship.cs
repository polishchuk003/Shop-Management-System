namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bills", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.Bills", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Bills", new[] { "Item_ItemId" });
            RenameColumn(table: "dbo.Bills", name: "Customer_CustomerId", newName: "CustomerId");
            RenameColumn(table: "dbo.Bills", name: "Item_ItemId", newName: "ItemId");
            AlterColumn("dbo.Bills", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Bills", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bills", "ItemId");
            CreateIndex("dbo.Bills", "CustomerId");
            AddForeignKey("dbo.Bills", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "ItemId", "dbo.Items", "ItemId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Bills", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Bills", new[] { "CustomerId" });
            DropIndex("dbo.Bills", new[] { "ItemId" });
            AlterColumn("dbo.Bills", "ItemId", c => c.Int());
            AlterColumn("dbo.Bills", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Bills", name: "ItemId", newName: "Item_ItemId");
            RenameColumn(table: "dbo.Bills", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Bills", "Item_ItemId");
            CreateIndex("dbo.Bills", "Customer_CustomerId");
            AddForeignKey("dbo.Bills", "Item_ItemId", "dbo.Items", "ItemId");
            AddForeignKey("dbo.Bills", "Customer_CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
