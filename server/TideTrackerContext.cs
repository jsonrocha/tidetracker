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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=TideTracker;username=postgres;password=warrior");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherStation>().HasData(
                new WeatherStation { Id = 1, StationId = 8737048, Lat = 31, Long=-88, Nickname="Mobile State Docks", State="Alabama"},
                new WeatherStation { Id = 2, StationId = 8732828, Lat = 30, Long= -87, Nickname="Weeks Bay", State="Alabama"},
                new WeatherStation { Id = 3, StationId = 8735180, Lat = 30, Long= -88, Nickname="Dauphin Island", State="Alabama"},
                new WeatherStation { Id = 4, StationId = 9455920, Lat = 61, Long= -149, Nickname="Anchorage", State="Alaska"},
                new WeatherStation { Id = 5, StationId = 9419750, Lat = 41, Long= -124, Nickname="Crescent City", State="California"},
                new WeatherStation { Id = 6, StationId = 8461490, Lat = 41, Long= -72, Nickname="New London", State="Connecticut"},
                new WeatherStation { Id = 7, StationId = 8551762, Lat = 39, Long= -75, Nickname="Delaware City", State="Delaware"},
                new WeatherStation { Id = 8, StationId = 8726667, Lat = 27, Long= -82, Nickname="McKay Bay", State="Florida"},
                new WeatherStation { Id = 9, StationId = 8670870, Lat = 32, Long= -80, Nickname="Fort Pulaski", State="Georgia"},
                new WeatherStation { Id = 10, StationId = 1617760, Lat = 19, Long= -155, Nickname="Hilo Bay", State="Hawaii"},
                new WeatherStation { Id = 11, StationId = 9087044, Lat = 41, Long= -87, Nickname="Calumet Harbor", State="Illinois"},
                new WeatherStation { Id = 12, StationId = 8766072, Lat = 29, Long= -92, Nickname="Freshwater Canal Locks", State="Louisiana"},
                new WeatherStation { Id = 13, StationId = 8410140, Lat = 44, Long= -66, Nickname="Eastport", State="Maine"},
                new WeatherStation { Id = 14, StationId = 8574680, Lat = 39, Long= -76, Nickname="Baltimore, Fort McHenry", State="Maryland"},
                new WeatherStation { Id = 15, StationId = 8443970, Lat = 42, Long= -71, Nickname="Boston", State="Massachusetts"},
                new WeatherStation { Id = 16, StationId = 9075080, Lat = 45, Long= -84, Nickname="Mackinaw City", State="Michigan"},
                new WeatherStation { Id = 17, StationId = 9099064, Lat = 46, Long= -92, Nickname="Duluth", State="Minnesota"},
                new WeatherStation { Id = 18, StationId = 9099090, Lat = 47, Long= -90, Nickname="Grand Marais", State="Minnesota"},
                new WeatherStation { Id = 19, StationId = 8747437, Lat = 31, Long= -89, Nickname="Bay Waveland", State="Mississippi"},
                new WeatherStation { Id = 20, StationId = 8423898, Lat = 43, Long= -70, Nickname="Fort Point", State="New Hampshire"},
                new WeatherStation { Id = 21, StationId = 8531680, Lat = 40, Long= -74, Nickname="Sandy Hook", State="New Jersey"},
                new WeatherStation { Id = 22, StationId = 8518962, Lat = 42, Long= -73, Nickname="Turkey Point Hudson River", State="New York"},
                new WeatherStation { Id = 23, StationId = 8658120, Lat = 34, Long= -77, Nickname="Wilmington", State="North Carolina"},
                new WeatherStation { Id = 24, StationId = 9063079, Lat = 41, Long= -82, Nickname="Marblehead", State="Ohio"},
                new WeatherStation { Id = 25, StationId = 9431647, Lat = 42, Long= -124, Nickname="Port Orford", State="Oregon"},
                new WeatherStation { Id = 26, StationId = 8540433, Lat = 39, Long= -75, Nickname="Marcus Hook", State="Pennsylvania"},
                new WeatherStation { Id = 27, StationId = 8452660, Lat = 41, Long= -71, Nickname="Newport", State="Rhode Island"},
                new WeatherStation { Id = 28, StationId = 8665530, Lat = 32, Long= -79, Nickname="Charleston, Cooper River Entrance", State="South Carolina"},
                new WeatherStation { Id = 29, StationId = 8770808, Lat = 29, Long= -94, Nickname="High Island", State="Texas"},
                new WeatherStation { Id = 30, StationId = 8639348, Lat = 36, Long= -76, Nickname="Money Point", State="Virginia"},
                new WeatherStation { Id = 31, StationId = 9440910, Lat = 46, Long= -123, Nickname="Toke Point", State="Washington"},
                new WeatherStation { Id = 32, StationId = 9087079, Lat = 44, Long= -88, Nickname="Green Bay", State="Wisconsin"}
        );
        }

        public DbSet<WeatherStation> WeatherStations { get; set; }
    }
}
