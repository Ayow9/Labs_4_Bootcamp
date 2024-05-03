Console.WriteLine("Type a number between 0 and 100");
string INPUT = Console.ReadLine();
int inputNUM = int.Parse(INPUT);
if (inputNUM < 60 && inputNUM % 2 != 0)
{
    Console.WriteLine("Odd and less than 60");
}
if (inputNUM < 25 && inputNUM % 2 == 0)
{
    Console.WriteLine("Even and less than 25");
}
if (inputNUM <= 60 && inputNUM % 2 == 0)
{
    Console.WriteLine("Even and between 26-60, inclusive");
}
if (inputNUM > 60 && inputNUM % 2 == 0)
{
    Console.WriteLine("Even and greater than 60");
}
if (inputNUM > 60 && inputNUM % 2 != 0)
{
    Console.WriteLine("Odd and greater than 60");
}