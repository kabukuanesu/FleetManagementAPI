using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerCompanyId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerMobileNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerIsActive = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CustomerModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
