
namespace Pa201LabN4v2
{
    public abstract class Food
    {
        public int Id { get; set; }
        public  string FoodName { get; set; }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get 
            { 
                return _createDate;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("CreateDate cannot be in the future.");
                _createDate = value;
            }
        }
        public  TimeSpan PrepareTime { get; set; }

        private double _caloryValue;
        public double CaloryValue 
        { 
            get
            {
                return _caloryValue;
            }
            set
            {
                if(value < 0)
                  throw new ArgumentException("Calory value cannot be negative");
                _caloryValue = value;
            }
        }

        public abstract double  CalcPrice();

    }
}
