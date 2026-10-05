using System.Collections.Generic;
using Pa201LabN6.Models;

namespace Pa201LabN6.Interfaces
{
    internal interface ICargoService
    {
        List<Customer> Customers { get; set; } 
        List<Courier> Couriers { get; set; }
        List<CargoOrder> CargoOrders { get; set; }

        void AddCustomer(Customer customer);
        void AddCourier(Courier courier);
        void CreateOrder(CargoOrder cargoOrder);
        void CompleteOrder(int id);
    }
}
