namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "Category_CategoryId", newName: "CategoryId_CategoryId");
            RenameIndex(table: "dbo.Items", name: "IX_Category_CategoryId", newName: "IX_CategoryId_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Items", name: "IX_CategoryId_CategoryId", newName: "IX_Category_CategoryId");
            RenameColumn(table: "dbo.Items", name: "CategoryId_CategoryId", newName: "Category_CategoryId");
        }
    }
}
