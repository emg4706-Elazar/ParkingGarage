

using ParkingGarage.Orders;
using ParkingGarage.Vehicles;
using ParkingGarage.VehicleTypes;

namespace ParkingGarage
{
    class ParkingManager
    {
        public List<Order> orders = new List<Order>();

        public void Main()
        {
            
        }

        public static void CreateOrder(string vehicleId, string parkingId, Type vheicleType)
        {
            Order order = new Order("1234", "1", DateTime.Now, VehicleType.PrivateVehicle);
        }
    }
}