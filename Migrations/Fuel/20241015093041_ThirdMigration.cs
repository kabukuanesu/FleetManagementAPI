using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Fuel
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    VehicleFuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRegistrationId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelQuantity = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    OdometerReading = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelPrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelFillDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelAddedBy = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelComments = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VehicleFuelCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.VehicleFuelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fuels");
        }
    }
}
