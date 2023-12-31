﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayingSpectre;

#nullable disable

namespace PlayingSpectre.Migrations
{
    [DbContext(typeof(CoffeeDBcontext))]
    [Migration("20230726021323_create-category-model")]
    partial class createcategorymodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("PlayingSpectre.Models.Coffee", b =>
                {
                    b.Property<int>("CoffeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCoffeeOfTheMonth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("CoffeeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Coffees");
                });
#pragma warning restore 612, 618
        }
    }
}
