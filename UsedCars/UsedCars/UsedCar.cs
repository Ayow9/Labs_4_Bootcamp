
namespace UsedCars;

public class UsedCar : Car
{
    //prop
    public double Mileage { get ; set; }
    //construct
    public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) 
        : base(Make, Model, Year, Price)
    {
        this.Mileage = Mileage;
    }
    //method
    public static void ListCars(List<Car> newCars)
    {
        foreach (Car car in newCars)
        {
            Console.WriteLine(car.ToString());
        }
    }
   
    public override string ToString() 
    {
        return "Car is a " + Make + " " + Model + ", " + Year + " The price is " + Price + " and the milage is " +  Mileage;
    }
}
