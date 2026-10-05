using System;

namespace Pa201LabN6
{
    internal class Program
    {
        static void Main()
        {
            var service = new CargoService();

            var customer1 = new Customer(1, "Alice", "Baku");
            var customer2 = new Customer(2, "Bob", "Ganja");
            service.AddCustomer(customer1);
            service.AddCustomer(customer2);

            var courier1 = new Courier("Javid",true);
            var courier2 = new Courier("Leyla",true);
            service.AddCourier(courier1);
            service.AddCourier(courier2);

            var order1 = new CargoOrder(customer1.Id, courier1.Id, 25.50m);
            service.CreateOrder(order1);

            Console.WriteLine("Couriers:");
            foreach (var c in service.Couriers)
                Console.WriteLine(c);

            //try
            //{
            //    var order2 = new CargoOrder(customer2.Id, courier1.Id, 10m);
            //    service.CreateOrder(order2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //service.CompleteOrder(1);

            var order3 = new CargoOrder(customer2.Id, courier2.Id, 10m);
            service.CreateOrder(order3);

            Console.WriteLine("Couriers:");
            foreach (var c in service.Couriers)
                Console.WriteLine(c);

            service.CompleteOrder(2);
            Console.WriteLine("Current orders:");
            foreach (var o in service.CargoOrders)
                Console.WriteLine(o);
            foreach (var c in service.Couriers)
                Console.WriteLine(c);


            Console.WriteLine("Done");
        }
    }
}
