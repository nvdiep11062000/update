namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128, unicode: false),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        NameStudent = c.String(nullable: false, maxLength: 128),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.NameStudent);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Accounts");
        }
    }
}
