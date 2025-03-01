using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_App_SPD311.Migrations
{
    /// <inheritdoc />
    public partial class Addplayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Players",
                table: "FootballTeams");

            migrationBuilder.CreateTable(
                name: "FootballPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayers_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FootballPlayers",
                columns: new[] { "Id", "Birthdate", "FirstName", "Goals", "LastName", "Number", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", 750, "Messi", 10, 6 },
                    { 2, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristiano", 800, "Ronaldo", 7, 9 },
                    { 3, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neymar", 350, "Jr", 11, 6 },
                    { 4, new DateTime(1998, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kylian", 250, "Mbappe", 7, 6 },
                    { 5, new DateTime(1988, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", 500, "Lewandowski", 9, 7 },
                    { 6, new DateTime(1991, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", 150, "De Bruyne", 17, 4 },
                    { 7, new DateTime(2000, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erling", 200, "Haaland", 9, 8 },
                    { 8, new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed", 300, "Salah", 11, 5 },
                    { 9, new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil", 50, "van Dijk", 4, 5 },
                    { 10, new DateTime(1986, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio", 100, "Ramos", 4, 6 },
                    { 11, new DateTime(1987, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karim", 400, "Benzema", 9, 2 },
                    { 12, new DateTime(1985, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luka", 120, "Modric", 10, 2 },
                    { 13, new DateTime(1993, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry", 350, "Kane", 10, 17 },
                    { 14, new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Son", 200, "Heung-min", 7, 17 },
                    { 15, new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruno", 180, "Fernandes", 8, 3 },
                    { 16, new DateTime(1997, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcus", 150, "Rashford", 10, 3 },
                    { 17, new DateTime(1991, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antoine", 250, "Griezmann", 7, 14 },
                    { 18, new DateTime(1993, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulo", 150, "Dybala", 21, 16 },
                    { 19, new DateTime(1993, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romelu", 250, "Lukaku", 9, 10 },
                    { 20, new DateTime(1995, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", 100, "Kimmich", 6, 7 },
                    { 21, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alphonso", 50, "Davies", 19, 7 },
                    { 22, new DateTime(2000, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jadon", 90, "Sancho", 25, 3 },
                    { 23, new DateTime(1995, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", 80, "Grealish", 10, 4 },
                    { 24, new DateTime(2000, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phil", 100, "Foden", 47, 4 },
                    { 25, new DateTime(2002, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedri", 50, "", 8, 1 },
                    { 26, new DateTime(2004, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gavi", 40, "", 30, 1 },
                    { 27, new DateTime(1999, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Declan", 60, "Rice", 41, 12 },
                    { 28, new DateTime(2003, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jude", 70, "Bellingham", 22, 2 },
                    { 29, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinicius", 90, "Jr", 20, 2 },
                    { 30, new DateTime(2002, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eduardo", 50, "Camavinga", 12, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayers_TeamId",
                table: "FootballPlayers",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballPlayers");

            migrationBuilder.AddColumn<int>(
                name: "Players",
                table: "FootballTeams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Players",
                value: 26);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 3,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 4,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 5,
                column: "Players",
                value: 26);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 6,
                column: "Players",
                value: 27);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 7,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 8,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 9,
                column: "Players",
                value: 26);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 10,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 11,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 12,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 13,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 14,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 15,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 16,
                column: "Players",
                value: 23);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 17,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 18,
                column: "Players",
                value: 25);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 19,
                column: "Players",
                value: 24);

            migrationBuilder.UpdateData(
                table: "FootballTeams",
                keyColumn: "Id",
                keyValue: 20,
                column: "Players",
                value: 25);
        }
    }
}
