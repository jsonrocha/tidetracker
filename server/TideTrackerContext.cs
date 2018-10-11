using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TideTracker;

namespace server
{
    public partial class TideTrackerContext : DbContext
    {
        public TideTrackerContext()
        {
        }

        public TideTrackerContext(DbContextOptions<TideTrackerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conn = Environment.GetEnvironmentVariable("CONNECTION_STRING") ??  "server=localhost;database=TideTracker;username=postgres;password=warrior";
                optionsBuilder.UseNpgsql(conn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherStation>().HasData(
                new WeatherStation { Id = 1, StationId = 8736897, Lat = 30, Long=-88, Nickname="Coast Guard Sector", State="Alabama"},
                new WeatherStation { Id = 2, StationId = 8735180, Lat = 30, Long= -88, Nickname="Dauphin Island", State="Alabama"},
                new WeatherStation { Id = 3, StationId = 9455920, Lat = 61, Long= -149, Nickname="Anchorage", State="Alaska"},
                new WeatherStation { Id = 4, StationId = 9419750, Lat = 41, Long= -124, Nickname="Crescent City", State="California"},
                new WeatherStation { Id = 5, StationId = 8461490, Lat = 41, Long= -72, Nickname="New London", State="Connecticut"},
                new WeatherStation { Id = 6, StationId = 8551762, Lat = 39, Long= -75, Nickname="Delaware City", State="Delaware"},
                new WeatherStation { Id = 7, StationId = 8729840, Lat = 30, Long= -87, Nickname="Pensacola", State="Florida"},
                new WeatherStation { Id = 8, StationId = 8670870, Lat = 32, Long= -80, Nickname="Fort Pulaski", State="Georgia"},
                new WeatherStation { Id = 9, StationId = 8764044, Lat = 29, Long= -91, Nickname="Berwick, Atchafalaya River", State="Louisiana"},
                new WeatherStation { Id = 10, StationId = 8766072, Lat = 29, Long= -92, Nickname="Freshwater Canal Locks", State="Louisiana"},
                new WeatherStation { Id = 11, StationId = 8410140, Lat = 44, Long= -66, Nickname="Eastport", State="Maine"},
                new WeatherStation { Id = 12, StationId = 8574680, Lat = 39, Long= -76, Nickname="Baltimore, Fort McHenry", State="Maryland"},
                new WeatherStation { Id = 13, StationId = 8447930, Lat = 41, Long= -70, Nickname="Woods Hole", State="Massachusetts"},
                new WeatherStation { Id = 14, StationId = 9099018, Lat = 46, Long= -87, Nickname="Marquette C.G.", State="Michigan"},
                new WeatherStation { Id = 15, StationId = 8747437, Lat = 31, Long= -89, Nickname="Bay Waveland", State="Mississippi"},
                new WeatherStation { Id = 16, StationId = 8531680, Lat = 40, Long= -74, Nickname="Sandy Hook", State="New Jersey"},
                new WeatherStation { Id = 17, StationId = 8518962, Lat = 42, Long= -73, Nickname="Turkey Point Hudson River", State="New York"},
                new WeatherStation { Id = 18, StationId = 8651370, Lat = 36, Long= -75, Nickname="Duck", State="North Carolina"},
                new WeatherStation { Id = 19, StationId = 9063053, Lat = 41, Long= -81, Nickname="Fairpoint", State="Ohio"},
                new WeatherStation { Id = 20, StationId = 9431647, Lat = 42, Long= -124, Nickname="Port Orford", State="Oregon"},
                new WeatherStation { Id = 21, StationId = 8452660, Lat = 41, Long= -71, Nickname="Newport", State="Rhode Island"},
                new WeatherStation { Id = 22, StationId = 8665530, Lat = 32, Long= -79, Nickname="Charleston, Cooper River Entrance", State="South Carolina"},
                new WeatherStation { Id = 23, StationId = 8770808, Lat = 29, Long= -94, Nickname="High Island", State="Texas"},
                new WeatherStation { Id = 24, StationId = 8639348, Lat = 36, Long= -76, Nickname="Money Point", State="Virginia"},
                new WeatherStation { Id = 25, StationId = 9440910, Lat = 46, Long= -123, Nickname="Toke Point", State="Washington"},
                new WeatherStation { Id = 26, StationId = 9087079, Lat = 44, Long= -88, Nickname="Green Bay", State="Wisconsin"},
                new WeatherStation { Id = 27, StationId = 9491094, Lat = 67, Long= -164, Nickname="Red Dog Dock", State="Alaska"},
                new WeatherStation { Id = 28, StationId = 9454050, Lat = 60, Long= -145, Nickname="Cordova", State="Alaska"},
                new WeatherStation { Id = 29, StationId = 9454240, Lat = 61, Long= -146, Nickname="Valdez", State="Alaska"},
                new WeatherStation { Id = 30, StationId = 9457292, Lat = 57, Long= -152, Nickname="Kodiak Island", State="Alaska"},
                new WeatherStation { Id = 31, StationId = 9457804, Lat = 56, Long= -154, Nickname="Alitak", State="Alaska"},          
                new WeatherStation { Id = 32, StationId = 9463502, Lat = 55, Long= -160, Nickname="Port Moller", State="Alaska"},          
                new WeatherStation { Id = 33, StationId = 9459450, Lat = 55, Long= -160, Nickname="Sand Point", State="Alaska"}, 
                new WeatherStation { Id = 34, StationId = 9459881, Lat = 55, Long= -162, Nickname="King Cove", State="Alaska"},          
                new WeatherStation { Id = 35, StationId = 9462620, Lat = 53, Long= -166, Nickname="Unalaska", State="Alaska"},                  
                new WeatherStation { Id = 36, StationId = 9461710, Lat = 52, Long= -174, Nickname="Atka", State="Alaska"},          
                new WeatherStation { Id = 37, StationId = 9461380, Lat = 51, Long= -176, Nickname="Adak Island", State="Alaska"},
                new WeatherStation { Id = 38, StationId = 9416841, Lat = 38, Long= -123, Nickname="Arena Cove", State="California"},        
                new WeatherStation { Id = 39, StationId = 9415020, Lat = 37, Long= -122, Nickname="Point Reyes", State="California"},
                new WeatherStation { Id = 40, StationId = 9415144, Lat = 38, Long= -122, Nickname="Port Chicago", State="California"},            
                new WeatherStation { Id = 41, StationId = 9415102, Lat = 38, Long= -122, Nickname="Martinez-Amorco Pier", State="California"},
                new WeatherStation { Id = 42, StationId = 9414290, Lat = 37, Long= -122, Nickname="San Francisco", State="California"},            
                new WeatherStation { Id = 43, StationId = 9414750, Lat = 37, Long= -122, Nickname="Alameda", State="California"},
                new WeatherStation { Id = 44, StationId = 9414523, Lat = 37, Long= -122, Nickname="Redwood City", State="California"},
                new WeatherStation { Id = 45, StationId = 9412110, Lat = 35, Long= -120, Nickname="Port San Luis", State="California"},
                new WeatherStation { Id = 46, StationId = 9410840, Lat = 34, Long= -118, Nickname="Santa Monica", State="California"},
                new WeatherStation { Id = 47, StationId = 9410230, Lat = 32, Long= -117, Nickname="La Jolla", State="California"},
                new WeatherStation { Id = 48, StationId = 8465705, Lat = 41, Long= -72, Nickname="New Haven", State="Connecticut"},
                new WeatherStation { Id = 49, StationId = 8467150, Lat = 41, Long= -73, Nickname="Bridgeport", State="Connecticut"},
                new WeatherStation { Id = 50, StationId = 8555889, Lat = 38, Long= -75, Nickname="Brandywine Shoal Light", State="Delaware"},
                new WeatherStation { Id = 51, StationId = 8557380, Lat = 38, Long= -75, Nickname="Lewes", State="Delaware"},
                new WeatherStation { Id = 52, StationId = 8728690, Lat = 29, Long= -84, Nickname="Apalachicola", State="Florida"},
                new WeatherStation { Id = 53, StationId = 8720030, Lat = 30, Long= -81, Nickname="Fernandina Beach", State="Florida"},
                new WeatherStation { Id = 54, StationId = 8720218, Lat = 30, Long= -81, Nickname="Mayport, Bar Pilots Dock", State="Florida"},
                new WeatherStation { Id = 55, StationId = 8727520, Lat = 29, Long= -83, Nickname="Cedar Key", State="Florida"},
                new WeatherStation { Id = 56, StationId = 8721604, Lat = 28, Long= -80, Nickname="Trident Pier, Port Canaveral", State="Florida"},
                new WeatherStation { Id = 57, StationId = 8726724, Lat = 27, Long= -82, Nickname="Clearwater Beach", State="Florida"},
                new WeatherStation { Id = 58, StationId = 8726607, Lat = 27, Long= -82, Nickname="Old Port Tampa", State="Florida"},
                new WeatherStation { Id = 59, StationId = 8726520, Lat = 27, Long= -82, Nickname="St. Petersburg, Tampa Bay", State="Florida"},
                new WeatherStation { Id = 60, StationId = 8725520, Lat = 26, Long= -81, Nickname="Fort Myers, Caloosahatchee River", State="Florida"},
                new WeatherStation { Id = 61, StationId = 8722670, Lat = 26, Long= -80, Nickname="Lake Worth Pier, Atlantic Ocean", State="Florida"},
                new WeatherStation { Id = 62, StationId = 8723214, Lat = 25, Long= -80, Nickname="Virginia Key, Biscayne Bay", State="Florida"},
                new WeatherStation { Id = 63, StationId = 8723970, Lat = 24, Long= -81, Nickname="Vaca Key, Florida Bay", State="Florida"},
                new WeatherStation { Id = 64, StationId = 1611400, Lat = 21, Long= -159, Nickname="Nawiliwili", State="Hawaii"},
                new WeatherStation { Id = 65, StationId = 1612480, Lat = 21, Long= -157, Nickname="Mokuoloe", State="Hawaii"},
                new WeatherStation { Id = 66, StationId = 1612340, Lat = 21, Long= -157, Nickname="Honolulu", State="Hawaii"},
                new WeatherStation { Id = 67, StationId = 1617433, Lat = 20, Long= -155, Nickname="Kawaihae", State="Hawaii"},
                new WeatherStation { Id = 68, StationId = 1617433, Lat = 20, Long= -155, Nickname="Kawaihae", State="Hawaii"},
                new WeatherStation { Id = 69, StationId = 8764314, Lat = 29, Long= -91, Nickname="Eugene Island, Gulf of Mexico", State="Louisiana"},
                new WeatherStation { Id = 70, StationId = 8761927, Lat = 30, Long= -90, Nickname="New Canal Station", State="Louisiana"},
                new WeatherStation { Id = 71, StationId = 8761724, Lat = 29, Long= -89, Nickname="Grand Isle", State="Louisiana"},
                new WeatherStation { Id = 72, StationId = 8761305, Lat = 29, Long= -89, Nickname="Shell Beach", State="Louisiana"},
                new WeatherStation { Id = 73, StationId = 8760721, Lat = 29, Long= -89, Nickname="Pilottown", State="Louisiana"},
                new WeatherStation { Id = 74, StationId = 8760922, Lat = 28, Long= -89, Nickname="Pilots Station East, S.W. Pass", State="Louisiana"},
                new WeatherStation { Id = 75, StationId = 8411060, Lat = 44, Long= -67, Nickname="Cutler Farris Wharf", State="Maine"},
                new WeatherStation { Id = 76, StationId = 8413320, Lat = 44, Long= -68, Nickname="Bar Harbor", State="Maine"},
                new WeatherStation { Id = 77, StationId = 8419317, Lat = 43, Long= -70, Nickname="Wells", State="Maine"},
                new WeatherStation { Id = 78, StationId = 8573927, Lat = 39, Long= -75, Nickname="Chesapeake City", State="Maryland"},
                new WeatherStation { Id = 79, StationId = 8573364, Lat = 39, Long= -76, Nickname="Tolchester Beach", State="Maryland"},
                new WeatherStation { Id = 80, StationId = 8571892, Lat = 38, Long= -76, Nickname="Cambridge", State="Maryland"},
                new WeatherStation { Id = 81, StationId = 8577330, Lat = 38, Long= -76, Nickname="Solomons Island", State="Maryland"},
                new WeatherStation { Id = 82, StationId = 8571421, Lat = 38, Long= -76, Nickname="Bishops Head", State="Maryland"},
                new WeatherStation { Id = 83, StationId = 8570283, Lat = 38, Long= -75, Nickname="Ocean City Inlet", State="Maryland"},
                new WeatherStation { Id = 84, StationId = 8449130, Lat = 41, Long= -70, Nickname="Nantucket Island", State="Massachusetts"},
                new WeatherStation { Id = 85, StationId = 9099018, Lat = 46, Long= -87, Nickname="Marquette C.G.", State="Michigan"},
                new WeatherStation { Id = 86, StationId = 9087096, Lat = 45, Long= -85, Nickname="Port Inland", State="Michigan"},
                new WeatherStation { Id = 87, StationId = 9087088, Lat = 45, Long= -87, Nickname="Menominee", State="Michigan"},
                new WeatherStation { Id = 88, StationId = 9087023, Lat = 43, Long= -86, Nickname="Ludington", State="Michigan"},
                new WeatherStation { Id = 89, StationId = 9087031, Lat = 42, Long= -86, Nickname="Holland", State="Michigan"},
                new WeatherStation { Id = 90, StationId = 9014070, Lat = 42, Long= -82, Nickname="Algonac", State="Michigan"},
                new WeatherStation { Id = 91, StationId = 9014090, Lat = 42, Long= -82, Nickname="Mouth of the Black River", State="Michigan"},
                new WeatherStation { Id = 92, StationId = 9075014, Lat = 43, Long= -82, Nickname="Harbor Beach", State="Michigan"},
                new WeatherStation { Id = 93, StationId = 9075065, Lat = 45, Long= -83, Nickname="Alpena", State="Michigan"},
                new WeatherStation { Id = 94, StationId = 9075099, Lat = 45, Long= -83, Nickname="De Tour Village", State="Michigan"},
                new WeatherStation { Id = 95, StationId = 9076024, Lat = 46, Long= -84, Nickname="Rock Cut", State="Michigan"},
                new WeatherStation { Id = 96, StationId = 9076027, Lat = 46, Long= -84, Nickname="West Neebish Island", State="Michigan"},
                new WeatherStation { Id = 97, StationId = 9076033, Lat = 46, Long= -84, Nickname="Little Rapids", State="Michigan"},
                new WeatherStation { Id = 98, StationId = 9076070, Lat = 46, Long= -84, Nickname="SW Pier, St. Mary's River", State="Michigan"},
                new WeatherStation { Id = 99, StationId = 9099004, Lat = 46, Long= -84, Nickname="Point Iroquois", State="Michigan"},
                new WeatherStation { Id = 100, StationId = 8536110, Lat = 38, Long= -74, Nickname="Cape May", State="New Jersey"},
                new WeatherStation { Id = 101, StationId = 8537121, Lat = 39, Long= -75, Nickname="Ship John Shoal", State="New Jersey"},
                new WeatherStation { Id = 102, StationId = 8539094, Lat = 40, Long= -74, Nickname="Burlington, Delaware River", State="New Jersey"},
                new WeatherStation { Id = 103, StationId = 8516945, Lat = 40, Long= -73, Nickname="Kings Point", State="New York"},
                new WeatherStation { Id = 104, StationId = 8652587, Lat = 35, Long= -75, Nickname="Oregon Inlet Marina", State="North Carolina"},
                new WeatherStation { Id = 105, StationId = 8654467, Lat = 35, Long= -75, Nickname="USCG Station Hatteras", State="North Carolina"},
                new WeatherStation { Id = 106, StationId = 8656483, Lat = 34, Long= -76, Nickname="Beaufort", State="North Carolina"},
                new WeatherStation { Id = 107, StationId = 8658163, Lat = 34, Long= -77, Nickname="Wrightsville Beach", State="North Carolina"},
                new WeatherStation { Id = 108, StationId = 8658163, Lat = 34, Long= -77, Nickname="Wrightsville Beach", State="North Carolina"},
                new WeatherStation { Id = 109, StationId = 9435380, Lat = 44, Long= -124, Nickname="South Beach", State="Oregon"},
                new WeatherStation { Id = 110, StationId = 9439040, Lat = 46, Long= -123, Nickname="Astoria", State="Oregon"},
                new WeatherStation { Id = 111, StationId = 8548989, Lat = 40, Long= -74, Nickname="Newbold", State="Pennsylvania"},
                new WeatherStation { Id = 112, StationId = 8454049, Lat = 41, Long= -71, Nickname="Quonset Point", State="Rhode Island"},
                new WeatherStation { Id = 113, StationId = 8452944, Lat = 41, Long= -71, Nickname="Conimicut Light", State="Rhode Island"},
                new WeatherStation { Id = 114, StationId = 8770475, Lat = 29, Long= -93, Nickname="Port Arthur", State="Texas"},
                new WeatherStation { Id = 115, StationId = 8770570, Lat = 29, Long= -93, Nickname="Sabine Pass North", State="Texas"},
                new WeatherStation { Id = 116, StationId = 8770822, Lat = 29, Long= -93, Nickname="Texas Point, Sabine Pass", State="Texas"},
                new WeatherStation { Id = 117, StationId = 8770971, Lat = 29, Long= -94, Nickname="Rollover Pass", State="Texas"},
                new WeatherStation { Id = 118, StationId = 8770777, Lat = 29, Long= -95, Nickname="Manchester", State="Texas"},
                new WeatherStation { Id = 119, StationId = 8770613, Lat = 29, Long= -94, Nickname="Morgans Point, Barbours Cut", State="Texas"},
                new WeatherStation { Id = 120, StationId = 8771013, Lat = 29, Long= -94, Nickname="Eagle Point, Galveston Bay", State="Texas"},
                new WeatherStation { Id = 121, StationId = 8771341, Lat = 29, Long= -94, Nickname="Galveston Bay Entrance, North Jetty", State="Texas"},
                new WeatherStation { Id = 122, StationId = 8771450, Lat = 29, Long= -94, Nickname="Galveston Pier 21", State="Texas"},
                new WeatherStation { Id = 123, StationId = 8771486, Lat = 29, Long= -94, Nickname="Galveston Railroad Bridge", State="Texas"},
                new WeatherStation { Id = 124, StationId = 8772471, Lat = 28, Long= -95, Nickname="Freeport SPIP, Freeport Harbor", State="Texas"},
                new WeatherStation { Id = 125, StationId = 8772985, Lat = 28, Long= -95, Nickname="Sargent", State="Texas"},
                new WeatherStation { Id = 126, StationId = 8773146, Lat = 28, Long= -95, Nickname="Matagorda City", State="Texas"},
                new WeatherStation { Id = 127, StationId = 8773259, Lat = 28, Long= -96, Nickname="Port Lavaca", State="Texas"},
                new WeatherStation { Id = 128, StationId = 8774230, Lat = 28, Long= -96, Nickname="Aransas Wildlife Refuge", State="Texas"},
                new WeatherStation { Id = 129, StationId = 8774230, Lat = 28, Long= -96, Nickname="Aransas Wildlife Refuge", State="Texas"},
                new WeatherStation { Id = 130, StationId = 8775870, Lat = 27, Long= -97, Nickname="Bob Hall Pier", State="Texas"},
                new WeatherStation { Id = 131, StationId = 8779770, Lat = 26, Long= -97, Nickname="Port Isabel", State="Texas"},
                new WeatherStation { Id = 132, StationId = 8635027, Lat = 38, Long= -77, Nickname="Dahlgren", State="Virginia"},
                new WeatherStation { Id = 133, StationId = 8635750, Lat = 37, Long= -76, Nickname="Lewisetta", State="Virginia"},
                new WeatherStation { Id = 134, StationId = 8631044, Lat = 37, Long= -75, Nickname="Wachapreague", State="Virginia"},
                new WeatherStation { Id = 135, StationId = 8637689, Lat = 37, Long= -76, Nickname="Yorktown USCG Training Center", State="Virginia"},
                new WeatherStation { Id = 136, StationId = 9449880, Lat = 48, Long= -123, Nickname="Friday Harbor", State="Washington"},
                new WeatherStation { Id = 137, StationId = 9444900, Lat = 48, Long= -122, Nickname="Port Townsend", State="Washington"},
                new WeatherStation { Id = 138, StationId = 9447130, Lat = 47, Long= -122, Nickname="Seattle", State="Washington"}
        );
        }

        public DbSet<WeatherStation> WeatherStations { get; set; }
    }
}