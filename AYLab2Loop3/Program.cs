
int i = 0;

    while (i <= 4)
    {
        Console.WriteLine("Here is a door. Please enter a 5 digit passcode");
        string userNum = Console.ReadLine();
        int nUSER = int.Parse(userNum);

    if (nUSER == 13579 && i <= 4)
    {
        Console.WriteLine("That is correct, the door is now open!");
        break;
    }

    else if (nUSER != 13579 && i >= 4)
    {
        Console.WriteLine("Too many incorrect attempts. Door is now permanetly shut");
        break;
    }

    else if (nUSER != 13579)
    {
        Console.WriteLine("That is incorrect. Please try again");
        i++;
    }
    }
