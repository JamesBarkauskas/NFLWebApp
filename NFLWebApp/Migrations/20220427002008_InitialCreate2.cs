using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFLWebApp.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Runningback",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Team = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Touchdowns = table.Column<int>(type: "int", nullable: false),
                    Yards = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runningback", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WideReceiver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Team = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Touchdowns = table.Column<int>(type: "int", nullable: false),
                    Yards = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WideReceiver", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Runningback");

            migrationBuilder.DropTable(
                name: "WideReceiver");
        }
    }
}
