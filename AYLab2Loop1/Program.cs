string counter;
do
{
    Console.WriteLine($"Hello World!");
    Console.WriteLine($"Continue? y/n");
    counter = Console.ReadLine();
}
while (counter == "y");
Console.WriteLine("Goodbye!");