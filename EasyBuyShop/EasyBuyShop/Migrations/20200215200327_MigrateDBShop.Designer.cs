﻿// <auto-generated />
using EasyBuyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyBuyShop.Migrations
{
    [DbContext(typeof(ShopDBContent))]
    [Migration("20200215200327_MigrateDBShop")]
    partial class MigrateDBShop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyBuyShop.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("heading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
