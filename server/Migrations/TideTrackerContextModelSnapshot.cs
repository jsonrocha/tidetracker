﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using server;

namespace server.Migrations
{
    [DbContext(typeof(TideTrackerContext))]
    partial class TideTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TideTracker.WeatherStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Lat");

                    b.Property<int>("Long");

                    b.Property<string>("Nickname");

                    b.Property<string>("State");

                    b.Property<int>("StationId");

                    b.HasKey("Id");

                    b.ToTable("WeatherStations");

                    b.HasData(
                        new { Id = 1, Lat = 30, Long = -88, Nickname = "Coast Guard Sector", State = "Alabama", StationId = 8736897 },
                        new { Id = 2, Lat = 30, Long = -88, Nickname = "Dauphin Island", State = "Alabama", StationId = 8735180 },
                        new { Id = 3, Lat = 61, Long = -149, Nickname = "Anchorage", State = "Alaska", StationId = 9455920 },
                        new { Id = 4, Lat = 41, Long = -124, Nickname = "Crescent City", State = "California", StationId = 9419750 },
                        new { Id = 5, Lat = 41, Long = -72, Nickname = "New London", State = "Connecticut", StationId = 8461490 },
                        new { Id = 6, Lat = 39, Long = -75, Nickname = "Delaware City", State = "Delaware", StationId = 8551762 },
                        new { Id = 7, Lat = 30, Long = -87, Nickname = "Pensacola", State = "Florida", StationId = 8729840 },
                        new { Id = 8, Lat = 32, Long = -80, Nickname = "Fort Pulaski", State = "Georgia", StationId = 8670870 },
                        new { Id = 9, Lat = 29, Long = -91, Nickname = "Berwick, Atchafalaya River", State = "Louisiana", StationId = 8764044 },
                        new { Id = 10, Lat = 29, Long = -92, Nickname = "Freshwater Canal Locks", State = "Louisiana", StationId = 8766072 },
                        new { Id = 11, Lat = 44, Long = -66, Nickname = "Eastport", State = "Maine", StationId = 8410140 },
                        new { Id = 12, Lat = 39, Long = -76, Nickname = "Baltimore, Fort McHenry", State = "Maryland", StationId = 8574680 },
                        new { Id = 13, Lat = 41, Long = -70, Nickname = "Woods Hole", State = "Massachusetts", StationId = 8447930 },
                        new { Id = 14, Lat = 46, Long = -87, Nickname = "Marquette C.G.", State = "Michigan", StationId = 9099018 },
                        new { Id = 15, Lat = 31, Long = -89, Nickname = "Bay Waveland", State = "Mississippi", StationId = 8747437 },
                        new { Id = 16, Lat = 40, Long = -74, Nickname = "Sandy Hook", State = "New Jersey", StationId = 8531680 },
                        new { Id = 17, Lat = 42, Long = -73, Nickname = "Turkey Point Hudson River", State = "New York", StationId = 8518962 },
                        new { Id = 18, Lat = 36, Long = -75, Nickname = "Duck", State = "North Carolina", StationId = 8651370 },
                        new { Id = 19, Lat = 41, Long = -81, Nickname = "Fairpoint", State = "Ohio", StationId = 9063053 },
                        new { Id = 20, Lat = 42, Long = -124, Nickname = "Port Orford", State = "Oregon", StationId = 9431647 },
                        new { Id = 21, Lat = 41, Long = -71, Nickname = "Newport", State = "Rhode Island", StationId = 8452660 },
                        new { Id = 22, Lat = 32, Long = -79, Nickname = "Charleston, Cooper River Entrance", State = "South Carolina", StationId = 8665530 },
                        new { Id = 23, Lat = 29, Long = -94, Nickname = "High Island", State = "Texas", StationId = 8770808 },
                        new { Id = 24, Lat = 36, Long = -76, Nickname = "Money Point", State = "Virginia", StationId = 8639348 },
                        new { Id = 25, Lat = 46, Long = -123, Nickname = "Toke Point", State = "Washington", StationId = 9440910 },
                        new { Id = 26, Lat = 44, Long = -88, Nickname = "Green Bay", State = "Wisconsin", StationId = 9087079 },
                        new { Id = 27, Lat = 67, Long = -164, Nickname = "Red Dog Dock", State = "Alaska", StationId = 9491094 },
                        new { Id = 28, Lat = 60, Long = -145, Nickname = "Cordova", State = "Alaska", StationId = 9454050 },
                        new { Id = 29, Lat = 61, Long = -146, Nickname = "Valdez", State = "Alaska", StationId = 9454240 },
                        new { Id = 30, Lat = 57, Long = -152, Nickname = "Kodiak Island", State = "Alaska", StationId = 9457292 },
                        new { Id = 31, Lat = 56, Long = -154, Nickname = "Alitak", State = "Alaska", StationId = 9457804 },
                        new { Id = 32, Lat = 55, Long = -160, Nickname = "Port Moller", State = "Alaska", StationId = 9463502 },
                        new { Id = 33, Lat = 55, Long = -160, Nickname = "Sand Point", State = "Alaska", StationId = 9459450 },
                        new { Id = 34, Lat = 55, Long = -162, Nickname = "King Cove", State = "Alaska", StationId = 9459881 },
                        new { Id = 35, Lat = 53, Long = -166, Nickname = "Unalaska", State = "Alaska", StationId = 9462620 },
                        new { Id = 36, Lat = 52, Long = -174, Nickname = "Atka", State = "Alaska", StationId = 9461710 },
                        new { Id = 37, Lat = 51, Long = -176, Nickname = "Adak Island", State = "Alaska", StationId = 9461380 },
                        new { Id = 38, Lat = 38, Long = -123, Nickname = "Arena Cove", State = "California", StationId = 9416841 },
                        new { Id = 39, Lat = 37, Long = -122, Nickname = "Point Reyes", State = "California", StationId = 9415020 },
                        new { Id = 40, Lat = 38, Long = -122, Nickname = "Port Chicago", State = "California", StationId = 9415144 },
                        new { Id = 41, Lat = 38, Long = -122, Nickname = "Martinez-Amorco Pier", State = "California", StationId = 9415102 },
                        new { Id = 42, Lat = 37, Long = -122, Nickname = "San Francisco", State = "California", StationId = 9414290 },
                        new { Id = 43, Lat = 37, Long = -122, Nickname = "Alameda", State = "California", StationId = 9414750 },
                        new { Id = 44, Lat = 37, Long = -122, Nickname = "Redwood City", State = "California", StationId = 9414523 },
                        new { Id = 45, Lat = 35, Long = -120, Nickname = "Port San Luis", State = "California", StationId = 9412110 },
                        new { Id = 46, Lat = 34, Long = -118, Nickname = "Santa Monica", State = "California", StationId = 9410840 },
                        new { Id = 47, Lat = 32, Long = -117, Nickname = "La Jolla", State = "California", StationId = 9410230 },
                        new { Id = 48, Lat = 41, Long = -72, Nickname = "New Haven", State = "Connecticut", StationId = 8465705 },
                        new { Id = 49, Lat = 41, Long = -73, Nickname = "Bridgeport", State = "Connecticut", StationId = 8467150 },
                        new { Id = 50, Lat = 38, Long = -75, Nickname = "Brandywine Shoal Light", State = "Delaware", StationId = 8555889 },
                        new { Id = 51, Lat = 38, Long = -75, Nickname = "Lewes", State = "Delaware", StationId = 8557380 },
                        new { Id = 52, Lat = 29, Long = -84, Nickname = "Apalachicola", State = "Florida", StationId = 8728690 },
                        new { Id = 53, Lat = 30, Long = -81, Nickname = "Fernandina Beach", State = "Florida", StationId = 8720030 },
                        new { Id = 54, Lat = 30, Long = -81, Nickname = "Mayport, Bar Pilots Dock", State = "Florida", StationId = 8720218 },
                        new { Id = 55, Lat = 29, Long = -83, Nickname = "Cedar Key", State = "Florida", StationId = 8727520 },
                        new { Id = 56, Lat = 28, Long = -80, Nickname = "Trident Pier, Port Canaveral", State = "Florida", StationId = 8721604 },
                        new { Id = 57, Lat = 27, Long = -82, Nickname = "Clearwater Beach", State = "Florida", StationId = 8726724 },
                        new { Id = 58, Lat = 27, Long = -82, Nickname = "Old Port Tampa", State = "Florida", StationId = 8726607 },
                        new { Id = 59, Lat = 27, Long = -82, Nickname = "St. Petersburg, Tampa Bay", State = "Florida", StationId = 8726520 },
                        new { Id = 60, Lat = 26, Long = -81, Nickname = "Fort Myers, Caloosahatchee River", State = "Florida", StationId = 8725520 },
                        new { Id = 61, Lat = 26, Long = -80, Nickname = "Lake Worth Pier, Atlantic Ocean", State = "Florida", StationId = 8722670 },
                        new { Id = 62, Lat = 25, Long = -80, Nickname = "Virginia Key, Biscayne Bay", State = "Florida", StationId = 8723214 },
                        new { Id = 63, Lat = 24, Long = -81, Nickname = "Vaca Key, Florida Bay", State = "Florida", StationId = 8723970 },
                        new { Id = 64, Lat = 21, Long = -159, Nickname = "Nawiliwili", State = "Hawaii", StationId = 1611400 },
                        new { Id = 65, Lat = 21, Long = -157, Nickname = "Mokuoloe", State = "Hawaii", StationId = 1612480 },
                        new { Id = 66, Lat = 21, Long = -157, Nickname = "Honolulu", State = "Hawaii", StationId = 1612340 },
                        new { Id = 67, Lat = 20, Long = -155, Nickname = "Kawaihae", State = "Hawaii", StationId = 1617433 },
                        new { Id = 68, Lat = 20, Long = -155, Nickname = "Kawaihae", State = "Hawaii", StationId = 1617433 },
                        new { Id = 69, Lat = 29, Long = -91, Nickname = "Eugene Island, Gulf of Mexico", State = "Louisiana", StationId = 8764314 },
                        new { Id = 70, Lat = 30, Long = -90, Nickname = "New Canal Station", State = "Louisiana", StationId = 8761927 },
                        new { Id = 71, Lat = 29, Long = -89, Nickname = "Grand Isle", State = "Louisiana", StationId = 8761724 },
                        new { Id = 72, Lat = 29, Long = -89, Nickname = "Shell Beach", State = "Louisiana", StationId = 8761305 },
                        new { Id = 73, Lat = 29, Long = -89, Nickname = "Pilottown", State = "Louisiana", StationId = 8760721 },
                        new { Id = 74, Lat = 28, Long = -89, Nickname = "Pilots Station East, S.W. Pass", State = "Louisiana", StationId = 8760922 },
                        new { Id = 75, Lat = 44, Long = -67, Nickname = "Cutler Farris Wharf", State = "Maine", StationId = 8411060 },
                        new { Id = 76, Lat = 44, Long = -68, Nickname = "Bar Harbor", State = "Maine", StationId = 8413320 },
                        new { Id = 77, Lat = 43, Long = -70, Nickname = "Wells", State = "Maine", StationId = 8419317 },
                        new { Id = 78, Lat = 39, Long = -75, Nickname = "Chesapeake City", State = "Maryland", StationId = 8573927 },
                        new { Id = 79, Lat = 39, Long = -76, Nickname = "Tolchester Beach", State = "Maryland", StationId = 8573364 },
                        new { Id = 80, Lat = 38, Long = -76, Nickname = "Cambridge", State = "Maryland", StationId = 8571892 },
                        new { Id = 81, Lat = 38, Long = -76, Nickname = "Solomons Island", State = "Maryland", StationId = 8577330 },
                        new { Id = 82, Lat = 38, Long = -76, Nickname = "Bishops Head", State = "Maryland", StationId = 8571421 },
                        new { Id = 83, Lat = 38, Long = -75, Nickname = "Ocean City Inlet", State = "Maryland", StationId = 8570283 },
                        new { Id = 84, Lat = 41, Long = -70, Nickname = "Nantucket Island", State = "Massachusetts", StationId = 8449130 },
                        new { Id = 85, Lat = 46, Long = -87, Nickname = "Marquette C.G.", State = "Michigan", StationId = 9099018 },
                        new { Id = 86, Lat = 45, Long = -85, Nickname = "Port Inland", State = "Michigan", StationId = 9087096 },
                        new { Id = 87, Lat = 45, Long = -87, Nickname = "Menominee", State = "Michigan", StationId = 9087088 },
                        new { Id = 88, Lat = 43, Long = -86, Nickname = "Ludington", State = "Michigan", StationId = 9087023 },
                        new { Id = 89, Lat = 42, Long = -86, Nickname = "Holland", State = "Michigan", StationId = 9087031 },
                        new { Id = 90, Lat = 42, Long = -82, Nickname = "Algonac", State = "Michigan", StationId = 9014070 },
                        new { Id = 91, Lat = 42, Long = -82, Nickname = "Mouth of the Black River", State = "Michigan", StationId = 9014090 },
                        new { Id = 92, Lat = 43, Long = -82, Nickname = "Harbor Beach", State = "Michigan", StationId = 9075014 },
                        new { Id = 93, Lat = 45, Long = -83, Nickname = "Alpena", State = "Michigan", StationId = 9075065 },
                        new { Id = 94, Lat = 45, Long = -83, Nickname = "De Tour Village", State = "Michigan", StationId = 9075099 },
                        new { Id = 95, Lat = 46, Long = -84, Nickname = "Rock Cut", State = "Michigan", StationId = 9076024 },
                        new { Id = 96, Lat = 46, Long = -84, Nickname = "West Neebish Island", State = "Michigan", StationId = 9076027 },
                        new { Id = 97, Lat = 46, Long = -84, Nickname = "Little Rapids", State = "Michigan", StationId = 9076033 },
                        new { Id = 98, Lat = 46, Long = -84, Nickname = "SW Pier, St. Mary's River", State = "Michigan", StationId = 9076070 },
                        new { Id = 99, Lat = 46, Long = -84, Nickname = "Point Iroquois", State = "Michigan", StationId = 9099004 },
                        new { Id = 100, Lat = 38, Long = -74, Nickname = "Cape May", State = "New Jersey", StationId = 8536110 },
                        new { Id = 101, Lat = 39, Long = -75, Nickname = "Ship John Shoal", State = "New Jersey", StationId = 8537121 },
                        new { Id = 102, Lat = 40, Long = -74, Nickname = "Burlington, Delaware River", State = "New Jersey", StationId = 8539094 },
                        new { Id = 103, Lat = 40, Long = -73, Nickname = "Kings Point", State = "New York", StationId = 8516945 },
                        new { Id = 104, Lat = 35, Long = -75, Nickname = "Oregon Inlet Marina", State = "North Carolina", StationId = 8652587 },
                        new { Id = 105, Lat = 35, Long = -75, Nickname = "USCG Station Hatteras", State = "North Carolina", StationId = 8654467 },
                        new { Id = 106, Lat = 34, Long = -76, Nickname = "Beaufort", State = "North Carolina", StationId = 8656483 },
                        new { Id = 107, Lat = 34, Long = -77, Nickname = "Wrightsville Beach", State = "North Carolina", StationId = 8658163 },
                        new { Id = 108, Lat = 34, Long = -77, Nickname = "Wrightsville Beach", State = "North Carolina", StationId = 8658163 },
                        new { Id = 109, Lat = 44, Long = -124, Nickname = "South Beach", State = "Oregon", StationId = 9435380 },
                        new { Id = 110, Lat = 46, Long = -123, Nickname = "Astoria", State = "Oregon", StationId = 9439040 },
                        new { Id = 111, Lat = 40, Long = -74, Nickname = "Newbold", State = "Pennsylvania", StationId = 8548989 },
                        new { Id = 112, Lat = 41, Long = -71, Nickname = "Quonset Point", State = "Rhode Island", StationId = 8454049 },
                        new { Id = 113, Lat = 41, Long = -71, Nickname = "Conimicut Light", State = "Rhode Island", StationId = 8452944 },
                        new { Id = 114, Lat = 29, Long = -93, Nickname = "Port Arthur", State = "Texas", StationId = 8770475 },
                        new { Id = 115, Lat = 29, Long = -93, Nickname = "Sabine Pass North", State = "Texas", StationId = 8770570 },
                        new { Id = 116, Lat = 29, Long = -93, Nickname = "Texas Point, Sabine Pass", State = "Texas", StationId = 8770822 },
                        new { Id = 117, Lat = 29, Long = -94, Nickname = "Rollover Pass", State = "Texas", StationId = 8770971 },
                        new { Id = 118, Lat = 29, Long = -95, Nickname = "Manchester", State = "Texas", StationId = 8770777 },
                        new { Id = 119, Lat = 29, Long = -94, Nickname = "Morgans Point, Barbours Cut", State = "Texas", StationId = 8770613 },
                        new { Id = 120, Lat = 29, Long = -94, Nickname = "Eagle Point, Galveston Bay", State = "Texas", StationId = 8771013 },
                        new { Id = 121, Lat = 29, Long = -94, Nickname = "Galveston Bay Entrance, North Jetty", State = "Texas", StationId = 8771341 },
                        new { Id = 122, Lat = 29, Long = -94, Nickname = "Galveston Pier 21", State = "Texas", StationId = 8771450 },
                        new { Id = 123, Lat = 29, Long = -94, Nickname = "Galveston Railroad Bridge", State = "Texas", StationId = 8771486 },
                        new { Id = 124, Lat = 28, Long = -95, Nickname = "Freeport SPIP, Freeport Harbor", State = "Texas", StationId = 8772471 },
                        new { Id = 125, Lat = 28, Long = -95, Nickname = "Sargent", State = "Texas", StationId = 8772985 },
                        new { Id = 126, Lat = 28, Long = -95, Nickname = "Matagorda City", State = "Texas", StationId = 8773146 },
                        new { Id = 127, Lat = 28, Long = -96, Nickname = "Port Lavaca", State = "Texas", StationId = 8773259 },
                        new { Id = 128, Lat = 28, Long = -96, Nickname = "Aransas Wildlife Refuge", State = "Texas", StationId = 8774230 },
                        new { Id = 129, Lat = 28, Long = -96, Nickname = "Aransas Wildlife Refuge", State = "Texas", StationId = 8774230 },
                        new { Id = 130, Lat = 27, Long = -97, Nickname = "Bob Hall Pier", State = "Texas", StationId = 8775870 },
                        new { Id = 131, Lat = 26, Long = -97, Nickname = "Port Isabel", State = "Texas", StationId = 8779770 },
                        new { Id = 132, Lat = 38, Long = -77, Nickname = "Dahlgren", State = "Virginia", StationId = 8635027 },
                        new { Id = 133, Lat = 37, Long = -76, Nickname = "Lewisetta", State = "Virginia", StationId = 8635750 },
                        new { Id = 134, Lat = 37, Long = -75, Nickname = "Wachapreague", State = "Virginia", StationId = 8631044 },
                        new { Id = 135, Lat = 37, Long = -76, Nickname = "Yorktown USCG Training Center", State = "Virginia", StationId = 8637689 },
                        new { Id = 136, Lat = 48, Long = -123, Nickname = "Friday Harbor", State = "Washington", StationId = 9449880 },
                        new { Id = 137, Lat = 48, Long = -122, Nickname = "Port Townsend", State = "Washington", StationId = 9444900 },
                        new { Id = 138, Lat = 47, Long = -122, Nickname = "Seattle", State = "Washington", StationId = 9447130 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
