﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsBlazor.DAL;

#nullable disable

namespace ProductsBlazor.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20220305194543_UpdateModels2")]
    partial class UpdateModels2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("ProductsBlazor.Entidades.ProductoDetalles", b =>
                {
                    b.Property<int>("ProductoDetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Cantidad")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<float?>("Precio")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Presentacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoDetallesId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoDetalles");
                });

            modelBuilder.Entity("ProductsBlazor.Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaExpiracion")
                        .HasColumnType("TEXT");

                    b.Property<float>("Ganancia")
                        .HasColumnType("REAL");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<float>("ValorInventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProductsBlazor.Entidades.ProductoDetalles", b =>
                {
                    b.HasOne("ProductsBlazor.Entidades.Productos", null)
                        .WithMany("ProductoDetalles")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductsBlazor.Entidades.Productos", b =>
                {
                    b.Navigation("ProductoDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
