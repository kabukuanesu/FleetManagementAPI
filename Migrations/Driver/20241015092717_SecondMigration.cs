using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Driver
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverCompanyId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverMobileNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverAge = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverLicenseNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverLicenseExpiryDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverTotalExperience = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverDateOfJoining = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverIsActive = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverCreatedBy = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DriverDocument = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
