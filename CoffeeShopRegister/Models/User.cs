using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegister.Models;

public class User // STEP 1: MAKE OUR CLASS FOR OUR CONTROLLER 
{
    public int UserId { get; set; } //PRIMARY KEY FOR TABLE IN SQL Unique id for our row!! 

    [Required(ErrorMessage = "Valid First Name plz")] //VV--these things in the [] brackets are attributes that are validators for the property below it--VV
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Valid Last Name plz")] //VV--validate last name--VV
    public string LastName { get; set; }

    [EmailAddress]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Must be 8 characters long, can be ANY characters on keyboard :)")]
    public string Password { get; set; }
}
