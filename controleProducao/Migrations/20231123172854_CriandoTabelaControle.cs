using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace controleProducao.Migrations
{
    public partial class CriandoTabelaControle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Controle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TempoMinutos = table.Column<int>(type: "int", nullable: false),
                    Maquina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Operador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdemProducao = table.Column<int>(type: "int", nullable: false),
                    QuantidadeProduzida = table.Column<int>(type: "int", nullable: false),
                    QuantidadePerdida = table.Column<int>(type: "int", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observação = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Controle");
        }
    }
}
