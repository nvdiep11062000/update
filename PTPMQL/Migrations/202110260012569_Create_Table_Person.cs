namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            DropTable("dbo.Consumers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        ConsumerID = c.String(nullable: false, maxLength: 128),
                        ConsumerName = c.String(),
                        ConsumerAddress = c.String(),
                    })
                .PrimaryKey(t => t.ConsumerID);
            
            DropTable("dbo.Persons");
        }
    }
}
