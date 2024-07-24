
namespace Roshambo;
public class RandomPlayer : Player
{
    private static readonly Random RandoPlayer = new Random();
    //construct
    public RandomPlayer(string name) : base(name) { }
    //methods
    public override RoshamboOptions GenerateRoshamo()
    {
        Value = (RoshamboOptions)RandoPlayer.Next(3);
        return Value;
    }
}
