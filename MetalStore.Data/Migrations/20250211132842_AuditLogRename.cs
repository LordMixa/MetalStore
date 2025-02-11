using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetalStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuditDateTime",
                table: "AuditLogs",
                newName: "AuditDateAndTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuditDateAndTime",
                table: "AuditLogs",
                newName: "AuditDateTime");
        }
    }
}
