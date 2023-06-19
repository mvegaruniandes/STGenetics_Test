using ApplicationFront.Models;
using Business.Functions;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using System.Diagnostics;

namespace ApplicationFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            GetAnimals getAnimals = new(_configuration);

            animals = getAnimals.GetAllAnimals();

            return View("Index", animals);
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