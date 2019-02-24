using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCiencias.Migrations
{
    public partial class RESET : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaServico",
                columns: table => new
                {
                    IdCategoriaServico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaServico", x => x.IdCategoriaServico);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    IdFornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.IdFornecedor);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    IdServico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCategoriaServico_fk = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.IdServico);
                    table.ForeignKey(
                        name: "FK_Servico_CategoriaServico_IdCategoriaServico_fk",
                        column: x => x.IdCategoriaServico_fk,
                        principalTable: "CategoriaServico",
                        principalColumn: "IdCategoriaServico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicoFornecedor",
                columns: table => new
                {
                    IdServicoFornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFornecedor_fk = table.Column<int>(nullable: false),
                    IdServico_fk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoFornecedor", x => x.IdServicoFornecedor);
                    table.ForeignKey(
                        name: "FK_ServicoFornecedor_Fornecedor_IdFornecedor_fk",
                        column: x => x.IdFornecedor_fk,
                        principalTable: "Fornecedor",
                        principalColumn: "IdFornecedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoFornecedor_Servico_IdServico_fk",
                        column: x => x.IdServico_fk,
                        principalTable: "Servico",
                        principalColumn: "IdServico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdCategoriaServico_fk",
                table: "Servico",
                column: "IdCategoriaServico_fk");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoFornecedor_IdFornecedor_fk",
                table: "ServicoFornecedor",
                column: "IdFornecedor_fk");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoFornecedor_IdServico_fk",
                table: "ServicoFornecedor",
                column: "IdServico_fk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicoFornecedor");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "CategoriaServico");
        }
    }
}
