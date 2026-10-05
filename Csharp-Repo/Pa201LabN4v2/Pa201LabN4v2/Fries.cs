namespace Pa201LabN4v2
{
    public class Fries : Food
    {

        public bool IsSalty { get; set; }
        public double Weight { get; set; }
        public override double CalcPrice()
        {
            double price = Weight * 1.0;

            if (IsSalty) 
                return price + 0.8;
             
            return price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {FoodName}, Created: {CreateDate}, PrepareTime: {PrepareTime} min, Calories: {CaloryValue}, Weight: {Weight}, IsSalty: {IsSalty}, Price: {CalcPrice():F2}";
        }
    }
}
