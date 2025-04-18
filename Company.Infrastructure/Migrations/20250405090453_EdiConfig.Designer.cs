﻿// <auto-generated />
using System;
using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250405090453_EdiConfig")]
    partial class EdiConfig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Company.Domain.Entity.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2025, 4, 5, 10, 4, 53, 252, DateTimeKind.Local).AddTicks(8507),
                            Description = "It's me",
                            Name = "Aynaz",
                            UpdateDate = new DateTime(2025, 4, 5, 9, 4, 53, 252, DateTimeKind.Utc).AddTicks(8499)
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2025, 4, 5, 10, 4, 53, 252, DateTimeKind.Local).AddTicks(8588),
                            Description = "It's my sister",
                            Name = "Elnaz",
                            UpdateDate = new DateTime(2025, 4, 5, 9, 4, 53, 252, DateTimeKind.Utc).AddTicks(8586)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
