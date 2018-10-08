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

    public class WeatherResultsController : ControllerBase
    {
        private TideTrackerContext db = null;

        public WeatherResultsController(TideTrackerContext _db)
        { 
            this.db = _db;
        }

         [HttpGet("{id}")]
        public WeatherStation GetId(int id)
        {   
            var db = new TideTrackerContext();
            var station = this.db.WeatherStations.FirstOrDefault(w => w.StationId == id);

            return station;
        }   
    }
}