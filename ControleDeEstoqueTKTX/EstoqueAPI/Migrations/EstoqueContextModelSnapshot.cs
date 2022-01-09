﻿// <auto-generated />
using Estoque.DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueAPI.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    partial class EstoqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Estoque.DOMAIN.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("VARCHAR(35)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("IdVenda")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto")
                        .IsUnique();

                    b.HasIndex("IdVenda");

                    b.ToTable("ItemVenda", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"), 1L, 1);

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeVendas")
                        .HasColumnType("int");

                    b.Property<double>("ValorProduto")
                        .HasColumnType("float");

                    b.HasKey("IdProduto");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenda"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroPedido")
                        .HasMaxLength(13)
                        .HasColumnType("VARCHAR(13)");

                    b.Property<int>("TipoVenda")
                        .HasColumnType("int");

                    b.HasKey("IdVenda");

                    b.HasIndex("IdCliente");

                    b.ToTable("Venda", (string)null);
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.ItemVenda", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Produto", "Produto")
                        .WithOne()
                        .HasForeignKey("Estoque.DOMAIN.Models.ItemVenda", "IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ItemVenda_Produto");

                    b.HasOne("Estoque.DOMAIN.Models.Venda", null)
                        .WithMany("ItemVendas")
                        .HasForeignKey("IdVenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Venda_ItemVendas");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.HasOne("Estoque.DOMAIN.Models.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Cliente_Vendas");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Cliente", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Estoque.DOMAIN.Models.Venda", b =>
                {
                    b.Navigation("ItemVendas");
                });
#pragma warning restore 612, 618
        }
    }
}
