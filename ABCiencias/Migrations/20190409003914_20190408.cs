using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations
{
    public partial class _20190408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrlShortener_fk",
                table: "LogRequests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogRequests_UrlShortener_fk",
                table: "LogRequests",
                column: "UrlShortener_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_LogRequests_Urls_UrlShortener_fk",
                table: "LogRequests",
                column: "UrlShortener_fk",
                principalTable: "Urls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogRequests_Urls_UrlShortener_fk",
                table: "LogRequests");

            migrationBuilder.DropIndex(
                name: "IX_LogRequests_UrlShortener_fk",
                table: "LogRequests");

            migrationBuilder.DropColumn(
                name: "UrlShortener_fk",
                table: "LogRequests");
        }
    }
}
