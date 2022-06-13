using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nationalHolidays.Migrations
{
    public partial class createDataBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RegiaoId",
                table: "Continente",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Continente_RegiaoId",
                table: "Continente",
                column: "RegiaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Regioes_RegiaoId",
                table: "Continente",
                column: "RegiaoId",
                principalTable: "Regioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Regioes_RegiaoId",
                table: "Continente");

            migrationBuilder.DropIndex(
                name: "IX_Continente_RegiaoId",
                table: "Continente");

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Continente");
        }
    }
}
