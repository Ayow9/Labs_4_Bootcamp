using System.Diagnostics.Metrics;

Console.WriteLine("Here is a door. Please enter a 5 digit passcode");
string userNum = Console.ReadLine();
int nUSER = int.Parse(userNum);

int i = 0;
do
{
    if (nUSER != 13579)
    {
        Console.WriteLine("That is incorrect. Please try again");
        Console.WriteLine("Enter a 5 digit number");
        string userNum2 = Console.ReadLine();
        int nUSER2 = int.Parse(userNum2);
    }
    else  if (nUSER == 13579 && i <= 3)
         {
          Console.WriteLine("That is correct, the door is now open!");
          break;
         }
    i++;
} while (nUSER !=13579 && i <= 3);
Console.WriteLine("Too many incorrect attempts. Door is now permanetly shut");


