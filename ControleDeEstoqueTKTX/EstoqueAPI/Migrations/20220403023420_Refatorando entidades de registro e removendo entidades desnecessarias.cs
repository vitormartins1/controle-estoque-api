using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueAPI.Migrations
{
    public partial class Refatorandoentidadesderegistroeremovendoentidadesdesnecessarias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_VendaRetornada_VendaRetornadaId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "VendaRetornada");

            migrationBuilder.DropIndex(
                name: "IX_Item_VendaRetornadaId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "VendaRetornadaId",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaRetornadaId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VendaRetornada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaRetornada", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_VendaRetornadaId",
                table: "Item",
                column: "VendaRetornadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_VendaRetornada_VendaRetornadaId",
                table: "Item",
                column: "VendaRetornadaId",
                principalTable: "VendaRetornada",
                principalColumn: "Id");
        }
    }
}
