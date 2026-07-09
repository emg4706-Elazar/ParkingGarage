using System;
using ParkingGarage.VehicleTypes;

namespace ParkingGarage.Orders
{
    class Order
    {
        public string VehicleId { get; }
        public int ParkingId { get; private set; }
        public VehicleType Type { get; private set; }
        public DateTime EntryTime { get; private set; }
        public DateTime ExitTime { get; private set; }
        public bool Paid { get; private set; }

        public Order(string vehicleId, int parkingId, DateTime entryTime, VehicleType vheicleType)
        {
            VehicleId = vehicleId;
            ParkingId = parkingId;
            Type = vheicleType;
            EntryTime = entryTime;
            Paid = false;
        }
    }
}
