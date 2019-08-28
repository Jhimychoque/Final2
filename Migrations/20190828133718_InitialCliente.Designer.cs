﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final.Models;

namespace final.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190828133718_InitialCliente")]
    partial class InitialCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("final.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("final.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Gmail");

                    b.Property<string>("Nombre");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("final.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaID");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Precio");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("final.Models.Product", b =>
                {
                    b.HasOne("final.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaID");
                });
#pragma warning restore 612, 618
        }
    }
}
