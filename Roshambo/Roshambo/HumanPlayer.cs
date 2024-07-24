
namespace Roshambo;
public class HumanPlayer : Player
{
    //construct
    public HumanPlayer(string name) : base(name) { }
    //methods
    public override RoshamboOptions GenerateRoshamo()
    {
        return Value;
    }

    public void SetRoshambo(RoshamboOptions roshambo)
    {
        Value = roshambo;
    }
}
