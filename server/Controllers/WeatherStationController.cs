using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server;

namespace TideTracker.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationController : ControllerBase
    {
         [HttpGet]
        public ActionResult<IEnumerable<WeatherStation>> Get()
        {
            var db = new TideTrackerContext();

            return db.WeatherStations;
        }

    }
}