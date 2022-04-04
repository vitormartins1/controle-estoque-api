using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueAPI.Migrations
{
    public partial class Removendoregistroentradaesaidaedeixandoapenasregistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistroId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_RegistroId",
                table: "Item",
                column: "RegistroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Registro_RegistroId",
                table: "Item",
                column: "RegistroId",
                principalTable: "Registro",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Registro_RegistroId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropIndex(
                name: "IX_Item_RegistroId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "RegistroId",
                table: "Item");
        }
    }
}
