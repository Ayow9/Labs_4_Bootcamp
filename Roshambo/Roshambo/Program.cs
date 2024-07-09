/*

4. Instantiate the proper class based on their choice
5. Ask user to choose rock, paper, scissors
6. GenRoshambo for both opps and player
7. Compare opps to players choice
8. Properly figure out winner, loser, tie
9. Display winner and their choice, ask if they wanna play again 

/************

------
Type or select the following number:
1 = Rock, 2 = Paper, 3 = Scissors

(IF INVALID CHOICE)
"Please make a valid selection"
------
Your choice: xxx
Opps choice: XXX
(You rae a winar! You lose! Tie!)
 *///click here
using Roshambo;

RockPlayer Steve = null;
RandomPlayer Jeff = null;
HumanPlayer hPlay = null;
Player play = null;

Console.WriteLine($"Welcome to Roshambo!\r\nWhats your name?");
string uInp = Console.ReadLine();
Player.ReferenceEquals(play,uInp);

Console.WriteLine($"Hi {play}!\r\nPick an opponet.\r\nSteve (s), Jeff (j)");
string u2Inp = Console.ReadLine();
if (u2Inp == "s")  //do the same for an if (u2Inp == "j")
{
    Console.WriteLine($"Lets play {uInp}!\r\n Your opponet is Steve. Type or select the following number:\r\n1 = Rock, 2 = Paper, 3 = Scissors");

}





