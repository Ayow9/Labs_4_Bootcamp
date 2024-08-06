using CoffeeShopRegister.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//--VV sets up the server THIS IS STEP 8
//STEP 8: Tell .NET to have DB on standby! 
//this makes our code foolproof! It randomies it to anyone else BUT .NET
builder.Services.AddDbContext<AppDbContext>
    (x => x.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeDb")));

//^^STEP8 ALWAYS ABOVE "var app = builder.Build();"

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
