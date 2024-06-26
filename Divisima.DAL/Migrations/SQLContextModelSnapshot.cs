﻿// <auto-generated />
using System;
using Divisima.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Divisima.DAL.Migrations
{
    [DbContext(typeof(SQLContext))]
    partial class SQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Divisima.DAL.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastLoginIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NvarChar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            LastLoginDate = new DateTime(2024, 5, 24, 19, 55, 7, 475, DateTimeKind.Local).AddTicks(3510),
                            LastLoginIP = "",
                            NameSurName = "Emrehan Ağaçyetiştiren",
                            Password = "202cb962ac59075b964b07152d234b70",
                            UserName = "Ağaç"
                        });
                });

            modelBuilder.Entity("Divisima.DAL.Entities.Slide", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("Nvarchar(150)");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("Nvarchar(150)");

                    b.Property<string>("Picture")
                        .HasMaxLength(150)
                        .HasColumnType("Nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<string>("Slogan")
                        .HasMaxLength(50)
                        .HasColumnType("Nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Slide");
                });
#pragma warning restore 612, 618
        }
    }
}
