using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server;
using TideTracker;

namespace TideTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WeatherStationsController : ControllerBase
    {
        private TideTrackerContext db = null;

        public WeatherStationsController(TideTrackerContext _db)
        { 
            this.db = _db;
        }

         [HttpGet("{state}")]
        public IEnumerable<WeatherStation> GetState(string state)
        {   
            var db = new TideTrackerContext();

            var stationByState = this.db.WeatherStations.Where(w => w.State == state);

            return stationByState;
        }   
    }
}