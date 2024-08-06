using APIMovieLab.Models;
using APIMovieLab.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APIMovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //VSTEP 3 Now to inject our code from Program.cs right below!V
        private readonly IOMdbService _omdbService;

        public HomeController(ILogger<HomeController> logger, IOMdbService oMdbService)
        {
            _logger = logger;
            _omdbService = oMdbService;
        }

        //step 5 VV
        [HttpPost]
        //call our API and whatever we get, this is the action to do it!
        public async Task<IActionResult> Search(string movieName)
        {
            var result = await _omdbService.SearchMovies(movieName);
            return View(result.Search);
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
