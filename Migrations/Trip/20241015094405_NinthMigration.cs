using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Trip
{
    /// <inheritdoc />
    public partial class NinthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripCustomerId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripDriver = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripStartDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripEndDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripFromLocation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripToLocation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripTotalDistance = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripAmount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripStatus = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripTrackingCode = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripCreatedBy = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
