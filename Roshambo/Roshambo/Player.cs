
namespace Roshambo;
public abstract class Player //parent class
{
    //properties
    public string Name { get; set; }
    public RoshamboValue Value { get; set; }
    
    //construct
    public Player(string name)
    {
        Name = name;
    }
    //methods
    public abstract RoshamboValue GenerateRoshamo(); //this will be the name for everything in our child classes as its an abstract class

}
