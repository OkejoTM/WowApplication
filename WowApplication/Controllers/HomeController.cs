using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFactionRepository _factionRepository;
        private readonly IRaceRepository _raceRepository;

        public HomeController(ILogger<HomeController> logger, IFactionRepository factionRepository, IRaceRepository raceRepository)
        {
            _logger = logger;
            _factionRepository = factionRepository;
            _raceRepository = raceRepository;
        }

        public IActionResult Index()
        {
            /*var faction = new FactionModel("Aliance", "Shtormgrad", "Horde suck");
            _factionRepository.AddFaction(faction);*/

            /*var factions = _factionRepository.GetAllFactions();
            foreach(var faction in factions)
            {
                Console.WriteLine(faction.Name);
            }*/

            /*FactionModel faction = new FactionModel(1, "Alliance", "Shtormgrad", "Horde sucks");

            _factionRepository.UpdateFaction(faction);*/

            /*var race = _raceRepository.GetRaceById(6);
            Console.WriteLine(race.Faction.Id);*/


            /*_raceRepository.DeleteRace(11);*/

            /*var races = _raceRepository.GetAllRaces();
            foreach(var race in races)
            {
                Console.Write(race.Id.ToString());
                Console.WriteLine(race.Faction.Id);

            }*/

            

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
