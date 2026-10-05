using Pa201LabN4v2;
namespace Pa201LabN4v2
{
    internal class FoodService : IFoodService
    {
        public int CountOfCalory(List<Food> foods, int n)
        {
            return foods.FindAll(x => x.CaloryValue > n).Count();
        }

        public DateTime WhenWillPrepared(Food food)
        {
            return food.CreateDate.Add(food.PrepareTime);
        }
    }
}
