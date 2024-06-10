
namespace UsedCars;

public class Car
{
    //prop
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    //construct
    public Car()
    {
        Make = string.Empty; //if make is empty, display empty string
        Model = string.Empty;
        Year = 0;
        Price = 0;
    } //no-argument constructor syntax example
    public Car(string Make, string Model, int Year, decimal Price)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
    }
    //method
    public static void ListCars(List<Car> newCars)
    {
        foreach (Car car in newCars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    public static void Remove(int index)
    {
        Console.WriteLine(index.ToString()); 
    }
    public override string ToString() 
    {
        return "Car is a " + Make + " " + Model + ", " + Year + " The price is " + Price;
    }
}
    