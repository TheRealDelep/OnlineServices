﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SandwichSystem.DataLayer;

namespace SandwichSystem.DataLayer.Migrations
{
    [DbContext(typeof(SandwichSystemContext))]
    [Migration("20191118155153_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SandwichSystem.DataLayer.Entities.IngredientEF", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAllergene")
                        .HasColumnType("bit");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("SandwichSystem.DataLayer.Entities.SandwichEF", b =>
                {
                    b.Property<int>("SandwichId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SandwichId");

                    b.ToTable("Sandwich");
                });

            modelBuilder.Entity("SandwichSystem.DataLayer.Entities.SandwichIngredient", b =>
                {
                    b.Property<int>("SandwichId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("SandwichId", "IngredientId");

                    b.ToTable("SandwichIngredients");
                });

            modelBuilder.Entity("SandwichSystem.DataLayer.Entities.SandwichIngredient", b =>
                {
                    b.HasOne("SandwichSystem.DataLayer.Entities.IngredientEF", "Ingredient")
                        .WithMany("SandwichIngredient")
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SandwichSystem.DataLayer.Entities.SandwichEF", "Sandwich")
                        .WithMany("SandwichIngredient")
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}