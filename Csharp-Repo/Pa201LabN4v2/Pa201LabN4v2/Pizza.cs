namespace Pa201LabN4v2
{
    public class Pizza : Food
    {
        public double Radius { get; set; }
        public bool IsSpicy { get; set; }
        // double and decimal casting
        public override double CalcPrice()
        {
            double price = 0.1 * (Math.Round(Math.PI, 2) * Math.Pow(Radius,2));

            if (IsSpicy)
                return price+1.15;

            return price;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {FoodName}, Created: {CreateDate}, PrepareTime: {PrepareTime} min, Calories: {CaloryValue}, Radius: {Radius}, IsSpicy: {IsSpicy}, Price: {CalcPrice():F2}";
        }
    }
}

