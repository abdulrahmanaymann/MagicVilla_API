﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001003213_AddVillaNumberTable")]
    partial class AddVillaNumberTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Pool, Wi-Fi, Air Conditioning",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6414),
                            Details = "A luxury villa with all amenities and a beautiful ocean view.",
                            ImageUrl = "https://www.pexels.com/photo/white-concrete-house-near-body-of-water-210617/",
                            Name = "Luxury Villa",
                            Occupancy = 4,
                            Rate = 500.0,
                            Sqft = 2000,
                            UpdatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6474)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Fireplace, Wi-Fi, Hot Tub",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6481),
                            Details = "A cozy villa located in the mountains, perfect for nature lovers.",
                            ImageUrl = "https://www.pexels.com/photo/a-house-near-mountain-during-daytime-12905885/",
                            Name = "Mountain Villa",
                            Occupancy = 6,
                            Rate = 350.0,
                            Sqft = 1500,
                            UpdatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6483)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Pool, Wi-Fi, Ocean View",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6488),
                            Details = "A beachfront villa with direct access to the beach and stunning views.",
                            ImageUrl = "https://www.pexels.com/photo/aerial-view-of-beach-resort-2265876/",
                            Name = "Beachfront Villa",
                            Occupancy = 5,
                            Rate = 600.0,
                            Sqft = 2500,
                            UpdatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6490)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Gym, Wi-Fi, Rooftop Pool",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6494),
                            Details = "An urban villa located in the heart of the city with luxurious amenities.",
                            ImageUrl = "https://www.pexels.com/photo/modern-urban-house-with-pool-3639902/",
                            Name = "Urban Villa",
                            Occupancy = 3,
                            Rate = 450.0,
                            Sqft = 1800,
                            UpdatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6497)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Garden, Fireplace, Wi-Fi",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6501),
                            Details = "A peaceful villa surrounded by nature, perfect for a quiet retreat.",
                            ImageUrl = "https://www.pexels.com/photo/house-near-a-forest-1817857/",
                            Name = "Countryside Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 1600,
                            UpdatedDate = new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6503)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
