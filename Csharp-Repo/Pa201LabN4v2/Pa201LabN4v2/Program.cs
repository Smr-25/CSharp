using Pa201LabN4v2;

var pizza1 = new Pizza
{
    Id = 1,
    FoodName = "Pepperoni",
    CreateDate = DateTime.Now,
    PrepareTime = TimeSpan.FromMinutes(18),
    CaloryValue = 800,
    Radius = 12.5,
    IsSpicy = true
};

//Console.WriteLine(pizza.CalcPrice());


//var fries = new Fries
//{
//    Id = 2,
//    FoodName = "French Fries",
//    CreateDate = DateTime.Now,
//    PrepareTime = 10,
//    CaloryValue = 350,
//    Weight = 150,
//    IsSalty = true
//};

//Console.WriteLine(fries.CalcPrice());

FoodService foodService = new FoodService();

PizzaService pizzaService = new PizzaService();

List<Pizza> foods = new List<Pizza>();
foods.Add( new Pizza { FoodName = "Margherita", Radius = 12, CaloryValue = 250, IsSpicy = false, PrepareTime = TimeSpan.FromMinutes(15), CreateDate = DateTime.Now });
foods.Add(new Pizza { FoodName = "Pepperoni", Radius = 14, CaloryValue = 320, IsSpicy = true, PrepareTime = TimeSpan.FromMinutes(18), CreateDate = DateTime.Now } );
foods.Add(new Pizza { FoodName = "BBQ Chicken", Radius = 16, CaloryValue = 400, IsSpicy = true, PrepareTime = TimeSpan.FromMinutes(20), CreateDate = DateTime.Now });
foods.Add(new Pizza { FoodName = "Veggie", Radius = 10, CaloryValue = 220, IsSpicy = false, PrepareTime = TimeSpan.FromMinutes(12), CreateDate = DateTime.Now });
//foods.Add( new Pizza { FoodName = "Hawaiian", Radius = 13, CaloryValue = 280, IsSpicy = false, PrepareTime = TimeSpan.FromMinutes(17), CreateDate = DateTime.Now });
//Console.WriteLine(foodService.CountOfCalory(foods, 300));

var pizza = pizzaService.AddPizza("Hawaiian", 13, 330, TimeSpan.FromMinutes(17), DateTime.Now);
foods.Add(pizza);
//Console.WriteLine(foodService.CountOfCalory(foods, 300));


Console.WriteLine(foodService.WhenWillPrepared(foods.FirstOrDefault()).ToString(format: "yyyy.MM.dd HH:mm:ss "));

Console.WriteLine(pizzaService.BigRadiusPizza(foods));