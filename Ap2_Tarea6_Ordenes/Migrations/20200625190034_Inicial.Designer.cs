﻿// <auto-generated />
using System;
using Ap2_Tarea6_Ordenes.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ap2_Tarea6_Ordenes.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200625190034_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Ap2_Tarea6_Ordenes.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Ap2_Tarea6_Ordenes.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("Ap2_Tarea6_Ordenes.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

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
                            Costo = 70m,
                            Descripcion = "Cereal",
                            Inventario = 6
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 25m,
                            Descripcion = "Coca-Cola",
                            Inventario = 20
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 50m,
                            Descripcion = "Pizza",
                            Inventario = 10
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 100m,
                            Descripcion = "Pastel",
                            Inventario = 4
                        });
                });

            modelBuilder.Entity("Ap2_Tarea6_Ordenes.Models.Suplidores", b =>
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
                            Nombres = "Nestle"
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "SuperCentro"
                        });
                });

            modelBuilder.Entity("Ap2_Tarea6_Ordenes.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("Ap2_Tarea6_Ordenes.Models.Ordenes", null)
                        .WithMany("OrdenDetalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}