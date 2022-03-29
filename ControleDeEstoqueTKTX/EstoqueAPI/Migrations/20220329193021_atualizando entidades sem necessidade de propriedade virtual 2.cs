using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueAPI.Migrations
{
    public partial class atualizandoentidadessemnecessidadedepropriedadevirtual2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto",
                table: "ItemVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto_ProdutoId",
                table: "ItemVenda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto_ProdutoId",
                table: "ItemVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto",
                table: "ItemVenda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
