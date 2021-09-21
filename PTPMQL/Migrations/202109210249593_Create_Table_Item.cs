namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        NameItem = c.String(nullable: false, maxLength: 128, unicode: false),
                        IDItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NameItem);
            
            DropTable("dbo.Accounts");
            DropTable("dbo.Employees");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        NameStudent = c.String(nullable: false, maxLength: 128),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.NameStudent);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128, unicode: false),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
            DropTable("dbo.Items");
        }
    }
}
