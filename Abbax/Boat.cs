namespace Abbax;

internal class Boat : Vehicle
{
    public decimal MaxSpeedKnots { get; protected set; }
    public decimal GrossTonnage { get; protected set; }


    public Boat(string license, decimal kw, decimal maxSpeedKnots, decimal grossTonnageKg, VehicleType vehicleType = VehicleType.Boat)
        : base(license, kw, vehicleType)
    {
        MaxSpeedKnots = maxSpeedKnots;
        GrossTonnage = grossTonnageKg;
    }


    public override void Run()
    {
        if (IsRunning) return;
        IsRunning = true;
    }

    public override string PrintInformation()
    {
        return $"Vehicle type:{VehicleType}\n" +
               $"License: {License}\n" +
               $"KW Effect: {Kw}\n" +
               $"Max Speed(knots): {MaxSpeedKnots}\n" +
               $"Gross Tonnage(Kg): {GrossTonnage}\n";

    }
}