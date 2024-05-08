Console.WriteLine($"Enter a number");
string uINPUT = Console.ReadLine();
int nINPUT = int.Parse(uINPUT);
for (int i = nINPUT; i >= 0; i--)
{
    Console.WriteLine(i);
}
for (int i = 0; i <= nINPUT; i++) //come back to this
{
    Console.WriteLine(i);
}
Console.WriteLine("begin door lab");
while (true)
{
    Console.WriteLine("Here is a door. Please enter a 5 digit passcode");
    string userNum = Console.ReadLine();
    int nUSER = int.Parse(userNum);
    //bool CORRECT = 
    if (nUSER == 13579)
   {
        Console.WriteLine("That is correct, the door is now open!");
        break;
   }
   Console.WriteLine("That is incorrect. Please try again");
}