
namespace Roshambo;
public class HumanPlayer : Player
{
    //construct
    public HumanPlayer(string name) : base(name)
    {
        Name = name;
    }
    //methods
    public override RoshamboValue GenerateRoshamo()
    {
        return Value;
    }
}
