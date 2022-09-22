using Auth.Data.Models;
using Auth.Data.Repositories.PlantRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Auth.Web.Controllers
{
    [Authorize]
    public class PlantController : Controller
    {
        private readonly IPlantRepository _plantRepository;

        public PlantController(IPlantRepository plantRepository)
        {
            _plantRepository = plantRepository;
        }
        
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "SunFlower";
            return View(await _plantRepository.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Flower";
            return View(new PlantDto());
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlantDto model)
        {
            if (ModelState.IsValid)
                await _plantRepository.Add(model);

            return RedirectToAction("Index");
        }
    }
}
