namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nika2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HotelOwners", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.HotelOwners", "TelNumber", c => c.String(nullable: false));
            AlterColumn("dbo.HotelOwners", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HotelOwners", "Email", c => c.String());
            AlterColumn("dbo.HotelOwners", "TelNumber", c => c.String());
            AlterColumn("dbo.HotelOwners", "Name", c => c.String());
        }
    }
}
