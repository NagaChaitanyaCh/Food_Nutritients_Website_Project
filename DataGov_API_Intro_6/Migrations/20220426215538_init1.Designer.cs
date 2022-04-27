﻿// <auto-generated />
using System;
using DataGov_API_Intro_6.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataGov_API_Intro_6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220426215538_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Food_Item", b =>
                {
                    b.Property<Guid>("fdcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fdcId");

                    b.ToTable("Food_Items", (string)null);
                });

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Food_Nutrient", b =>
                {
                    b.Property<Guid>("fdcId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<Guid>("number")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(2);

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.HasKey("fdcId", "number");

                    b.HasIndex("number");

                    b.ToTable("Food_Nutrients", (string)null);
                });

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Nutrient", b =>
                {
                    b.Property<Guid>("number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nutrient_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("unitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("number");

                    b.ToTable("Nutrients", (string)null);
                });

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Food_Nutrient", b =>
                {
                    b.HasOne("DataGov_API_Intro_6.Models.Food_Item", "food_item")
                        .WithMany("foodNutrients")
                        .HasForeignKey("fdcId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataGov_API_Intro_6.Models.Nutrient", "nutrient")
                        .WithMany("foodNutrients")
                        .HasForeignKey("number")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("food_item");

                    b.Navigation("nutrient");
                });

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Food_Item", b =>
                {
                    b.Navigation("foodNutrients");
                });

            modelBuilder.Entity("DataGov_API_Intro_6.Models.Nutrient", b =>
                {
                    b.Navigation("foodNutrients");
                });
#pragma warning restore 612, 618
        }
    }
}