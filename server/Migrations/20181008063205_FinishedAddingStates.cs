using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class FinishedAddingStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -177, "Sand Island, Midway Islands", 1619910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -91, "Berwick, Atchafalaya River", "Louisiana", 8764044 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 41, -70, "Woods Hole", 8447930 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -87, "Marquette C.G.", 9099018 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Sandy Hook", "New Jersey", 8531680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -73, "Turkey Point Hudson River", "New York", 8518962 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -75, "Duck", "North Carolina", 8651370 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -81, "Fairpoint", "Ohio", 9063053 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -124, "Port Orford", "Oregon", 9431647 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Philadelphia", "Pennsylvania", 8545240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Newport", "Rhode Island", 8452660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "High Island", "Texas", 8770808 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -76, "Money Point", "Virginia", 8639348 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Toke Point", "Washington", 9440910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -88, "Green Bay", "Wisconsin", 9087079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", "Alaska", 9491094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -145, "Cordova", 9454050 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -146, "Valdez", 9454240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 57, -152, "Kodiak Island", 9457292 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 56, -154, "Alitak", 9457804 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -160, "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Sand Point", 9459450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -162, "King Cove", 9459881 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 53, -166, "Unalaska", 9462620 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 52, -174, "Atka", 9461710 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 51, -176, "Adak Island", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", "California", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 37, -122, "Point Reyes", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 38, "Port Chicago", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Martinez-Amorco Pier", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 37, "San Francisco", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Alameda", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Redwood City", 9414523 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 35, -120, "Port San Luis", 9412110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 34, -118, "Santa Monica", 9410840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 32, -117, "La Jolla", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -72, "New Haven", "Connecticut", 8465705 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -73, "Bridgeport", 8467150 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Brandywine Shoal Light", "Delaware", 8555889 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Lewes", 8557380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -85, "Panama City Beach", "Florida", 8729210 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Panama City", 8729108 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -84, "Apalachicola", 8728690 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -81, "Fernandina Beach", 8720030 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Mayport, Bar Pilots Dock", 8720218 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -83, "Cedar Key", 8727520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -80, "Trident Pier, Port Canaveral", 8721604 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "Clearwater Beach", 8726724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Old Port Tampa", 8726607 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "St. Petersburg, Tampa Bay", 8726520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 26, -81, "Fort Myers, Caloosahatchee River", 8725520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -80, "Lake Worth Pier, Atlantic Ocean", 8722670 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 25, "Virginia Key, Biscayne Bay", 8723214 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 24, -81, "Vaca Key, Florida Bay", 8723970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 21, -159, "Nawiliwili", "Hawaii", 1611400 });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[,]
                {
                    { 182, 47, -122, "Tacoma", "Washington", 9446484 },
                    { 152, 29, -95, "Manchester", "Texas", 8770777 },
                    { 151, 29, -94, "Rollover Pass", "Texas", 8770971 },
                    { 150, 29, -93, "Texas Point, Sabine Pass", "Texas", 8770822 },
                    { 149, 29, -93, "Sabine Pass North", "Texas", 8770570 },
                    { 148, 29, -93, "Port Arthur", "Texas", 8770475 },
                    { 147, 41, -71, "Providence", "Rhode Island", 8454000 },
                    { 146, 41, -71, "Conimicut Light", "Rhode Island", 8452944 },
                    { 145, 41, -71, "Quonset Point", "Rhode Island", 8454049 },
                    { 144, 40, -74, "Newbold", "Pennsylvania", 8548989 },
                    { 143, 42, -80, "Erie, Lake Erie", "Pennsylvania", 9063038 },
                    { 142, 39, -75, "Bridesburg", "Pennsylvania", 8546252 },
                    { 153, 29, -94, "Morgans Point, Barbours Cut", "Texas", 8770613 },
                    { 141, 46, -123, "Astoria", "Oregon", 9439040 },
                    { 139, 45, -123, "Garibaldi", "Oregon", 9437540 },
                    { 138, 44, -124, "South Beach", "Oregon", 9435380 },
                    { 137, 43, -124, "Charleston", "Oregon", 9432780 },
                    { 136, 41, -83, "Toledo", "Ohio", 9063085 },
                    { 135, 41, -81, "Cleveland", "Ohio", 9063063 },
                    { 134, 34, -77, "Wrightsville Beach", "North Carolina", 8658163 },
                    { 133, 34, -77, "Wrightsville Beach", "North Carolina", 8658163 },
                    { 132, 34, -76, "Beaufort", "North Carolina", 8656483 },
                    { 131, 35, -75, "USCG Station Hatteras", "North Carolina", 8654467 },
                    { 130, 35, -75, "Oregon Inlet Marina", "North Carolina", 8652587 },
                    { 129, 42, -79, "Sturgeon Point", "New York", 9063028 },
                    { 140, 46, -123, "Astoria", "Oregon", 9439040 },
                    { 154, 29, -94, "Eagle Point, Galveston Bay", "Texas", 8771013 },
                    { 155, 29, -94, "Galveston Bay Entrance, North Jetty", "Texas", 8771341 },
                    { 156, 29, -94, "Galveston Pier 21", "Texas", 8771450 },
                    { 181, 47, -122, "Seattle", "Washington", 9447130 },
                    { 180, 47, -124, "La Push, Quillayute River", "Washington", 9442396 },
                    { 179, 48, -124, "Neah Bay", "Washington", 9443090 },
                    { 178, 48, -123, "Port Angeles", "Washington", 9444090 },
                    { 177, 48, -122, "Port Townsend", "Washington", 9444900 },
                    { 176, 48, -123, "Friday Harbor", "Washington", 9449880 },
                    { 175, 36, -76, "Sewells Point", "Virginia", 8638610 },
                    { 174, 37, -76, "CBBT, Chesapeake Channel", "Virginia", 8638901 },
                    { 173, 37, -75, "Kiptopeke", "Virginia", 8632200 },
                    { 172, 37, -76, "Yorktown USCG Training Center", "Virginia", 8637689 },
                    { 171, 37, -75, "Wachapreague", "Virginia", 8631044 },
                    { 170, 37, -76, "Lewisetta", "Virginia", 8635750 },
                    { 169, 38, -77, "Dahlgren", "Virginia", 8635027 },
                    { 168, 26, -97, "Port Isabel", "Texas", 8779770 },
                    { 167, 26, -97, "SPI Brazos Santiago", "Texas", 8779749 },
                    { 166, 27, -97, "Bob Hall Pier", "Texas", 8775870 },
                    { 165, 27, -97, "USS Lexington, Corpus Christi Bay", "Texas", 8775296 },
                    { 164, 28, -96, "Aransas Wildlife Refuge", "Texas", 8774230 },
                    { 163, 28, -96, "Aransas Wildlife Refuge", "Texas", 8774230 },
                    { 162, 28, -96, "Port Lavaca", "Texas", 8773259 },
                    { 161, 28, -95, "Matagorda City", "Texas", 8773146 },
                    { 160, 28, -95, "Sargent", "Texas", 8772985 },
                    { 159, 28, -95, "Freeport SPIP, Freeport Harbor", "Texas", 8772471 },
                    { 158, 29, -95, "San Luis Pass", "Texas", 8771972 },
                    { 157, 29, -94, "Galveston Railroad Bridge", "Texas", 8771486 },
                    { 128, 42, -78, "Buffalo", "New York", 9063020 },
                    { 127, 43, -79, "Niagara Intake", "New York", 9063012 },
                    { 99, 45, -85, "Port Inland", "Michigan", 9087096 },
                    { 125, 43, -76, "Oswego", "New York", 9052030 },
                    { 95, 38, -75, "Ocean City Inlet", "Maryland", 8570283 },
                    { 94, 38, -76, "Bishops Head", "Maryland", 8571421 },
                    { 93, 38, -76, "Solomons Island", "Maryland", 8577330 },
                    { 92, 38, -76, "Cambridge", "Maryland", 8571892 },
                    { 91, 38, -76, "Annapolis", "Maryland", 8575512 },
                    { 90, 39, -76, "Tolchester Beach", "Maryland", 8573364 },
                    { 89, 39, -75, "Chesapeake City", "Maryland", 8573927 },
                    { 88, 43, -70, "Wells", "Maine", 8419317 },
                    { 87, 43, -70, "Portland", "Maine", 8418150 },
                    { 86, 44, -68, "Bar Harbor", "Maine", 8413320 },
                    { 85, 44, -67, "Cutler Farris Wharf", "Maine", 8411060 },
                    { 84, 28, -89, "Pilots Station East, S.W. Pass", "Louisiana", 8760922 },
                    { 83, 29, -89, "Pilottown", "Louisiana", 8760721 },
                    { 82, 29, -89, "Shell Beach", "Louisiana", 8761305 },
                    { 81, 29, -89, "Grand Isle", "Louisiana", 8761724 },
                    { 80, 29, -90, "Carrollton", "Louisiana", 8761955 },
                    { 79, 30, -90, "New Canal Station", "Louisiana", 8761927 },
                    { 78, 29, -90, "West Bank 1, Bayou Gauche", "Louisiana", 8762482 },
                    { 77, 29, -91, "LAWMA, Amerada Pass", "Louisiana", 8764227 },
                    { 76, 29, -91, "Eugene Island, Gulf of Mexico", "Louisiana", 8764314 },
                    { 75, 20, -155, "Kawaihae", "Hawaii", 1617433 },
                    { 74, 20, -155, "Kawaihae", "Hawaii", 1617433 },
                    { 73, 20, -156, "Kahului", "Hawaii", 1615680 },
                    { 72, 21, -157, "Honolulu", "Hawaii", 1612340 },
                    { 71, 21, -157, "Mokuoloe", "Hawaii", 1612480 },
                    { 96, 41, -71, "Fall River", "Massachusetts", 8447386 },
                    { 126, 43, -77, "Rochester", "New York", 9052058 },
                    { 97, 41, -70, "Nantucket Island", "Massachusetts", 8449130 },
                    { 183, 46, -124, "Westport", "Washington", 9441102 },
                    { 124, 44, -75, "Alexandria Bay", "New York", 8311062 },
                    { 123, 44, -75, "Ogdensburg", "New York", 8311030 },
                    { 122, 41, -71, "Montauk", "New York", 8510560 },
                    { 121, 40, -73, "Kings Point", "New York", 8516945 },
                    { 120, 40, -74, "Bergen Point West Reach", "New York", 8519483 },
                    { 119, 40, -74, "Burlington, Delaware River", "New Jersey", 8539094 },
                    { 118, 39, -75, "Ship John Shoal", "New Jersey", 8537121 },
                    { 117, 39, -74, "Atlantic City", "New Jersey", 8534720 },
                    { 116, 38, -74, "Cape May", "New Jersey", 8536110 },
                    { 115, 30, -88, "Pascagoula NOAA Lab", "Mississippi", 8741533 },
                    { 114, 30, -88, "Grand Bay NERR, Mississippi Sound", "Mississippi", 8740166 },
                    { 113, 46, -84, "Point Iroquois", "Michigan", 9099004 },
                    { 112, 46, -84, "SW Pier, St. Mary's River", "Michigan", 9076070 },
                    { 111, 46, -84, "Little Rapids", "Michigan", 9076033 },
                    { 110, 46, -84, "West Neebish Island", "Michigan", 9076027 },
                    { 109, 46, -84, "Rock Cut", "Michigan", 9076024 },
                    { 108, 45, -83, "De Tour Village", "Michigan", 9075099 },
                    { 107, 45, -83, "Alpena", "Michigan", 9075065 },
                    { 106, 43, -82, "Harbor Beach", "Michigan", 9075014 },
                    { 105, 43, -82, "Harbor Beach", "Michigan", 9075014 },
                    { 104, 42, -82, "Mouth of the Black River", "Michigan", 9014090 },
                    { 103, 42, -82, "Algonac", "Michigan", 9014070 },
                    { 102, 42, -86, "Holland", "Michigan", 9087031 },
                    { 101, 43, -86, "Ludington", "Michigan", 9087023 },
                    { 100, 45, -87, "Menominee", "Michigan", 9087088 },
                    { 98, 46, -87, "Marquette C.G.", "Michigan", 9099018 },
                    { 184, 46, -122, "Longview", "Washington", 9440422 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 19, -155, "Hilo Bay", 1617760 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -87, "Calumet Harbor", "Illinois", 9087044 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 42, -71, "Boston", 8443970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 45, -84, "Mackinaw City", 9075080 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 43, -70, "Fort Point", "New Hampshire", 8423898 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Sandy Hook", "New Jersey", 8531680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -73, "Turkey Point Hudson River", "New York", 8518962 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wilmington", "North Carolina", 8658120 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -82, "Marblehead", "Ohio", 9063079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -124, "Port Orford", "Oregon", 9431647 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Marcus Hook", "Pennsylvania", 8540433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Newport", "Rhode Island", 8452660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "High Island", "Texas", 8770808 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -76, "Money Point", "Virginia", 8639348 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Toke Point", "Washington", 9440910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -88, "Green Bay", "Wisconsin", 9087079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", 9491094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -145, "Cordova", 9454050 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -146, "Valdez", 9454240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 57, -152, "Kodiak Island", 9457292 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 56, -154, "Alitak", 9457804 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -160, "Sand Point", 9459450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -162, "King Cove", 9459881 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 53, -166, "Unalaska", 9462620 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 52, -174, "Atka", 9461710 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 51, -176, "Adak Island", "Alaska", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 37, "Point Reyes", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Port Chicago", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 38, "Martinez-Amorco Pier", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "San Francisco", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Alameda", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 37, -122, "Redwood City", 9414523 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 35, -120, "Port San Luis", 9412110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 34, -118, "Santa Monica", 9410840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -117, "La Jolla", "California", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -72, "New Haven", 8465705 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -73, "Bridgeport", "Connecticut", 8467150 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Brandywine Shoal Light", 8555889 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Lewes", "Delaware", 8557380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Panama City Beach", 8729210 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -85, "Panama City", 8729108 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -84, "Apalachicola", 8728690 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Fernandina Beach", 8720030 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -81, "Mayport, Bar Pilots Dock", 8720218 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -83, "Cedar Key", 8727520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -80, "Trident Pier, Port Canaveral", 8721604 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Clearwater Beach", 8726724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Old Port Tampa", 8726607 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "St. Petersburg, Tampa Bay", 8726520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -81, "Fort Myers, Caloosahatchee River", 8725520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 26, "Lake Worth Pier, Atlantic Ocean", 8722670 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 25, -80, "Virginia Key, Biscayne Bay", 8723214 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 24, -81, "Vaca Key, Florida Bay", "Florida", 8723970 });
        }
    }
}
