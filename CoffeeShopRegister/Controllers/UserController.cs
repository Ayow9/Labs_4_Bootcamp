using CoffeeShopRegister.Models;
using CoffeeShopRegister.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegister.Controllers;

public class UserController : Controller
//STEP 2: Make a controller for our Model, in this case, the User. Create a controller, then name our result
{
    //Dependency Injection (D.I.) STEP 11
    private AppDbContext _dbContext; //makes a private copy of our db & handing off to controller
    //CONSTRUCTOR FOR D.I.
    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext; 
    }
    public IActionResult Register()
    {
        return View();
    }

    //We're gonna make an HTTP post attribute here for STEP 5
    //Post means from the browser or client to the controller
    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        //we're gonna use a library called Entity Framework Core (EFC) to have C# "talk" to SQL
        //STEP 6: We go to our appsettings.json object
        //STEP 7: Rightclick Models, create folder called "Data" add a class to it (usually AppDbContxt)

        _dbContext.Add(user);
        _dbContext.SaveChanges(); //<--part of STEP 11

        return RedirectToAction("Index", "Home"); //<--kicks user back to home pager after registering! 
    }
}
