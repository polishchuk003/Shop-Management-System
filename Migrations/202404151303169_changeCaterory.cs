namespace Shop_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCaterory : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "CategoryName_CategoryId", newName: "Category_CategoryId");
            RenameIndex(table: "dbo.Items", name: "IX_CategoryName_CategoryId", newName: "IX_Category_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Items", name: "IX_Category_CategoryId", newName: "IX_CategoryName_CategoryId");
            RenameColumn(table: "dbo.Items", name: "Category_CategoryId", newName: "CategoryName_CategoryId");
        }
    }
}
