using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_App_SPD311.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FootballTeams",
                columns: new[] { "Id", "Country", "Logo", "Name", "Players" },
                values: new object[,]
                {
                    { 1, "Spain", "https://upload.wikimedia.org/wikipedia/en/4/47/FC_Barcelona_%28crest%29.svg", "FC Barcelona", 26 },
                    { 2, "Spain", "https://upload.wikimedia.org/wikipedia/en/5/56/Real_Madrid_CF.svg", "Real Madrid", 25 },
                    { 3, "England", "https://upload.wikimedia.org/wikipedia/en/7/7a/Manchester_United_FC_crest.svg", "Manchester United", 24 },
                    { 4, "England", "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg", "Manchester City", 25 },
                    { 5, "England", "https://upload.wikimedia.org/wikipedia/en/0/0c/Liverpool_FC.svg", "Liverpool", 26 },
                    { 6, "France", "https://upload.wikimedia.org/wikipedia/en/a/a7/Paris_Saint-Germain_F.C..svg", "Paris Saint-Germain", 27 },
                    { 7, "Germany", "https://upload.wikimedia.org/wikipedia/en/c/c5/Bayern_Munich_logo_%282017%29.svg", "Bayern Munich", 25 },
                    { 8, "Germany", "https://upload.wikimedia.org/wikipedia/en/6/67/Borussia_Dortmund_logo.svg", "Borussia Dortmund", 24 },
                    { 9, "Italy", "https://upload.wikimedia.org/wikipedia/en/d/d2/Juventus_FC_2017_logo.svg", "Juventus", 26 },
                    { 10, "Italy", "https://upload.wikimedia.org/wikipedia/en/0/05/Inter_Milan_2021_logo.svg", "Inter Milan", 24 },
                    { 11, "Italy", "https://upload.wikimedia.org/wikipedia/commons/d/d0/Logo_of_AC_Milan.svg", "AC Milan", 25 },
                    { 12, "England", "https://upload.wikimedia.org/wikipedia/en/5/53/Arsenal_FC.svg", "Arsenal", 24 },
                    { 13, "England", "https://upload.wikimedia.org/wikipedia/en/c/cc/Chelsea_FC.svg", "Chelsea", 25 },
                    { 14, "Spain", "https://upload.wikimedia.org/wikipedia/en/f/f4/Atletico_Madrid_2017_logo.svg", "Atletico Madrid", 24 },
                    { 15, "Italy", "https://upload.wikimedia.org/wikipedia/en/2/28/SSC_Napoli.svg", "Napoli", 24 },
                    { 16, "Italy", "https://upload.wikimedia.org/wikipedia/en/0/04/AS_Roma_logo_%282017%29.svg", "AS Roma", 23 },
                    { 17, "England", "https://upload.wikimedia.org/wikipedia/en/b/b4/Tottenham_Hotspur.svg", "Tottenham Hotspur", 24 },
                    { 18, "Spain", "https://upload.wikimedia.org/wikipedia/en/8/86/Sevilla_FC_logo.svg", "Sevilla", 25 },
                    { 19, "Germany", "https://upload.wikimedia.org/wikipedia/en/a/a5/RB_Leipzig_2014_logo.svg", "RB Leipzig", 24 },
                    { 20, "Netherlands", "https://upload.wikimedia.org/wikipedia/en/7/7f/Ajax_Amsterdam.svg", "Ajax", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
