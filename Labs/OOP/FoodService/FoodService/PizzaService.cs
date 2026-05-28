
namespace Pa201LabN4v2
{
    internal class PizzaService : IPizzaService
    {
        double max = 0;
        Pizza bigPizza;
        
        public Pizza AddPizza(string name,int radius,double calory,TimeSpan prepareTime,DateTime created)
        {
            Pizza pizza = new ()
            {
                FoodName = name,
                Radius = radius,
                CaloryValue = calory,
                PrepareTime = prepareTime,
                CreateDate = created
            };
            return pizza;
        }

        public Pizza BigRadiusPizza(List<Pizza> pizzas)
        {
             return pizzas.MaxBy(p => p.Radius); 
        }
    }
}

