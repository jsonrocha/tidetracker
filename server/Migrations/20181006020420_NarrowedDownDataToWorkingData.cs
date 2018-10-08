using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class NarrowedDownDataToWorkingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -149, "Anchorage", 9455920 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -124, "Crescent City", "California", 9419750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Long", "Nickname", "State", "StationId" },
                values: new object[] { -72, "New London", "Connecticut", 8461490 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Delaware City", "Delaware", 8551762 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -87, "Pensacola", "Florida", 8729840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -80, "Fort Pulaski", "Georgia", 8670870 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 19, -155, "Hilo Bay", "Hawaii", 1617760 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -87, "Calumet Harbor", "Illinois", 9087044 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -92, "Freshwater Canal Locks", "Louisiana", 8766072 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -66, "Eastport", "Maine", 8410140 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -76, "Baltimore, Fort McHenry", "Maryland", 8574680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -71, "Boston", "Massachusetts", 8443970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 45, -84, "Mackinaw City", "Michigan", 9075080 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -92, "Duluth", "Minnesota", 9099064 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 47, -90, "Grand Marais", 9099090 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 31, -89, "Bay Waveland", "Mississippi", 8747437 });

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
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", "Alaska", 9491094 });

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
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -160, "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -160, "Sand Point", 9459450 });

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
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 51, -176, "Adak Island", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", "California", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "Point Reyes", "California", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -122, "Port Chicago", "California", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -122, "Martinez-Amorco Pier", "California", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "San Francisco", "California", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "Alameda", "California", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "Redwood City", "California", 9414523 });

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
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 32, -117, "La Jolla", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -72, "New Haven", "Connecticut", 8465705 });

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
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Brandywine Shoal Light", "Delaware", 8555889 });

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
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -85, "Panama City Beach", "Florida", 8729210 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -85, "Panama City", "Florida", 8729108 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -84, "Apalachicola", "Florida", 8728690 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -81, "Fernandina Beach", "Florida", 8720030 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -81, "Mayport, Bar Pilots Dock", "Florida", 8720218 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -83, "Cedar Key", "Florida", 8727520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 28, -80, "Trident Pier, Port Canaveral", "Florida", 8721604 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 27, -82, "Clearwater Beach", "Florida", 8726724 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 27, -82, "Old Port Tampa", "Florida", 8726607 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 27, -82, "St. Petersburg, Tampa Bay", "Florida", 8726520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 26, -81, "Fort Myers, Caloosahatchee River", "Florida", 8725520 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 26, -80, "Lake Worth Pier, Atlantic Ocean", "Florida", 8722670 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 25, -80, "Virginia Key, Biscayne Bay", "Florida", 8723214 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 24, -81, "Vaca Key, Florida Bay", "Florida", 8723970 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 70, -148, "Prudhoe Bay", 9497645 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 61, -149, "Anchorage", "Alaska", 9455920 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Long", "Nickname", "State", "StationId" },
                values: new object[] { -124, "Crescent City", "California", 9419750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -72, "New London", "Connecticut", 8461490 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Delaware City", "Delaware", 8551762 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -87, "Pensacola", "Florida", 8729840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -80, "Fort Pulaski", "Georgia", 8670870 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 19, -155, "Hilo Bay", "Hawaii", 1617760 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -87, "Calumet Harbor", "Illinois", 9087044 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -92, "Freshwater Canal Locks", "Louisiana", 8766072 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -66, "Eastport", "Maine", 8410140 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -76, "Baltimore, Fort McHenry", "Maryland", 8574680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -71, "Boston", "Massachusetts", 8443970 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 45, -84, "Mackinaw City", "Michigan", 9075080 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 46, -92, "Duluth", 9099064 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 47, -90, "Grand Marais", "Minnesota", 9099090 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 31, -89, "Bay Waveland", "Mississippi", 8747437 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 43, -70, "Fort Point", "New Hampshire", 8423898 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 40, -74, "Sandy Hook", "New Jersey", 8531680 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -73, "Turkey Point Hudson River", "New York", 8518962 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -77, "Wilmington", "North Carolina", 8658120 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -82, "Marblehead", "Ohio", 9063079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 42, -124, "Port Orford", "Oregon", 9431647 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Marcus Hook", "Pennsylvania", 8540433 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -71, "Newport", "Rhode Island", 8452660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 29, -94, "High Island", "Texas", 8770808 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -76, "Money Point", "Virginia", 8639348 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 46, -123, "Toke Point", "Washington", 9440910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 44, -88, "Green Bay", "Wisconsin", 9087079 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 67, -164, "Red Dog Dock", 9491094 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 64, -165, "Nome, Norton Sound", 9468756 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 63, -160, "Unalakleet", 9468333 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -145, "Cordova", 9454050 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 61, -146, "Valdez", 9454240 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 60, -151, "Nikiski", 9455760 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 59, -151, "Seldovia", 9455500 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 57, -152, "Kodiak Island", 9457292 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 56, -154, "Alitak", 9457804 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 55, -160, "Port Moller", 9463502 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 55, -160, "Sand Point", "Alaska", 9459450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 55, -162, "King Cove", "Alaska", 9459881 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 53, -166, "Unalaska", "Alaska", 9462620 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 57, -170, "Village Cove, St. Paul Island", "Alaska", 9464212 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 52, -168, "Nikolski", "Alaska", 9462450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 52, -174, "Atka", "Alaska", 9461710 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 51, -176, "Adak Island", "Alaska", 9461380 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 40, -124, "North Spit", 9418767 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 38, -123, "Arena Cove", 9416841 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 37, -122, "Point Reyes", 9415020 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -122, "Port Chicago", "California", 9415144 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -122, "Martinez-Amorco Pier", "California", 9415102 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "San Francisco", "California", 9414290 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "Alameda", "California", 9414750 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 37, -122, "Redwood City", "California", 9414523 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 36, -121, "Monterey", "California", 9413450 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 35, -120, "Port San Luis", "California", 9412110 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -120, "Oil Platform Harvest", "California", 9411406 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -119, "Santa Barbara", "California", 9411340 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 34, -118, "Santa Monica", "California", 9410840 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 33, -118, "Los Angeles", "California", 9410660 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -117, "La Jolla", "California", 9410230 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 32, -117, "San Diego", "California", 9410170 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -72, "New Haven", "Connecticut", 8465705 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 41, -73, "Bridgeport", "Connecticut", 8467150 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 39, -75, "Ready Point", "Delaware", 8551910 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Brandywine Shoal Light", "Delaware", 8555889 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 38, -75, "Lewes", "Delaware", 8557380 });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[,]
                {
                    { 87, 25, -80, "Virginia Key, Biscayne Bay", "Florida", 8723214 },
                    { 86, 26, -80, "South Port Everglades", "Florida", 8722956 },
                    { 85, 26, -81, "Naples, Gulf of Mexico", "Florida", 8725110 },
                    { 84, 26, -80, "Lake Worth Pier, Atlantic Ocean", "Florida", 8722670 },
                    { 83, 26, -81, "Fort Myers, Caloosahatchee River", "Florida", 8725520 },
                    { 82, 27, -82, "Port Manatee", "Florida", 8726384 },
                    { 81, 27, -82, "St. Petersburg, Tampa Bay", "Florida", 8726520 },
                    { 80, 27, -82, "Old Port Tampa", "Florida", 8726607 },
                    { 79, 27, -82, "Clearwater Beach", "Florida", 8726724 },
                    { 78, 28, -80, "Trident Pier, Port Canaveral", "Florida", 8721604 },
                    { 77, 29, -83, "Cedar Key", "Florida", 8727520 },
                    { 76, 29, -81, "Racy Point, St. Johns River", "Florida", 8720625 },
                    { 75, 30, -81, "Mayport, Bar Pilots Dock", "Florida", 8720218 },
                    { 74, 30, -81, "Fernandina Beach", "Florida", 8720030 },
                    { 73, 29, -84, "Apalachicola", "Florida", 8728690 },
                    { 72, 30, -85, "Panama City", "Florida", 8729108 },
                    { 71, 30, -85, "Panama City Beach", "Florida", 8729210 },
                    { 88, 24, -81, "Vaca Key, Florida Bay", "Florida", 8723970 },
                    { 89, 24, -81, "Key West", "Florida", 8724580 }
                });
        }
    }
}
