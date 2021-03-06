﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyleasingWeb.Data;

namespace MyleasingWeb.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("LesseeId");

                    b.Property<int?>("Ownerid");

                    b.Property<decimal>("Price");

                    b.Property<int?>("PropertyId");

                    b.Property<string>("Remarks")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("LesseeId");

                    b.HasIndex("Ownerid");

                    b.HasIndex("PropertyId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Lessee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("CellPhone")
                        .HasMaxLength(20);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FixedPhone")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("HasParkingLot");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Ownerid");

                    b.Property<decimal>("Price");

                    b.Property<int?>("PropertyTypeId");

                    b.Property<string>("Remarks");

                    b.Property<int>("Rooms");

                    b.Property<int>("SquareMeters");

                    b.Property<int>("Stratum");

                    b.HasKey("Id");

                    b.HasIndex("Ownerid");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Propesties");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.PropertyImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<int?>("PropertyId");

                    b.Property<int?>("propertyImagesId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("propertyImagesId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PropertyType");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Contract", b =>
                {
                    b.HasOne("MyleasingWeb.Data.Entities.Lessee", "Lessee")
                        .WithMany("Contracts")
                        .HasForeignKey("LesseeId");

                    b.HasOne("MyleasingWeb.Data.Entities.Owner", "Owner")
                        .WithMany("Contracts")
                        .HasForeignKey("Ownerid");

                    b.HasOne("MyleasingWeb.Data.Entities.Property", "Property")
                        .WithMany("contracts")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.Property", b =>
                {
                    b.HasOne("MyleasingWeb.Data.Entities.Owner", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("Ownerid");

                    b.HasOne("MyleasingWeb.Data.Entities.PropertyType", "PropertyType")
                        .WithMany("properties")
                        .HasForeignKey("PropertyTypeId");
                });

            modelBuilder.Entity("MyleasingWeb.Data.Entities.PropertyImages", b =>
                {
                    b.HasOne("MyleasingWeb.Data.Entities.Property", "Property")
                        .WithMany("propertyImages")
                        .HasForeignKey("PropertyId");

                    b.HasOne("MyleasingWeb.Data.Entities.PropertyImages", "propertyImages")
                        .WithMany()
                        .HasForeignKey("propertyImagesId");
                });
#pragma warning restore 612, 618
        }
    }
}
