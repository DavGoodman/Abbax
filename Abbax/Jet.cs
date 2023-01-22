using System.Drawing;

namespace Abbax;

internal class Jet : Vehicle
{
    public decimal WingSpanMeters { get; protected set; }
    public decimal LoadCapacityTons { get; protected set; }
    public decimal NetWeightTons { get; protected set; }

    public Jet(string license, decimal kw, decimal wingSpanMeters, decimal loadCapacityTons, decimal netWeightTons, VehicleType vehicleType = VehicleType.JetPlane)
        : base(license, kw, vehicleType)
    {
        WingSpanMeters = wingSpanMeters;
        LoadCapacityTons = loadCapacityTons;
        NetWeightTons = netWeightTons;
    }

    public override void Run()
    {
        if (IsRunning) return;
        IsRunning = true;
    }

    public override string PrintInformation()
    {
        return $"Vehicle type: {VehicleType}\n" +
               $"License: {License}\n" +
               $"KW Effect: {Kw}\n" +
               $"Wingspan(meters): {WingSpanMeters}\n" +
               $"LoadCapacity(tons): {LoadCapacityTons}\n" +
               $"Net weight(tons): {NetWeightTons}\n";
    }
}