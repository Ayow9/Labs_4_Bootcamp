using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_StarterPack.Data;
using MVC_StarterPack.Models;
using System.Diagnostics.Eventing.Reader;

namespace MVC_StarterPack.Controllers;

public class AdoptController : Controller
{
    private AppDbContext _dbContext; //makes a private copy of our db & handing off to controller
    //CONSTRUCTOR FOR D.I.
    public AdoptController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpPost]
    public IActionResult SearchAnimals(string breedInput) //this matches what we have in our Index.cshtml class: "<input type="text" name="breedInput" />"
    {
        //SELECT * FROM Animals WHERE Description = breedInput
        var animals = _dbContext.Animals.Where(x => x.Breed == breedInput).ToList();
        return View(animals);
    }

    [HttpPost]
    public IActionResult Add(Animals animal)
    {
 
        return View(animal);  //<--kicks user back to home pager after registering! 

    }
    //We're gonna make an HTTP post attribute here for STEP 5
    //Post means post from the browser or client to the controller

}
