using System;


namespace ParkingGarage.Vehicles
{
    abstract class Vehicle
    {
        public string Id { get; }
        abstract public double HourlyRate { get; protected set; }

        public Vehicle(string id)
        {
            Id = id;
        }

        abstract public string GetVehicleType();
        
    }
}
