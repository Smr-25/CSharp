namespace Pa201LabN4v2
{
    internal interface IFoodService
    {
       
        public DateTime WhenWillPrepared(Food food);
        public int CountOfCalory(List<Food> foods ,int n);


    }
}
