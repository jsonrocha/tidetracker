using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class DataUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Newport", "Rhode Island", 8452660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "High Island", "Texas", 8770808 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -76, "Money Point", "Virginia", 8639348 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Toke Point", "Washington", 9440910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -88, "Green Bay", "Wisconsin", 9087079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", "Alaska", 9491094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -145, "Cordova", 9454050 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -146, "Valdez", 9454240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 57, -152, "Kodiak Island", 9457292 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 56, -154, "Alitak", 9457804 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -160, "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Sand Point", 9459450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -162, "King Cove", 9459881 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 53, -166, "Unalaska", 9462620 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 52, -174, "Atka", 9461710 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 51, -176, "Adak Island", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", "California", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 37, -122, "Point Reyes", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 38, "Port Chicago", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Martinez-Amorco Pier", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 37, "San Francisco", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Alameda", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Redwood City", 9414523 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 35, -120, "Port San Luis", 9412110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 34, -118, "Santa Monica", 9410840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 32, -117, "La Jolla", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -72, "New Haven", "Connecticut", 8465705 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -73, "Bridgeport", 8467150 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Brandywine Shoal Light", "Delaware", 8555889 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Lewes", 8557380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -84, "Apalachicola", "Florida", 8728690 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -81, "Fernandina Beach", 8720030 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -81, "Mayport, Bar Pilots Dock", 8720218 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -83, "Cedar Key", 8727520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -80, "Trident Pier, Port Canaveral", 8721604 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "Clearwater Beach", 8726724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "Old Port Tampa", 8726607 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "St. Petersburg, Tampa Bay", 8726520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 26, -81, "Fort Myers, Caloosahatchee River", 8725520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 26, -80, "Lake Worth Pier, Atlantic Ocean", 8722670 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 25, -80, "Virginia Key, Biscayne Bay", 8723214 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 24, "Vaca Key, Florida Bay", 8723970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 21, -159, "Nawiliwili", "Hawaii", 1611400 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 21, -157, "Mokuoloe", "Hawaii", 1612480 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 21, -157, "Honolulu", "Hawaii", 1612340 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 20, -155, "Kawaihae", 1617433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 20, -155, "Kawaihae", 1617433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -91, "Eugene Island, Gulf of Mexico", "Louisiana", 8764314 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -90, "New Canal Station", "Louisiana", 8761927 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -89, "Grand Isle", "Louisiana", 8761724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -89, "Shell Beach", "Louisiana", 8761305 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -89, "Pilottown", 8760721 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -89, "Pilots Station East, S.W. Pass", 8760922 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -67, "Cutler Farris Wharf", "Maine", 8411060 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -68, "Bar Harbor", "Maine", 8413320 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 43, -70, "Wells", "Maine", 8419317 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Chesapeake City", "Maryland", 8573927 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -76, "Tolchester Beach", "Maryland", 8573364 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Cambridge", "Maryland", 8571892 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Solomons Island", "Maryland", 8577330 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Bishops Head", "Maryland", 8571421 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Ocean City Inlet", "Maryland", 8570283 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -70, "Nantucket Island", "Massachusetts", 8449130 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -87, "Marquette C.G.", "Michigan", 9099018 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 45, -85, "Port Inland", "Michigan", 9087096 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 45, -87, "Menominee", "Michigan", 9087088 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 43, -86, "Ludington", "Michigan", 9087023 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -86, "Holland", "Michigan", 9087031 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -82, "Algonac", "Michigan", 9014070 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 42, -82, "Mouth of the Black River", 9014090 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 43, -82, "Harbor Beach", 9075014 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -83, "Alpena", 9075065 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 45, -83, "De Tour Village", 9075099 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -84, "Rock Cut", 9076024 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -84, "West Neebish Island", 9076027 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -84, "Little Rapids", 9076033 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -84, "SW Pier, St. Mary's River", 9076070 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -84, "Point Iroquois", 9099004 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -74, "Cape May", "New Jersey", 8536110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Ship John Shoal", "New Jersey", 8537121 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Burlington, Delaware River", "New Jersey", 8539094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -73, "Kings Point", "New York", 8516945 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 35, -75, "Oregon Inlet Marina", "North Carolina", 8652587 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 35, -75, "USCG Station Hatteras", "North Carolina", 8654467 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -76, "Beaufort", "North Carolina", 8656483 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wrightsville Beach", "North Carolina", 8658163 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wrightsville Beach", "North Carolina", 8658163 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -124, "South Beach", "Oregon", 9435380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Astoria", "Oregon", 9439040 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Newbold", "Pennsylvania", 8548989 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Quonset Point", "Rhode Island", 8454049 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Conimicut Light", "Rhode Island", 8452944 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -93, "Port Arthur", "Texas", 8770475 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -93, "Sabine Pass North", "Texas", 8770570 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -93, "Texas Point, Sabine Pass", "Texas", 8770822 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Rollover Pass", "Texas", 8770971 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -95, "Manchester", "Texas", 8770777 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Morgans Point, Barbours Cut", "Texas", 8770613 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Eagle Point, Galveston Bay", "Texas", 8771013 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Galveston Bay Entrance, North Jetty", "Texas", 8771341 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Galveston Pier 21", "Texas", 8771450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -94, "Galveston Railroad Bridge", 8771486 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -95, "Freeport SPIP, Freeport Harbor", 8772471 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -95, "Sargent", 8772985 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -95, "Matagorda City", 8773146 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -96, "Port Lavaca", 8773259 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -96, "Aransas Wildlife Refuge", 8774230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -96, "Aransas Wildlife Refuge", 8774230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -97, "Bob Hall Pier", 8775870 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 26, -97, "Port Isabel", 8779770 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -77, "Dahlgren", "Virginia", 8635027 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -76, "Lewisetta", "Virginia", 8635750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -75, "Wachapreague", "Virginia", 8631044 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -76, "Yorktown USCG Training Center", "Virginia", 8637689 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 48, -123, "Friday Harbor", "Washington", 9449880 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 48, -122, "Port Townsend", "Washington", 9444900 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 47, -122, "Seattle", "Washington", 9447130 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Philadelphia", "Pennsylvania", 8545240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Newport", "Rhode Island", 8452660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "High Island", "Texas", 8770808 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -76, "Money Point", "Virginia", 8639348 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Toke Point", "Washington", 9440910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -88, "Green Bay", "Wisconsin", 9087079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", 9491094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -145, "Cordova", 9454050 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -146, "Valdez", 9454240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 57, -152, "Kodiak Island", 9457292 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 56, -154, "Alitak", 9457804 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -160, "Sand Point", 9459450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -162, "King Cove", 9459881 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 53, -166, "Unalaska", 9462620 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 52, -174, "Atka", 9461710 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 51, -176, "Adak Island", "Alaska", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 37, "Point Reyes", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Port Chicago", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 38, "Martinez-Amorco Pier", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "San Francisco", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Alameda", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 37, -122, "Redwood City", 9414523 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 35, -120, "Port San Luis", 9412110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 34, -118, "Santa Monica", 9410840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -117, "La Jolla", "California", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -72, "New Haven", 8465705 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -73, "Bridgeport", "Connecticut", 8467150 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Nickname", "StationId" },
                values: new object[] { "Brandywine Shoal Light", 8555889 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Lewes", "Delaware", 8557380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -85, "Panama City Beach", 8729210 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -85, "Panama City", 8729108 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -84, "Apalachicola", 8728690 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -81, "Fernandina Beach", 8720030 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -81, "Mayport, Bar Pilots Dock", 8720218 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -83, "Cedar Key", 8727520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 28, -80, "Trident Pier, Port Canaveral", 8721604 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "Clearwater Beach", 8726724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "Old Port Tampa", 8726607 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "St. Petersburg, Tampa Bay", 8726520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 26, "Fort Myers, Caloosahatchee River", 8725520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 26, -80, "Lake Worth Pier, Atlantic Ocean", "Florida", 8722670 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 25, -80, "Virginia Key, Biscayne Bay", "Florida", 8723214 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 24, -81, "Vaca Key, Florida Bay", "Florida", 8723970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 21, -159, "Nawiliwili", 1611400 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 21, -157, "Mokuoloe", 1612480 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 21, -157, "Honolulu", "Hawaii", 1612340 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 20, -156, "Kahului", "Hawaii", 1615680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 20, -155, "Kawaihae", "Hawaii", 1617433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 20, -155, "Kawaihae", "Hawaii", 1617433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -91, "Eugene Island, Gulf of Mexico", 8764314 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -91, "LAWMA, Amerada Pass", 8764227 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -90, "New Canal Station", "Louisiana", 8761927 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -90, "Carrollton", "Louisiana", 8761955 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -89, "Grand Isle", "Louisiana", 8761724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -89, "Shell Beach", "Louisiana", 8761305 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -89, "Pilottown", "Louisiana", 8760721 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -89, "Pilots Station East, S.W. Pass", "Louisiana", 8760922 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -67, "Cutler Farris Wharf", "Maine", 8411060 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -68, "Bar Harbor", "Maine", 8413320 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 43, -70, "Wells", "Maine", 8419317 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Chesapeake City", "Maryland", 8573927 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -76, "Tolchester Beach", "Maryland", 8573364 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Cambridge", "Maryland", 8571892 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Solomons Island", "Maryland", 8577330 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -76, "Bishops Head", "Maryland", 8571421 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Ocean City Inlet", "Maryland", 8570283 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -70, "Nantucket Island", "Massachusetts", 8449130 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -87, "Marquette C.G.", 9099018 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 45, -85, "Port Inland", 9087096 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -87, "Menominee", 9087088 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 43, -86, "Ludington", 9087023 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 42, -86, "Holland", 9087031 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 42, -82, "Algonac", 9014070 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 42, -82, "Mouth of the Black River", 9014090 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 43, -82, "Harbor Beach", 9075014 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 45, -83, "Alpena", 9075065 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 45, -83, "De Tour Village", "Michigan", 9075099 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -84, "Rock Cut", "Michigan", 9076024 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -84, "West Neebish Island", "Michigan", 9076027 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -84, "Little Rapids", "Michigan", 9076033 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -84, "SW Pier, St. Mary's River", "Michigan", 9076070 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -84, "Point Iroquois", "Michigan", 9099004 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -88, "Pascagoula NOAA Lab", "Mississippi", 8741533 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -74, "Cape May", "New Jersey", 8536110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Ship John Shoal", "New Jersey", 8537121 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Burlington, Delaware River", "New Jersey", 8539094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -73, "Kings Point", "New York", 8516945 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -75, "Alexandria Bay", "New York", 8311062 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 35, -75, "Oregon Inlet Marina", "North Carolina", 8652587 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 35, -75, "USCG Station Hatteras", "North Carolina", 8654467 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -76, "Beaufort", "North Carolina", 8656483 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wrightsville Beach", "North Carolina", 8658163 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wrightsville Beach", "North Carolina", 8658163 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -124, "South Beach", "Oregon", 9435380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Astoria", "Oregon", 9439040 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Newbold", "Pennsylvania", 8548989 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Quonset Point", "Rhode Island", 8454049 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Conimicut Light", "Rhode Island", 8452944 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Providence", "Rhode Island", 8454000 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -93, "Port Arthur", 8770475 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -93, "Sabine Pass North", 8770570 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -93, "Texas Point, Sabine Pass", 8770822 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -94, "Rollover Pass", 8770971 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -95, "Manchester", 8770777 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -94, "Morgans Point, Barbours Cut", 8770613 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -94, "Eagle Point, Galveston Bay", 8771013 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -94, "Galveston Bay Entrance, North Jetty", 8771341 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 29, -94, "Galveston Pier 21", 8771450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "Galveston Railroad Bridge", "Texas", 8771486 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -95, "Freeport SPIP, Freeport Harbor", "Texas", 8772471 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -95, "Sargent", "Texas", 8772985 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -95, "Matagorda City", "Texas", 8773146 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -96, "Port Lavaca", "Texas", 8773259 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -96, "Aransas Wildlife Refuge", "Texas", 8774230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -96, "Aransas Wildlife Refuge", "Texas", 8774230 });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[,]
                {
                    { 139, 27, -97, "Bob Hall Pier", "Texas", 8775870 },
                    { 140, 26, -97, "Port Isabel", "Texas", 8779770 },
                    { 141, 38, -77, "Dahlgren", "Virginia", 8635027 },
                    { 142, 37, -76, "Lewisetta", "Virginia", 8635750 },
                    { 143, 37, -75, "Wachapreague", "Virginia", 8631044 },
                    { 144, 37, -76, "Yorktown USCG Training Center", "Virginia", 8637689 },
                    { 145, 37, -75, "Kiptopeke", "Virginia", 8632200 },
                    { 146, 37, -76, "CBBT, Chesapeake Channel", "Virginia", 8638901 },
                    { 147, 36, -76, "Sewells Point", "Virginia", 8638610 },
                    { 148, 48, -123, "Friday Harbor", "Washington", 9449880 },
                    { 149, 48, -122, "Port Townsend", "Washington", 9444900 },
                    { 150, 48, -123, "Port Angeles", "Washington", 9444090 },
                    { 151, 47, -122, "Seattle", "Washington", 9447130 },
                    { 152, 47, -122, "Tacoma", "Washington", 9446484 }
                });
        }
    }
}
