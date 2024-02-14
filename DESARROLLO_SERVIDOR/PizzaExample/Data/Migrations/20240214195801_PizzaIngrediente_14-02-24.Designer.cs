﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaExample.Data;

#nullable disable

namespace PizzaExample.Data.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20240214195801_PizzaIngrediente_14-02-24")]
    partial class PizzaIngrediente_140224
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PizzaExample.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Calorias")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calorias = 34,
                            Name = "Peperoni",
                            Origen = "Animal",
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Calorias = 56,
                            Name = "Queso",
                            Origen = "Animal",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 3,
                            Calorias = 27,
                            Name = "Jamon",
                            Origen = "Animal",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 4,
                            Calorias = 4,
                            Name = "Oregano",
                            Origen = "Vegetal",
                            PizzaId = 1
                        });
                });

            modelBuilder.Entity("PizzaExample.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsGlutenFree")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsGlutenFree = false,
                            Name = "Peperoni"
                        },
                        new
                        {
                            Id = 2,
                            IsGlutenFree = false,
                            Name = "Jamon y queso"
                        });
                });

            modelBuilder.Entity("PizzaExample.Models.PizzaIngrediente", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "IngredienteId");

                    b.HasIndex("IngredienteId");

                    b.ToTable("PizzaIngrediente");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            IngredienteId = 1
                        },
                        new
                        {
                            PizzaId = 1,
                            IngredienteId = 2
                        },
                        new
                        {
                            PizzaId = 2,
                            IngredienteId = 3
                        },
                        new
                        {
                            PizzaId = 2,
                            IngredienteId = 1
                        },
                        new
                        {
                            PizzaId = 1,
                            IngredienteId = 4
                        });
                });

            modelBuilder.Entity("PizzaExample.Models.PizzaIngrediente", b =>
                {
                    b.HasOne("PizzaExample.Models.Ingrediente", "Ingrediente")
                        .WithMany("PizzaIngredientes")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaExample.Models.Pizza", "Pizza")
                        .WithMany("PizzaIngredientes")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("PizzaExample.Models.Ingrediente", b =>
                {
                    b.Navigation("PizzaIngredientes");
                });

            modelBuilder.Entity("PizzaExample.Models.Pizza", b =>
                {
                    b.Navigation("PizzaIngredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
