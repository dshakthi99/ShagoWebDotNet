﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShagoWeb.Data;

#nullable disable

namespace ShagoWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241230054612_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShagoWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 12,
                            Name = "XXX"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 13,
                            Name = "YYY"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 10,
                            Name = "ZZZ"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 11,
                            Name = "FFF"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 19,
                            Name = "DDD"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
