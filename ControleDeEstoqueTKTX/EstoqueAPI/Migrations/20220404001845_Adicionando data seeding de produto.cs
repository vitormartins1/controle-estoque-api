using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueAPI.Migrations
{
    public partial class Adicionandodataseedingdeproduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Registro_RegistroId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_RegistroId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "RegistroId",
                table: "Item");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeRegistro",
                table: "Registro",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DescricaoProduto", "EstoqueId", "NomeProduto", "ValorProduto" },
                values: new object[,]
                {
                    { 1, "Brinquedo do heroi max stell.", null, "Max Stell", 67.0 },
                    { 2, "Brinquedo de carrinhos do parque dos tubarões.", null, "Hot Weels Parque dos Tubarões.", 189.0 },
                    { 3, "Miniatura do jogo de video game dark souls.", null, "Miniatura Dark Souls", 399.0 },
                    { 4, "Raquete para matar moscas e mosquitos.", null, "Raquete elétrica", 19.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Registro_Itens",
                table: "Item",
                column: "Id",
                principalTable: "Registro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registro_Itens",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDeRegistro",
                table: "Registro",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "RegistroId",
                table: "Item",
                type: "int",
                nullable: true);

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
    }
}
