
namespace Roshambo;
public class RandomPlayer : Player
{
    //construct
    public RandomPlayer(string name) : base(name)
    {
        Name = name;
    }
    //methods
    public override RoshamboValue GenerateRoshamo()
    {
        Random rps = new Random();
        int rando = rps.Next(1,3);


        if (rando == 1)
        {
            return RoshamboValue.Rock;
        }
        else if (rando == 2)
        {
            return RoshamboValue.Paper;
        }
        else 
        {
            return RoshamboValue.Scissors;
        }

    }
}
