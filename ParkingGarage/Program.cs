
using ParkingGarage.Orders;
using ParkingGarage.Vehicles;
using ParkingGarage.VehicleTypes;

namespace ParkingGarage
{
    class ParkingManager
    {
        public static void Main()
        {
            RepositoryParking repo = new RepositoryParking();

            PrintMenu();
            Vehicle v = CreateVehicle("123", 1);
            Console.WriteLine(v.GetVehicleType());
            int? idParking = repo.GetAvailableParking();
            
            if (idParking.HasValue)
            {
                repo.CreateOrder(v.Id, (int)idParking, v.Type);
            }
        }

        
        public static void PrintMenu()
        {
            Console.WriteLine("\n===== Wellcome ====\n");
            Console.WriteLine("1. Create new order for parking");
            Console.WriteLine("2. Exit\n");
            Console.WriteLine("Enter your choice\n");

        }
        public static Vehicle CreateVehicle(string id, int indexOfType)
        {
            VehicleType[] types = { 
                VehicleType.Vheicle,
                VehicleType.PrivateVehicle,
                VehicleType.DisabledVehicle,
                VehicleType.Motorcycle };

            return new Vehicle(id, types[indexOfType-=1]);
        }
    }
}