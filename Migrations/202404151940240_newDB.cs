namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "Category_CategoryId" });
            RenameColumn(table: "dbo.Items", name: "Category_CategoryId", newName: "CategoryId");
            AlterColumn("dbo.Items", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "CategoryId");
            AddForeignKey("dbo.Items", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "CategoryId" });
            AlterColumn("dbo.Items", "CategoryId", c => c.Int());
            RenameColumn(table: "dbo.Items", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Items", "Category_CategoryId");
            AddForeignKey("dbo.Items", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
