namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablemedicine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.medicines",
                c => new
                    {
                        medicineID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.String(nullable: false),
                        contact = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.medicineID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.medicines");
        }
    }
}
