
namespace Roshambo;
public class RockPlayer : Player
{
    //construct
    public RockPlayer(string name) : base(name) { }
    //methods
    public override RoshamboOptions GenerateRoshamo()
    {
        return RoshamboOptions.Rock;
    }
}
