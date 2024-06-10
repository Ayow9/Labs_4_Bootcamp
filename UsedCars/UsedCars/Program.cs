//classes and subclasses, aka a parent class ENCAPSULATING a child class(es)
using UsedCars;

List<Car> newCar = new List<Car> ();
newCar.Add(new Car ("Chevy", "S10", 2022, 45_000));
newCar.Add(new Car("Chevy", "Corvette Stingray", 2023, 98_000));
newCar.Add(new Car("Toyota", "Corolla", 2024, 42_000));
newCar.Add(new UsedCar("Ford", "Fiesta", 1994, 6500, 188_432));
newCar.Add(new UsedCar("Plymoth", "Voyager", 1997, 8800, 147_092));
newCar.Add(new UsedCar("Subaru", "Outback", 2004, 4800, 125_672));

Car.ListCars(newCar);

Console.WriteLine($"Which car would you like to buy?");
Console.WriteLine($"Pick a car by picking a number 1-6");
   
    string userI = Console.ReadLine();
    int pickCar = int.Parse(userI);
    Console.WriteLine(newCar[pickCar - 1]);
    
newCar.RemoveAt(pickCar-1);
Car.ListCars(newCar);
