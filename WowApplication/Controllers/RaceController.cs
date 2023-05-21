using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Controllers
{
    public class RaceController : Controller
    {
        private readonly ILogger<RaceController> _logger;
        private readonly IRaceRepository _raceRepository;
        private readonly IFactionRepository _factionRepository;

        public RaceController(ILogger<RaceController> logger, IFactionRepository factionRepository, IRaceRepository raceRepository)
        {
            _logger = logger;
            _factionRepository = factionRepository;
            _raceRepository = raceRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Races()
        {
            var races = _raceRepository.GetAllRaces();
            return View(races);
        }

        public IActionResult Create()
        {
            ViewBag.Factions = _factionRepository.GetAllFactions();            
            return View("AddRace");
        }


        [HttpPost]
        public IActionResult Create(RaceModel race)
        {                        
            _raceRepository.AddRace(race);
            return RedirectToAction("races", "Race");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Factions = _factionRepository.GetAllFactions();
            var race = _raceRepository.GetRaceById(id);
            return View("EditRace", race);
        }


        [HttpPost]
        public IActionResult Edit(RaceModel race)
        {           
            _raceRepository.UpdateRace(race);
            return RedirectToAction("races", "Race");
        }

        public IActionResult Delete(int id)
        {
            _raceRepository.DeleteRace(id);
            return RedirectToAction("races", "Race");
        }

        public IActionResult PopularStartLocation()
        {
            var race = _raceRepository.GetPopularestStartLocationByFraction();
            return View("RatedStartLocation", race);
        }

    }
}
