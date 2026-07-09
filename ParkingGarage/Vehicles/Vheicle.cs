using System;
using ParkingGarage.VehicleTypes;

namespace ParkingGarage.Vehicles
{
    class Vehicle
    {
        public string Id { get; }
        public VehicleType Type { get; }

        public Vehicle(string id, VehicleType type)
        {
            Id = id;
            Type = type;
        }

        public VehicleType GetVehicleType()
        {
            return Type;
        }
        
    }
}
