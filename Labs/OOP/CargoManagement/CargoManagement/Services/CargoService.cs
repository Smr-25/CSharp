using Pa201LabN6.Enums;
using Pa201LabN6.Interfaces;
using Pa201LabN6.Models;

namespace Pa201LabN6.Services
{
    internal class CargoService : ICargoService
    {
        public List<Customer> Customers { get; set; } = [];
        public List<Courier> Couriers { get; set; } = [];
        public List<CargoOrder> CargoOrders { get; set; } = [];
        public void AddCourier(Courier courier)
        {
            Couriers.Add(courier);
            Console.WriteLine("Added Courier");
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine("Added Customer");
        }

        public void CompleteOrder(int id)
        {
            if (!CargoOrders.Any(o => o.Id == id))
            {
                throw new Exception("There is no order");
            }

            CargoOrder cargoOrder = CargoOrders.FirstOrDefault(o => o.Id == id);
            cargoOrder.UpdateStatus(OrderStatus.Delivered);
            Courier courier = Couriers.FirstOrDefault(o => o.Id == id);
            courier.IsAvailable = true;

            Console.WriteLine("Order completed");
        }

        public void CreateOrder(CargoOrder cargoOrder)
        {
            if (!(Customers.Any(c => c.Id == cargoOrder.CustomerId) && Couriers.Any(c => c.Id == cargoOrder.CourierId)))
            {
                throw new Exception("Customer or Courier notfound");
            }
            var courier = Couriers.FirstOrDefault(c=>c.Id == cargoOrder.CourierId);

            if (!courier.IsAvailable)
            {
                throw new CourierNotAvailableException("Courier is not available");
            }
            CargoOrders.Add(cargoOrder);
            courier.IsAvailable = false;
            Console.WriteLine("Order created");
        }
    }
}
