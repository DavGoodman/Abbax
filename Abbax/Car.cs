using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbax
{
    internal class Car : Vehicle
    {
        public decimal MaxSpeedKm { get; protected set; }
        public string Color { get; protected set; }

        public Car(string license, int kw, decimal maxSpeedKm, string color, VehicleType vehicleType = VehicleType.LightWeightCar) 
            : base(license, kw, vehicleType)
        {
            MaxSpeedKm = maxSpeedKm;
            Color = color;
        }

        public bool Compare(Car other)
        {
            return (License == other.License &&
                    Kw == other.Kw &&
                    MaxSpeedKm == other.MaxSpeedKm &&
                    Color == other.Color &&
                    VehicleType == other.VehicleType);
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
                   $"Maximum Speed km/h: {MaxSpeedKm}\n" +
                   $"Color: {Color}\n";
        }
    }
}
