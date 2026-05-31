
using ConsoleApp12;

double Exchange(Enum currecy,double azn)
{
    if(currecy is Currecy)
    {
        switch (currecy)
        {
            case Currecy.Usd:
                return azn * 0.59;

            case Currecy.Eur:
                return azn * 0.51;

            case Currecy.Try:
                return azn * 24.6;
            default:
                return 0;
        }
        
    }
    throw new FormatException("This is not Currecy enum");
}

//Console.WriteLine(Exchange(Enum1.one, 2));
Celcius kelvin = new()
{
    Degree = 273
};
Kelvin kelvin1 = kelvin;

Console.WriteLine(kelvin1.Degree);

