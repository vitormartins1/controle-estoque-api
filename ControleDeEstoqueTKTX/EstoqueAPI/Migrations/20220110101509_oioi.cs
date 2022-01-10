using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueAPI.Migrations
{
    public partial class oioi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFornecedor = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ValorProduto = table.Column<double>(type: "float", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false),
                    QuantidadeVendas = table.Column<int>(type: "int", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "VARCHAR(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "VendaRetornada",
                columns: table => new
                {
                    IdVendaRetornada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaRetornada", x => x.IdVendaRetornada);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<string>(type: "VARCHAR(13)", maxLength: 13, nullable: true),
                    IdCliente = table.Column<int>(type: "integer", nullable: false),
                    TipoVenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_Cliente_Vendas",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice = table.Column<string>(type: "VARCHAR(43)", maxLength: 43, nullable: true),
                    IdFornecedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Compras",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDanificado",
                columns: table => new
                {
                    IdItemDanificado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenda = table.Column<int>(type: "int", nullable: true),
                    IdLote = table.Column<int>(type: "int", nullable: true),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDanificado", x => x.IdItemDanificado);
                    table.ForeignKey(
                        name: "FK_ItemDanificado_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemRetornado",
                columns: table => new
                {
                    IdItemRetornado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVendaRetornada = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRetornado", x => x.IdItemRetornado);
                    table.ForeignKey(
                        name: "FK_ItemRetornado_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaRetornada_ItemRetornados",
                        column: x => x.IdVendaRetornada,
                        principalTable: "VendaRetornada",
                        principalColumn: "IdVendaRetornada",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenda = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venda_ItemVendas",
                        column: x => x.IdVenda,
                        principalTable: "Venda",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lote",
                columns: table => new
                {
                    LoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    DataDeEntrada = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lote", x => x.LoteId);
                    table.ForeignKey(
                        name: "FK_Compra_Lotes",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemEstoque",
                columns: table => new
                {
                    ItemEstoqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoteId = table.Column<int>(type: "int", nullable: false),
                    IdCompra = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemEstoque", x => x.ItemEstoqueId);
                    table.ForeignKey(
                        name: "FK_Compra_ItemsEstoque",
                        column: x => x.IdCompra,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemEstoque_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lote_ItemsEstoque",
                        column: x => x.LoteId,
                        principalTable: "Lote",
                        principalColumn: "LoteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IdFornecedor",
                table: "Compra",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDanificado_IdProduto",
                table: "ItemDanificado",
                column: "IdProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemEstoque_IdCompra",
                table: "ItemEstoque",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_ItemEstoque_IdProduto",
                table: "ItemEstoque",
                column: "IdProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemEstoque_LoteId",
                table: "ItemEstoque",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetornado_IdProduto",
                table: "ItemRetornado",
                column: "IdProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemRetornado_IdVendaRetornada",
                table: "ItemRetornado",
                column: "IdVendaRetornada");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_IdProduto",
                table: "ItemVenda",
                column: "IdProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_IdVenda",
                table: "ItemVenda",
                column: "IdVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Lote_CompraId",
                table: "Lote",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_IdCliente",
                table: "Venda",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDanificado");

            migrationBuilder.DropTable(
                name: "ItemEstoque");

            migrationBuilder.DropTable(
                name: "ItemRetornado");

            migrationBuilder.DropTable(
                name: "ItemVenda");

            migrationBuilder.DropTable(
                name: "Lote");

            migrationBuilder.DropTable(
                name: "VendaRetornada");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
