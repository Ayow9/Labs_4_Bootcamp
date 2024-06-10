using CircleGrowsAY;

Console.WriteLine($"Welcome to the Circle Tester. Enter a radius number");
double rad = Convert.ToDouble(Console.ReadLine());

Circle radius = new Circle(rad);

//CalculateDiameter
Console.WriteLine($"Diameter is " + radius.CalculateDiameter()); 

//CalculateCircumfrence
Console.WriteLine($"Circumference is " + radius.CalculateCircumfrence()); 

//CalculateArea 
Console.WriteLine($"Area is " + radius.CalculateArea());

Console.WriteLine($"Should the circle grow? y/n");
string uLogic = Console.ReadLine();

if (uLogic == "y") ;
{
    radius.Grow();
    Console.WriteLine($"Your new circle Radius is " + radius.GetRadius());
    Console.WriteLine($"New Circumference is " + radius.CalculateCircumfrence());
    Console.WriteLine($"New Area is " + radius.CalculateArea());
}

