using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations.URLShortener
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Guid",
                table: "Urls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urls_Guid",
                table: "Urls",
                column: "Guid",
                unique: true,
                filter: "[Guid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Urls_Guid",
                table: "Urls");

            migrationBuilder.AlterColumn<string>(
                name: "Guid",
                table: "Urls",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
