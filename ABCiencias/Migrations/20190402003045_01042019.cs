using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations
{
    public partial class _01042019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DT_Criacao",
                table: "Urls",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "LogRequests",
                columns: table => new
                {
                    IdLogRequest = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserHostAddress = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Uri = table.Column<string>(nullable: true),
                    DateRequest = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogRequests", x => x.IdLogRequest);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogRequests");

            migrationBuilder.DropColumn(
                name: "DT_Criacao",
                table: "Urls");
        }
    }
}
