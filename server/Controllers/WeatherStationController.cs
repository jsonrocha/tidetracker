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
    public class WeatherStationsController : ControllerBase
    {
        private TideTrackerContext db { get; set; }

        public WeatherStationsController()
        {
            this.db = new TideTrackerContext();
        }

         [HttpGet]
        public ActionResult<IEnumerable<WeatherStation>> Get()
        {
            this.db.SaveChanges();

            return Ok(this.db.WeatherStations);
        }   
    }
}