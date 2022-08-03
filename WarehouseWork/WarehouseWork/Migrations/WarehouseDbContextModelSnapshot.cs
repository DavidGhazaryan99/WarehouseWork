﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseWork.Data;

namespace WarehouseWork.Migrations
{
    [DbContext(typeof(WarehouseDbContext))]
    partial class WarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WarehouseWork.Models.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WarehouseWork.Models.Manufactured", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("countryid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("countryid");

                    b.ToTable("Manufactureds");
                });

            modelBuilder.Entity("WarehouseWork.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("LastDiscountsDependingSeasonDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDiscountsDependingSeasonDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<float>("discountPercentage")
                        .HasColumnType("real");

                    b.Property<int>("manufacturedid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("registrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("manufacturedid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseWork.Models.Manufactured", b =>
                {
                    b.HasOne("WarehouseWork.Models.Country", "country")
                        .WithMany()
                        .HasForeignKey("countryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WarehouseWork.Models.Product", b =>
                {
                    b.HasOne("WarehouseWork.Models.Manufactured", "manufactured")
                        .WithMany()
                        .HasForeignKey("manufacturedid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
