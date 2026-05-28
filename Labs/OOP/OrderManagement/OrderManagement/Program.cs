using Pa201LabN4;

Order order1 = new(01, "Cola", 10, 1.80m);
Console.WriteLine(order1.GetOrderPrice(01));

Order order2 = new(02, "Fanta", 1.90m);
Console.WriteLine(order2.GetOrderPrice(02));
Console.WriteLine(order2.PrintProduct());

Console.WriteLine(order1.IncreaseProductCount());
Console.WriteLine(order1.PrintProduct());

order1.IncreaseProductCount(5);
Console.WriteLine(order1.PrintProduct());
decimal diff;
order1.ChangePrice(2.00m, out diff);
Console.WriteLine(diff);
Console.WriteLine(order1.productPrice);

Console.WriteLine(order1.PrintProduct());

OnlineOrder onlineOrder = new(03, "Sprite", 3, 1.50m, 15);

Console.WriteLine(onlineOrder.DeliveryProductPrice());

Console.WriteLine(onlineOrder.PrintOnlineOrder());