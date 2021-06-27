﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPedidos.DAL;

namespace RegistroPedidos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RegistroPedidos.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.HasIndex("SuplidorId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistroPedidos.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("RegistroPedidos.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Inventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 10.0,
                            Descripcion = "Pan",
                            Inventario = 15
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 150.0,
                            Descripcion = "Café",
                            Inventario = 10
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 210.0,
                            Descripcion = "Cremola",
                            Inventario = 5
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 20.0,
                            Descripcion = "Azúcar",
                            Inventario = 17
                        },
                        new
                        {
                            ProductoId = 5,
                            Costo = 5.0,
                            Descripcion = "Chupeta",
                            Inventario = 25
                        });
                });

            modelBuilder.Entity("RegistroPedidos.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorId = 1,
                            Nombres = "Ernesto Juan"
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "Kamila Santos"
                        },
                        new
                        {
                            SuplidorId = 3,
                            Nombres = "Enel Brito"
                        },
                        new
                        {
                            SuplidorId = 4,
                            Nombres = "Robinson Manuel"
                        },
                        new
                        {
                            SuplidorId = 5,
                            Nombres = "Candy Sarante"
                        });
                });

            modelBuilder.Entity("RegistroPedidos.Models.Ordenes", b =>
                {
                    b.HasOne("RegistroPedidos.Models.Suplidores", "Suplidor")
                        .WithMany()
                        .HasForeignKey("SuplidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suplidor");
                });

            modelBuilder.Entity("RegistroPedidos.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistroPedidos.Models.Ordenes", null)
                        .WithMany("Detalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroPedidos.Models.Productos", "DetallesProducto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetallesProducto");
                });

            modelBuilder.Entity("RegistroPedidos.Models.Ordenes", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
