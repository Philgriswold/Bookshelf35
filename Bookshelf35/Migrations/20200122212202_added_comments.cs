using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class added_comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "433cda30-8b7a-4e11-af23-12f4c4596015", "AQAAAAEAACcQAAAAEMPt461ChPhXakLw0KkRrCJz5SP4D46r3aIYycn0T6267DQc0wPqZjA3yfWVfbs7aQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ffb526f-8eec-4eb7-968f-c6303a0ea57e", "AQAAAAEAACcQAAAAEM+AIQVt/gUXYRUTdtfm1lkVAEBRCgSLblb5znem5a6ZCw4Nizx+nuDM6RIPlwWAyA==" });
        }
    }
}
