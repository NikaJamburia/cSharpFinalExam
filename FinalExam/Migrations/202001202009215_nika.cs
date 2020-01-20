namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nika : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Rating = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Owner_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HotelOwners", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.HotelOwners",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        TelNumber = c.String(),
                        Email = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Room_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Room_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        NumberOfBeds = c.Int(nullable: false),
                        PricePerNight = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        hotel_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.hotel_Id)
                .Index(t => t.hotel_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "Owner_Id", "dbo.HotelOwners");
            DropIndex("dbo.Rooms", new[] { "hotel_Id" });
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            DropIndex("dbo.Hotels", new[] { "Owner_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.HotelOwners");
            DropTable("dbo.Hotels");
        }
    }
}
