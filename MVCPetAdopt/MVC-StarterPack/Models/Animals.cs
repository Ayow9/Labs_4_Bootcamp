using System.Diagnostics.Eventing.Reader;

namespace MVC_StarterPack.Models;

public class Animals
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string ImgName { get; set; }
    public bool IsAdopted { get; set; }
    //enumeration property
    public SpeciesEnum PetType { get; set; }
}
