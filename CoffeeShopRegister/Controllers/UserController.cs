using CoffeeShopRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegister.Controllers;

public class UserController : Controller
//STEP 2: Make a controller for our Model, in this case, the User. Create a controller, then name our result
{
    public IActionResult Register()
    {
        return View();
    }

    //We're gonna make an HTTP post attribute here for STEP 5
    //Post means from the browser or client to the controller
    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        return View();
    }
}
