﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaApi.Data;

#nullable disable

namespace VillaApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250206104043_seedVillaTableWithCreatedDate")]
    partial class seedVillaTableWithCreatedDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaApi.Models.VillaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 2, 6, 16, 10, 43, 413, DateTimeKind.Local).AddTicks(9273),
                            Details = " Russia is reportedly poised to begin serial production of a new derivative of the Iskander-M tactical ballistic missile with a range of 1,000 km. Reports about the existence of a 1,000 km range variant of the Iskander-M first surfaced in July 2024.",
                            ImageUrl = "https://www.eurasiantimes.com/wp-content/uploads/2022/03/Iskander-M.jpg?resize=696,464",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 2, 6, 16, 10, 43, 413, DateTimeKind.Local).AddTicks(9287),
                            Details = "The Iskander-M missile has a warhead that weighs between 710–800 kg. It is unlikely that the Iskander-1000 has a lighter warhead because a lighter warhead would not be effective against the types of high-value targets that the Iskander-M system is designed to attack.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                            Name = "Diamond Villa",
                            Occupancy = 3,
                            Rate = 200.0,
                            Sqft = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 2, 6, 16, 10, 43, 413, DateTimeKind.Local).AddTicks(9290),
                            Details = "In a big boost to the ‘Make in India’ initiative, the Defense Research and Development Organisation (DRDO) demonstrated its prowess by successfully testing the Very Short Range Air Defense System (VSHORAD).",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                            Name = "Platinum Villa",
                            Occupancy = 2,
                            Rate = 500.0,
                            Sqft = 1000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 2, 6, 16, 10, 43, 413, DateTimeKind.Local).AddTicks(9292),
                            Details = "VSHORADS is a fourth-generation Man Portable Air Defense System (MANPAD). In general, MANPADS are lightweight anti-aircraft weapons intended for rapid deployment by ground forces. They are cost-effective, compact, and mobile, requiring only a single operator for use.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                            Name = "Platinum Duper Villa",
                            Occupancy = 2,
                            Rate = 700.0,
                            Sqft = 1000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
