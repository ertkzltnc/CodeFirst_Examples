namespace TimestapAndConcurrencyCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Internal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Unitprice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProducts",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Product_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.UserProducts", "User_ID", "dbo.Users");
            DropIndex("dbo.UserProducts", new[] { "Product_ID" });
            DropIndex("dbo.UserProducts", new[] { "User_ID" });
            DropTable("dbo.UserProducts");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Admins");
        }
    }
}
