<<<<<<< HEAD
﻿

namespace CircleGrowsAY;

public class Circle
{
    //properties
    private double radius {  get; set; } //obviously dont want the users to fudge absolute numbers thus the encapsculation
    
    //constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    //methods
  public double CalculateDiameter()
    { 
        return (radius * 2); 
    }
  
    public double CalculateCircumfrence()
    { 
        return (Math.PI * radius * 2); 
    }
    public double CalculateArea()
    { 
        return (Math.PI * radius * radius); 
    }
    public void Grow() 
    {
        radius *= 2;
    }

    public double GetRadius()
    {
        return radius;
    }
}
=======
﻿

namespace CircleGrowsAY;

public class Circle
{
    //properties
    private double radius {  get; set; } //obviously dont want the users to fudge absolute numbers thus the encapsculation
    
    //constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    //methods
  public double CalculateDiameter()
    { 
        return (radius * 2); 
    }
  
    public double CalculateCircumfrence()
    { 
        return (Math.PI * radius * 2); 
    }
    public double CalculateArea()
    { 
        return (Math.PI * radius * radius); 
    }
    public void Grow() 
    {
        radius *= 2;
    }

    public double GetRadius()
    {
        return radius;
    }
}
>>>>>>> 8db6c8002cf5989b1d9317496f33982cfca5989e
