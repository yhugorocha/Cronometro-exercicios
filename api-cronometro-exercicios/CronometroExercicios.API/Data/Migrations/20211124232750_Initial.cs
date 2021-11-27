using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercicios.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    AtividadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Duracao = table.Column<int>(type: "INTEGER", nullable: false),
                    Repeticoes = table.Column<int>(type: "INTEGER", nullable: false),
                    TempoPreparacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Descanso = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.AtividadeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercicios");
        }
    }
}
