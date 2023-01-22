using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbax
{
    internal abstract class Vehicle
    {
        public string License { get; protected set; }
        public decimal Kw { get; protected set; }
        public VehicleType VehicleType { get; protected set; }
        public bool IsRunning { get; protected set; }

        protected Vehicle(string license, decimal kw, VehicleType vehicleType)
        {
            License = license;
            Kw = kw;
            VehicleType = vehicleType;
            //IsRunning = false;
        }

        public abstract string PrintInformation();
        public abstract void Run();

    }
}
