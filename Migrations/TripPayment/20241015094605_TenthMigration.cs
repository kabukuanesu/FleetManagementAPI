using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.TripPayment
{
    /// <inheritdoc />
    public partial class TenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripPayments",
                columns: table => new
                {
                    TripPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripPaymentTripId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripPaymentVehicleId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripPaymentAmount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripPaymentNotes = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TripPaymentCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPayments", x => x.TripPaymentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripPayments");
        }
    }
}
