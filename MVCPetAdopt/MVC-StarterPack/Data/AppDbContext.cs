using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_StarterPack.Models;
using System.Diagnostics.Eventing.Reader;

namespace MVC_StarterPack.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //Add your tables here
    public DbSet<Animals> Animals { get; set; }
}
