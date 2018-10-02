using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Lat", "Long", "Nickname", "State", "StationId" },
                values: new object[,]
                {
                    { 1, 31, -88, "Mobile State Docks", "Alabama", 8737048 },
                    { 30, 36, -76, "Money Point", "Virginia", 8639348 },
                    { 29, 29, -94, "High Island", "Texas", 8770808 },
                    { 28, 32, -79, "Charleston, Cooper River Entrance", "South Carolina", 8665530 },
                    { 27, 41, -71, "Newport", "Rhode Island", 8452660 },
                    { 26, 39, -75, "Marcus Hook", "Pennsylvania", 8540433 },
                    { 25, 42, -124, "Port Orford", "Oregon", 9431647 },
                    { 24, 41, -82, "Marblehead", "Ohio", 9063079 },
                    { 23, 34, -77, "Wilmington", "North Carolina", 8658120 },
                    { 22, 42, -73, "Turkey Point Hudson River", "New York", 8518962 },
                    { 21, 40, -74, "Sandy Hook", "New Jersey", 8531680 },
                    { 20, 43, -70, "Fort Point", "New Hampshire", 8423898 },
                    { 19, 31, -89, "Bay Waveland", "Mississippi", 8747437 },
                    { 18, 47, -90, "Grand Marais", "Minnesota", 9099090 },
                    { 17, 46, -92, "Duluth", "Minnesota", 9099064 },
                    { 16, 45, -84, "Mackinaw City", "Michigan", 9075080 },
                    { 15, 42, -71, "Boston", "Massachusetts", 8443970 },
                    { 14, 39, -76, "Baltimore, Fort McHenry", "Maryland", 8574680 },
                    { 13, 44, -66, "Eastport", "Maine", 8410140 },
                    { 12, 29, -92, "Freshwater Canal Locks", "Louisiana", 8766072 },
                    { 11, 41, -87, "Calumet Harbor", "Illinois", 9087044 },
                    { 10, 19, -155, "Hilo Bay", "Hawaii", 1617760 },
                    { 9, 32, -80, "Fort Pulaski", "Georgia", 8670870 },
                    { 8, 27, -82, "McKay Bay", "Florida", 8726667 },
                    { 7, 39, -75, "Delaware City", "Delaware", 8551762 },
                    { 6, 41, -72, "New London", "Connecticut", 8461490 },
                    { 5, 41, -124, "Crescent City", "California", 9419750 },
                    { 4, 61, -149, "Anchorage", "Alaska", 9455920 },
                    { 3, 30, -88, "Dauphin Island", "Alabama", 8735180 },
                    { 2, 30, -87, "Weeks Bay", "Alabama", 8732828 },
                    { 31, 46, -123, "Toke Point", "Washington", 9440910 },
                    { 32, 44, -88, "Green Bay", "Wisconsin", 9087079 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
