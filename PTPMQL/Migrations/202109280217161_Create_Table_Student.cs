namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "StudentID", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Students", "StudentName", c => c.String());
            AddPrimaryKey("dbo.Students", "StudentID");
            DropColumn("dbo.Students", "IDStudent");
            DropColumn("dbo.Students", "NameStudent");
            DropColumn("dbo.Students", "AddressStudent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AddressStudent", c => c.String());
            AddColumn("dbo.Students", "NameStudent", c => c.String());
            AddColumn("dbo.Students", "IDStudent", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            DropColumn("dbo.Students", "StudentName");
            DropColumn("dbo.Students", "StudentID");
            AddPrimaryKey("dbo.Students", "IDStudent");
        }
    }
}
