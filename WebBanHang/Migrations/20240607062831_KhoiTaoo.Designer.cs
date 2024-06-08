﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanHang.Models;

namespace WebBanHang.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240607062831_KhoiTaoo")]
    partial class KhoiTaoo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBanHang.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Điện thoại"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Máy tính bảng"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Laptop"
                        });
                });

            modelBuilder.Entity("WebBanHang.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Iphone 7",
                            Price = 300.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Iphone 7s",
                            Price = 350.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Iphone 8",
                            Price = 400.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "Iphone 8s",
                            Price = 420.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Name = "Iphone 12",
                            Price = 630.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Name = "Iphone 12 Pro",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Name = "Iphone 14",
                            Price = 820.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Name = "Iphone 14 Pro",
                            Price = 950.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Name = "Iphone 15",
                            Price = 1200.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Name = "Iphone 15 Pro Max ",
                            Price = 1450.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Name = "Ipad Gen 10",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "Ipad Pro 11",
                            Price = 1250.0
                        });
                });

            modelBuilder.Entity("WebBanHang.Models.Product", b =>
                {
                    b.HasOne("WebBanHang.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
