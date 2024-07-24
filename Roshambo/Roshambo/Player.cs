
namespace Roshambo;
public abstract class Player //parent class
{
    //properties
    public string Name { get; set; }
    public RoshamboOptions Value { get; set; }
    public int Wins { get; set; } = 0;
    public int Losses { get; set; } = 0;
    
    //construct
    public Player(string name)
    {
        Name = name;
    }
    //methods
    public abstract RoshamboOptions GenerateRoshamo(); //this will be the name for everything in our child classes as its an abstract class

}
