﻿// <auto-generated />
using System;
using Hotels.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotels.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231026125012_giomaricis2")]
    partial class giomaricis2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotels.Domain.entities.Namaste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Namastes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Namaste tbilis one of the best hotel",
                            ImgUrl = "https://placehold.co/600x400",
                            Name = "Namaste Tbilisi",
                            Occupancy = 6,
                            Price = 300.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Description = "Namaste Batumi one of the best hotel",
                            ImgUrl = "https://placehold.co/600x401",
                            Name = "Namaste Batumi",
                            Occupancy = 8,
                            Price = 400.0,
                            Sqft = 650
                        },
                        new
                        {
                            Id = 3,
                            Description = "Namaste Yazbegi one of the best hotel",
                            ImgUrl = "https://placehold.co/600x402",
                            Name = "Namaste Yazbegi",
                            Occupancy = 12,
                            Price = 700.0,
                            Sqft = 850
                        });
                });

            modelBuilder.Entity("Hotels.Domain.entities.NamasteNumber", b =>
                {
                    b.Property<int>("Namaste_Number")
                        .HasColumnType("int");

                    b.Property<int>("NamasteId")
                        .HasColumnType("int");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Namaste_Number");

                    b.HasIndex("NamasteId");

                    b.ToTable("NamasteNumbers");

                    b.HasData(
                        new
                        {
                            Namaste_Number = 101,
                            NamasteId = 15
                        },
                        new
                        {
                            Namaste_Number = 102,
                            NamasteId = 15
                        },
                        new
                        {
                            Namaste_Number = 103,
                            NamasteId = 15
                        },
                        new
                        {
                            Namaste_Number = 201,
                            NamasteId = 16
                        },
                        new
                        {
                            Namaste_Number = 202,
                            NamasteId = 16
                        },
                        new
                        {
                            Namaste_Number = 203,
                            NamasteId = 16
                        },
                        new
                        {
                            Namaste_Number = 301,
                            NamasteId = 17
                        },
                        new
                        {
                            Namaste_Number = 302,
                            NamasteId = 17
                        },
                        new
                        {
                            Namaste_Number = 303,
                            NamasteId = 17
                        });
                });

            modelBuilder.Entity("Hotels.Domain.entities.NamasteNumber", b =>
                {
                    b.HasOne("Hotels.Domain.entities.Namaste", "Namaste")
                        .WithMany()
                        .HasForeignKey("NamasteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Namaste");
                });
#pragma warning restore 612, 618
        }
    }
}