namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phoneTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        processor = c.String(),
                        Ram = c.String(),
                        contact = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.phones");
        }
    }
}
