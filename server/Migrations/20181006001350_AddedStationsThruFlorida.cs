using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class AddedStationsThruFlorida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 30, "Coast Guard Sector", 8736897 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -88, "Dauphin Island", 8735180 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 70, -148, "Prudhoe Bay", "Alaska", 9497645 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 30, -87, "Pensacola", 8729840 });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[,]
                {
                    { 63, 33, -118, "Los Angeles", "California", 9410660 },
                    { 64, 32, -117, "La Jolla", "California", 9410230 },
                    { 65, 32, -117, "San Diego", "California", 9410170 },
                    { 66, 41, -72, "New Haven", "Connecticut", 8465705 },
                    { 67, 41, -73, "Bridgeport", "Connecticut", 8467150 },
                    { 68, 39, -75, "Ready Point", "Delaware", 8551910 },
                    { 69, 38, -75, "Brandywine Shoal Light", "Delaware", 8555889 },
                    { 70, 38, -75, "Lewes", "Delaware", 8557380 },
                    { 71, 30, -85, "Panama City Beach", "Florida", 8729210 },
                    { 72, 30, -85, "Panama City", "Florida", 8729108 },
                    { 73, 29, -84, "Apalachicola", "Florida", 8728690 },
                    { 74, 30, -81, "Fernandina Beach", "Florida", 8720030 },
                    { 76, 29, -81, "Racy Point, St. Johns River", "Florida", 8720625 },
                    { 62, 34, -118, "Santa Monica", "California", 9410840 },
                    { 77, 29, -83, "Cedar Key", "Florida", 8727520 },
                    { 78, 28, -80, "Trident Pier, Port Canaveral", "Florida", 8721604 },
                    { 79, 27, -82, "Clearwater Beach", "Florida", 8726724 },
                    { 80, 27, -82, "Old Port Tampa", "Florida", 8726607 },
                    { 81, 27, -82, "St. Petersburg, Tampa Bay", "Florida", 8726520 },
                    { 82, 27, -82, "Port Manatee", "Florida", 8726384 },
                    { 83, 26, -81, "Fort Myers, Caloosahatchee River", "Florida", 8725520 },
                    { 84, 26, -80, "Lake Worth Pier, Atlantic Ocean", "Florida", 8722670 },
                    { 85, 26, -81, "Naples, Gulf of Mexico", "Florida", 8725110 },
                    { 86, 26, -80, "South Port Everglades", "Florida", 8722956 },
                    { 87, 25, -80, "Virginia Key, Biscayne Bay", "Florida", 8723214 },
                    { 75, 30, -81, "Mayport, Bar Pilots Dock", "Florida", 8720218 },
                    { 61, 34, -119, "Santa Barbara", "California", 9411340 },
                    { 59, 35, -120, "Port San Luis", "California", 9412110 },
                    { 88, 24, -81, "Vaca Key, Florida Bay", "Florida", 8723970 },
                    { 33, 67, -164, "Red Dog Dock", "Alaska", 9491094 },
                    { 34, 64, -165, "Nome, Norton Sound", "Alaska", 9468756 },
                    { 35, 63, -160, "Unalakleet", "Alaska", 9468333 },
                    { 36, 60, -145, "Cordova", "Alaska", 9454050 },
                    { 37, 61, -146, "Valdez", "Alaska", 9454240 },
                    { 38, 60, -151, "Nikiski", "Alaska", 9455760 },
                    { 39, 59, -151, "Seldovia", "Alaska", 9455500 },
                    { 40, 57, -152, "Kodiak Island", "Alaska", 9457292 },
                    { 41, 56, -154, "Alitak", "Alaska", 9457804 },
                    { 42, 55, -160, "Port Moller", "Alaska", 9463502 },
                    { 43, 55, -160, "Sand Point", "Alaska", 9459450 },
                    { 44, 55, -162, "King Cove", "Alaska", 9459881 },
                    { 60, 34, -120, "Oil Platform Harvest", "California", 9411406 },
                    { 45, 53, -166, "Unalaska", "Alaska", 9462620 },
                    { 47, 52, -168, "Nikolski", "Alaska", 9462450 },
                    { 48, 52, -174, "Atka", "Alaska", 9461710 },
                    { 49, 51, -176, "Adak Island", "Alaska", 9461380 },
                    { 50, 40, -124, "North Spit", "California", 9418767 },
                    { 51, 38, -123, "Arena Cove", "California", 9416841 },
                    { 52, 37, -122, "Point Reyes", "California", 9415020 },
                    { 53, 38, -122, "Port Chicago", "California", 9415144 },
                    { 54, 38, -122, "Martinez-Amorco Pier", "California", 9415102 },
                    { 55, 37, -122, "San Francisco", "California", 9414290 },
                    { 56, 37, -122, "Alameda", "California", 9414750 },
                    { 57, 37, -122, "Redwood City", "California", 9414523 },
                    { 58, 36, -121, "Monterey", "California", 9413450 },
                    { 46, 57, -170, "Village Cove, St. Paul Island", "Alaska", 9464212 },
                    { 89, 24, -81, "Key West", "Florida", 8724580 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 70);

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
                keyValue: 1,
                columns: new[] { "Lat", "Nickname", "StationId" },
                values: new object[] { 31, "Mobile State Docks", 8737048 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Long", "Nickname", "StationId" },
                values: new object[] { -87, "Weeks Bay", 8732828 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[] { 30, -88, "Dauphin Island", "Alabama", 8735180 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Lat", "Long", "Nickname", "StationId" },
                values: new object[] { 27, -82, "McKay Bay", 8726667 });
        }
    }
}
