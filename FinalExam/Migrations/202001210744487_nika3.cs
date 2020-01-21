namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nika3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hotels", "Owner_Id", "dbo.HotelOwners");
            DropForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Rooms", "hotel_Id", "dbo.Hotels");
            DropIndex("dbo.Hotels", new[] { "Owner_Id" });
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            DropIndex("dbo.Rooms", new[] { "hotel_Id" });
            AlterColumn("dbo.Hotels", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hotels", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Hotels", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Hotels", "Owner_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.Reservations", "Room_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.Reservations", "User_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.Rooms", "hotel_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Hotels", "Owner_Id");
            CreateIndex("dbo.Reservations", "Room_Id");
            CreateIndex("dbo.Reservations", "User_Id");
            CreateIndex("dbo.Rooms", "hotel_Id");
            AddForeignKey("dbo.Hotels", "Owner_Id", "dbo.HotelOwners", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rooms", "hotel_Id", "dbo.Hotels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Reservations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Hotels", "Owner_Id", "dbo.HotelOwners");
            DropIndex("dbo.Rooms", new[] { "hotel_Id" });
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            DropIndex("dbo.Hotels", new[] { "Owner_Id" });
            AlterColumn("dbo.Rooms", "hotel_Id", c => c.Long());
            AlterColumn("dbo.Reservations", "User_Id", c => c.Long());
            AlterColumn("dbo.Reservations", "Room_Id", c => c.Long());
            AlterColumn("dbo.Hotels", "Owner_Id", c => c.Long());
            AlterColumn("dbo.Hotels", "City", c => c.String());
            AlterColumn("dbo.Hotels", "Address", c => c.String());
            AlterColumn("dbo.Hotels", "Name", c => c.String());
            CreateIndex("dbo.Rooms", "hotel_Id");
            CreateIndex("dbo.Reservations", "User_Id");
            CreateIndex("dbo.Reservations", "Room_Id");
            CreateIndex("dbo.Hotels", "Owner_Id");
            AddForeignKey("dbo.Rooms", "hotel_Id", "dbo.Hotels", "Id");
            AddForeignKey("dbo.Reservations", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms", "Id");
            AddForeignKey("dbo.Hotels", "Owner_Id", "dbo.HotelOwners", "Id");
        }
    }
}
