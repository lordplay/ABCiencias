using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations
{
    public partial class _20190406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "ServicoFornecedor",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Nota",
                table: "ServicoFornecedor",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "ServicoFornecedor",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Cadastro",
                table: "Fornecedor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "ServicoFornecedor");

            migrationBuilder.DropColumn(
                name: "Nota",
                table: "ServicoFornecedor");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "ServicoFornecedor");

            migrationBuilder.DropColumn(
                name: "Data_Cadastro",
                table: "Fornecedor");
        }
    }
}
