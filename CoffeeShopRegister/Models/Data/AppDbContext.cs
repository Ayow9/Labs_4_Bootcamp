using Microsoft.EntityFrameworkCore; //<--type this after installing EFC libray!
namespace CoffeeShopRegister.Models.Data;

public class AppDbContext :DbContext //STEP 7 CONT: this is where we can do SQL quereies; we're gonna inherit from parent class DbContext
{
    //create constructor
    public AppDbContext(DbContextOptions<AppDbContext> options): 
        base (options) //inhertiing constructors from parent class! Our connection string to SQL!
        { 

        }
    //STEP 9:
    //What tables in Sql db??
    public DbSet<User> Users { get; set; } //<--theres our answer
    //we rightclicked on project Open In Terminal and typed the following: "dotnet ef migrations add <whatevername>"
    //STEP 10: We will see a folder called Migrations under "Controllers"
    //STEP 11: In Developer PowerShell, type "dotnet ef database update" Then open up SQL and look for ProductDB database!
}
//we did code first to CREATE our SQL table and use that as the DB for our webapp!