using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Controllers
{
    public class FactionController : Controller
    {
        private readonly ILogger<FactionController> _logger;
        private readonly IFactionRepository _factionRepository;

        public FactionController(ILogger<FactionController> logger, IFactionRepository factionRepository)
        {
            _logger = logger;
            _factionRepository = factionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Factions()
        {
            var factions = _factionRepository.GetAllFactions();
            return View(factions);
        }

        public IActionResult Create()
        {            
            return View("AddFaction");
        }


        [HttpPost]
        public IActionResult Create(FactionModel faction)
        {
            _factionRepository.AddFaction(faction);
            return RedirectToAction("factions", "Faction");
        }

        public IActionResult Edit(int id)
        {            
            var faction = _factionRepository.GetFactionById(id);
            return View("EditFaction", faction);
        }


        [HttpPost]
        public IActionResult Edit(FactionModel faction)
        {
            _factionRepository.UpdateFaction(faction);
            return RedirectToAction("factions", "Faction");
        }

        public IActionResult Delete(int id)
        {
            _factionRepository.DeleteFaction(id);
            return RedirectToAction("factions", "Faction");
        }

        public IActionResult PopularFaction()
        {
            var faction = _factionRepository.GetPopularestFaction();   
            return View("RatedFaction", faction);
        }

        


    }
}
