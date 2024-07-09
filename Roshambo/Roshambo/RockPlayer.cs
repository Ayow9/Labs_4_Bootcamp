
namespace Roshambo;
public class RockPlayer : Player
{
    //construct
    public RockPlayer(string name) : base(name)
    {
        Name = name;
    }
    //methods
    public override RoshamboValue GenerateRoshamo()
    {
        return RoshamboValue.Rock;
    }
}
