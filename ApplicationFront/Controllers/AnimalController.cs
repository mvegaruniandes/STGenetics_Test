using ApplicationFront.Models;
using Business.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Data;
using Models.Dtos;

namespace ApplicationFront.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public AnimalController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        // GET: AnimalController
        public ActionResult Index(int? page)
        {
            AnimalsModel model = new AnimalsModel();
            model.PageNumber = (page == null ? 1 : Convert.ToInt32(page));
            model.PageSize = 10;

            List<AnimalDTO> animals = new List<AnimalDTO>();
            GetAnimals getAnimals = new(_configuration);
            animals = getAnimals.GetAllAnimals();

            if (animals != null)
            {
                model.Animals = animals.OrderBy(x => x.AnimalId)
                         .Skip(model.PageSize * (model.PageNumber - 1))
                         .Take(model.PageSize).ToList();

                model.TotalCount = animals.Count();
                var pageNumber = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = pageNumber + 1;
            }

            return View(model);
        }

        // GET: AnimalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            LoadBreeds();
            return View();
        }

        [HttpPost]
        [Route("Animal/Create")]
        public ActionResult Create(AnimalModel animal)
        {
            LoadBreeds();

            if (!ModelState.IsValid)
                return View();

            AnimalDTO newAnimal = new()
            {
                Name = animal.Name,
                BreedId = animal.BreedId,
                BirthDate = Convert.ToDateTime(animal.BirthDate),
                Sex = animal.Sex,
                Price = Convert.ToDecimal(animal.Price),
                Status = Convert.ToBoolean(animal.Status),
                Photo = animal.Photo
            };
            
            CreateAnimal createAnimal = new(_configuration);

            var response = createAnimal.AddAnimal(newAnimal);

            if (response)
                return RedirectToAction("Index");
            else
                return View();
        }

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private void LoadBreeds()
        {
            List<BreedDTO> breeds = new List<BreedDTO>();

            GetBreeds getBreeds = new(_configuration);

            breeds = getBreeds.GetAllBreeds();
            breeds.Add(new BreedDTO { BreedId = 0, BreedName = "Select one.." });

            breeds = breeds.OrderBy(x => x.BreedId).ToList();

            ViewBag.breedsItems = new SelectList(breeds, "BreedId", "BreedName");
        }
    }
}
