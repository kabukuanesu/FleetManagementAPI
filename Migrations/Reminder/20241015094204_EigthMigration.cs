using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagementAPI.Migrations.Reminder
{
    /// <inheritdoc />
    public partial class EigthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    ReminderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReminderCompanyId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReminderDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReminderMessage = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReminderIsRead = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReminderCreatedDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.ReminderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminders");
        }
    }
}
