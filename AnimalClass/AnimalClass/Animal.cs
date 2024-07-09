
namespace AnimalClass;

public class Animal
{
    //prop
    public string Species { get; set; }
    public bool IsEndangered { get; set; }

    //construct
    public Animal (string Species, bool IsEndangered) 
    { this.Species = Species; this.IsEndangered = IsEndangered; }
    
    //method
}


