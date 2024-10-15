using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.MoneyFlow
{
    /// <inheritdoc />
    public partial class SixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoneyFlows",
                columns: table => new
                {
                    MoneyFlowId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowCompanyId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowDescription = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowAmount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoneyFlowModifiedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyFlows", x => x.MoneyFlowId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyFlows");
        }
    }
}
