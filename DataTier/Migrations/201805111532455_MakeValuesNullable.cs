namespace DataTier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeValuesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sailboats", "WaterLineLengthInFeet", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Sailboats", "MaxHullSpeed", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sailboats", "MaxHullSpeed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Sailboats", "WaterLineLengthInFeet", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
