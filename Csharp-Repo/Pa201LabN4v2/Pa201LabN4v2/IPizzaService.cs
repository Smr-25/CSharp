namespace Pa201LabN4v2
{
    internal interface IPizzaService
    {
        public Pizza AddPizza(string name, int radius, double calory, TimeSpan prepareTime, DateTime created);
        public Pizza BigRadiusPizza(List<Pizza> pizzas);
    }
}
