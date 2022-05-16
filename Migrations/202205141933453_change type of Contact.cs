namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetypeofContact : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.phones", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.phones", "processor", c => c.String(nullable: false));
            AlterColumn("dbo.phones", "Ram", c => c.String(nullable: false));
            AlterColumn("dbo.phones", "contact", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.phones", "contact", c => c.Int(nullable: false));
            AlterColumn("dbo.phones", "Ram", c => c.String());
            AlterColumn("dbo.phones", "processor", c => c.String());
            AlterColumn("dbo.phones", "Name", c => c.String());
        }
    }
}
