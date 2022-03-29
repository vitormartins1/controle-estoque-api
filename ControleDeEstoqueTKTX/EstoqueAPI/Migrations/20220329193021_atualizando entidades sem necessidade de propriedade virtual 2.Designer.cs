﻿// <auto-generated />
using System;
using Estoque.DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueAPI.Migrations
{
    [DbContext(typeof(EstoqueDbContext))]
    [Migration("20220329193021_atualizando entidades sem necessidade de propriedade virtual 2")]
    partial class atualizandoentidadessemnecessidadedepropriedadevirtual2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Estoque.DOMAIN.Diagrams.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("VARCHAR(35)");

                    b.HasKey("Id");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDeCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Invoice")
                        .HasMaxLength(43)
                        .HasColumnType("VARCHAR(43)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Compra", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Consignado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("RevendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RevendedorId");

                    b.ToTable("Consignado", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Entradas")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoNome")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeAtual")
                        .HasColumnType("int");

                    b.Property<int>("Saidas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estoque", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemConsignado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ConsignadoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsignadoId");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("ItemConsignado", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemDanificado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoteId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("ItemDanificado", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("LoteId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("LoteId");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("ItemEstoque", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemRetornado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("VendaRetornadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.HasIndex("VendaRetornadaId");

                    b.ToTable("ItemRetornado", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.HasIndex("VendaId");

                    b.ToTable("ItemVenda", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeBaixa")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("SMALLDATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("Lote", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("VARCHAR(450)");

                    b.Property<int?>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("ValorProduto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueId");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Revendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("VARCHAR(35)");

                    b.HasKey("Id");

                    b.ToTable("Revendedor", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroPedido")
                        .HasMaxLength(13)
                        .HasColumnType("VARCHAR(13)");

                    b.Property<int>("TipoVenda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Venda", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.VendaRetornada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VendaRetornada", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.VendaTeste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroPedido")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TipoVenda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("VendaTeste", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Diagrams.ItemVendaTeste", b =>
                {
                    b.HasBaseType("Estoque.DOMAIN.Diagrams.Item");

                    b.Property<int>("VendaTesteId")
                        .HasColumnType("int");

                    b.HasIndex("VendaTesteId");

                    b.ToTable("ItemVendaTeste", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Diagrams.Item", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Diagrams.Item", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Item_Produto");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Compra", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Fornecedor", null)
                        .WithMany("Compras")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Fornecedor_Compras");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Consignado", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Revendedor", null)
                        .WithMany("Consignados")
                        .HasForeignKey("RevendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Revendedor_Consignados");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemConsignado", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Consignado", null)
                        .WithMany("ItemConsignados")
                        .HasForeignKey("ConsignadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Consignado_ItemConsignados");

                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemConsignado", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemConsignado_Produto");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemDanificado", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemDanificado", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemDanificado_Produto");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemEstoque", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Compra", null)
                        .WithMany("ItemsEstoque")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Compra_ItemsEstoque");

                    b.HasOne("Estoque.DOMAIN.Models.Lote", null)
                        .WithMany("ItemsEstoque")
                        .HasForeignKey("LoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Lote_ItemsEstoque");

                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemEstoque", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemEstoque_Produto");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemRetornado", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemRetornado", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemRetornado_Produto");

                    b.HasOne("Estoque.DOMAIN.Models.VendaRetornada", null)
                        .WithMany("ItemRetornados")
                        .HasForeignKey("VendaRetornadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VendaRetornada_ItemRetornados");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemVenda", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Produto", null)
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemVenda", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estoque.DOMAIN.Models.Venda", null)
                        .WithMany("ItemVendas")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Venda_ItemVendas");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Lote", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Compra", null)
                        .WithMany("Lotes")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Compra_Lotes");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Produto", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Estoque", null)
                        .WithMany("Produtos")
                        .HasForeignKey("EstoqueId");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Cliente", null)
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Cliente_Vendas");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.VendaTeste", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Diagrams.ItemVendaTeste", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Diagrams.Item", null)
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Diagrams.ItemVendaTeste", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Estoque.DOMAIN.Models.VendaTeste", null)
                        .WithMany("ItemVendasTeste")
                        .HasForeignKey("VendaTesteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Cliente", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Compra", b =>
                {
                    b.Navigation("ItemsEstoque");

                    b.Navigation("Lotes");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Consignado", b =>
                {
                    b.Navigation("ItemConsignados");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Estoque", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Fornecedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Lote", b =>
                {
                    b.Navigation("ItemsEstoque");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Revendedor", b =>
                {
                    b.Navigation("Consignados");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.Navigation("ItemVendas");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.VendaRetornada", b =>
                {
                    b.Navigation("ItemRetornados");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.VendaTeste", b =>
                {
                    b.Navigation("ItemVendasTeste");
                });
#pragma warning restore 612, 618
        }
    }
}
