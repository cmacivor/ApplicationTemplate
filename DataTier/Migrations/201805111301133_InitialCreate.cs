namespace DataTier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SailboatTrips",
                c => new
                    {
                        SailboatTripId = c.Int(nullable: false, identity: true),
                        Destination = c.String(),
                        TripDate = c.DateTime(nullable: false),
                        NumberPassengers = c.Int(nullable: false),
                        SailboatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SailboatTripId)
                .ForeignKey("dbo.Sailboats", t => t.SailboatId, cascadeDelete: true)
                .Index(t => t.SailboatId);
            
            CreateTable(
                "dbo.Sailboats",
                c => new
                    {
                        SailboatId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        WaterLineLengthInFeet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxHullSpeed = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SailboatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SailboatTrips", "SailboatId", "dbo.Sailboats");
            DropIndex("dbo.SailboatTrips", new[] { "SailboatId" });
            DropTable("dbo.Sailboats");
            DropTable("dbo.SailboatTrips");
        }
    }
}
