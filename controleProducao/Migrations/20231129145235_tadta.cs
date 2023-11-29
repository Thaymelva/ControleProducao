using Microsoft.EntityFrameworkCore.Migrations;

namespace controleProducao.Migrations
{
    public partial class tadta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Operacao",
                table: "Controle",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operacao",
                table: "Controle");
        }
    }
}
