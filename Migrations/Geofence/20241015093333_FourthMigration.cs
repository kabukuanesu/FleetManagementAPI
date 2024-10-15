using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Geofence
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Geofences",
                columns: table => new
                {
                    GeofenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeofenceName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GeofenceDescription = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GeofenceArea = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GeofenceVehicles = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GeofenceCreateDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GeofenceModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geofences", x => x.GeofenceId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Geofences");
        }
    }
}
