namespace ConsoleApp12
{
    internal class Celcius
    {
        public float Degree { get; set; }


        // Kelvin → float
        public static implicit operator Kelvin(Celcius celcius)
        {
           
            return new Kelvin { Degree = celcius.Degree - 273 };
        }
    }
}

