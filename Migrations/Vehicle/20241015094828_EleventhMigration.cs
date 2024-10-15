using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Vehicle
{
    /// <inheritdoc />
    public partial class EleventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRegistrationNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleChassisNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleEngineNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleManufacturedBy = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleColor = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleMilagePerLitre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleIsActive = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleRegistrationExpiryDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleCreatedBy = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
