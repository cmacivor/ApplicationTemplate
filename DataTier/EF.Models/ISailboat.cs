namespace DataTier.EF.Models
{
    public interface ISailboat
    {
        decimal MaxHullSpeed { get; set; }
        string Name { get; set; }
        int SailboatId { get; set; }
        string Type { get; set; }
        decimal WaterLineLengthInFeet { get; set; }
    }
}