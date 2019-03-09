using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations.URLShortener
{
    public partial class _09032019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "Urls",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Domain",
                table: "Urls");
        }
    }
}
