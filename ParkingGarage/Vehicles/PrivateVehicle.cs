using System;
using ParkingGarage.Vehicles;

namespace ParkingGarage.Vehicles
{
    class PrivateVehicle: Vehicle
    {
        override public double HourlyRate { get; protected set; }
        public PrivateVehicle(string id)
            :base(id)
        {
            HourlyRate = 15;
        }

        public override string GetVehicleType()
        {
            return "PrivateVehicle";
        }
    }
}
