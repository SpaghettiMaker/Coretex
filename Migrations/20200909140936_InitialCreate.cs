using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coretex.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDate = table.Column<DateTime>(nullable: false),
                    VehicleName = table.Column<string>(nullable: true),
                    VehicleSpeed = table.Column<decimal>(nullable: false),
                    VehicleLatitude = table.Column<decimal>(nullable: false),
                    VehicleLongitude = table.Column<decimal>(nullable: false),
                    VehicleTemperature = table.Column<decimal>(nullable: false),
                    VehiclePressure = table.Column<decimal>(nullable: false),
                    DriverName = table.Column<string>(nullable: true),
                    DriverAddress = table.Column<string>(nullable: true),
                    DriverLicense = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
