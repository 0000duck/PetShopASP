using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShopASP.Migrations
{
    public partial class PETSHOPBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 40, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 200, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    CEP = table.Column<string>(maxLength: 9, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(maxLength: 40, nullable: false),
                    Telefone = table.Column<string>(maxLength: 11, nullable: true),
                    Celular = table.Column<string>(maxLength: 12, nullable: false),
                    Email_primario = table.Column<string>(maxLength: 200, nullable: false),
                    Email_secundario = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 40, nullable: false),
                    Senha = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Email_suporte = table.Column<string>(maxLength: 200, nullable: false),
                    Cel = table.Column<string>(maxLength: 12, nullable: false),
                    Hierarquia = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 20, nullable: false),
                    Raca = table.Column<string>(maxLength: 20, nullable: false),
                    Especies = table.Column<int>(nullable: false),
                    Clientes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Clientes_Clientes",
                        column: x => x.Clientes,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Especies_Especies",
                        column: x => x.Especies,
                        principalTable: "Especies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_Clientes",
                table: "Pets",
                column: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_Especies",
                table: "Pets",
                column: "Especies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Especies");
        }
    }
}
