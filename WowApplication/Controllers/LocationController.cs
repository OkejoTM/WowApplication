using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILogger<LocationController> _logger;
        private readonly ILocationRepository _locationRepository;


        public LocationController(ILogger<LocationController> logger, ILocationRepository locationRepository)
        {
            _logger = logger;
            _locationRepository = locationRepository;
        }

        public IActionResult PopularLocation()
        {
            LocationModel location = _locationRepository.GetPopulaterstLocation();
            return View("RatedLocation", location);
        }
    }
}
