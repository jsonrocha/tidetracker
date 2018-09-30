using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TideTracker.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationController : ControllerBase
    {
         [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "getting", "WeatherStations" };
        }

    }
}