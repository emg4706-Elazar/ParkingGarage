using ParkingGarage.Orders;
using ParkingGarage.VehicleTypes;
using System;


namespace ParkingGarage
{
    class RepositoryParking
    {
        public List<Order> Orders { get; set; }
        public List<PreOrder> PreOrders { get; set; }
        public List<string> ParkingsList { get; set; }

        public RepositoryParking()
        {
            Orders = new List<Order>();
            PreOrders = new List<PreOrder>();
            ParkingsList = new List<string>();
        }

        public void CreateOrder(string Vid, int Pid, VehicleType Vtype)
        {
            Order newOrder = new Order(Vid, Pid, DateTime.Now, Vtype);
            Orders.Add(newOrder);
        }

        public int? GetAvailableParking()
        {
            int lenList = 20;
            int id;
            if (ParkingsList.Count >= lenList)
                return null;

            int availableParking = ParkingsList.Count + 1;
            return availableParking;
        }
    }
    

}
