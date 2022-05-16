namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clearerror : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.phones");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        processor = c.String(nullable: false),
                        Ram = c.String(nullable: false),
                        contact = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID);
            
        }
    }
}
