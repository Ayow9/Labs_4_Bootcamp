
namespace AYClasses1;

public class Movie
{
    //property
    public string Title { get; set; }
    public string Category { get; set; }

    //constructor
    public Movie(string title, string category)
    {
        this.Title = title; 
        this.Category = category; //this is our command to construct our class varibles
    }

}
