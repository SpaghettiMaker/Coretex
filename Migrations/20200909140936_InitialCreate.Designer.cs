﻿// <auto-generated />
using System;
using Coretex.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coretex.Migrations
{
    [DbContext(typeof(CoretexContext))]
    [Migration("20200909140936_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coretex.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VehicleLatitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VehicleLongitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VehicleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VehiclePressure")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VehicleSpeed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VehicleTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
