﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Otelim.Context;

#nullable disable

namespace Otelim.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20221223083551_creatingtable")]
    partial class creatingtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Otelim.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<int>("AccTypeId")
                        .HasColumnType("int");

                    b.Property<string>("HotelAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ThemeId")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Otelim.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentTypeId"), 1L, 1);

                    b.Property<string>("PaymentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("Otelim.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserFname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserLname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numOfAdult")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Otelim.Models.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThemeId"), 1L, 1);

                    b.Property<string>("ThemeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Otelim.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserGender")
                        .HasColumnType("int");

                    b.Property<string>("UserLname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
