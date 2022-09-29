﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20220929104519_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Price = 100m,
                            ProductDescription = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            ProductName = "Glossier - Beauty Kit",
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Price = 50m,
                            ProductDescription = "A kit provided by Curology, containing skin care products",
                            ProductName = "Curology - Skin Care Kit",
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Price = 20m,
                            ProductDescription = "A kit provided by Curology, containing skin care products",
                            ProductName = "Cocooil - Organic Coconut Oil",
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Price = 50m,
                            ProductDescription = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                            ProductName = "Schwarzkopf - Hair Care and Skin Care Kit",
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Price = 30m,
                            ProductDescription = "Skin Care Kit, containing skin care and hair care products",
                            ProductName = "Skin Care Kit",
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Price = 100m,
                            ProductDescription = "Air Pods - in-ear wireless headphones",
                            ProductName = "Air Pods",
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Price = 40m,
                            ProductDescription = "On-ear Golden Headphones - these headphones are not wireless",
                            ProductName = "On-ear Golden Headphones",
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Price = 40m,
                            ProductDescription = "On-ear Black Headphones - these headphones are not wireless",
                            ProductName = "On-ear Black Headphones",
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Price = 600m,
                            ProductDescription = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ProductName = "Sennheiser Digital Camera with Tripod",
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Price = 500m,
                            ProductDescription = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ProductName = "Canon Digital Camera",
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            ImageURL = "/Images/Electronic/technology6.png",
                            Price = 100m,
                            ProductDescription = "Gameboy - Provided by Nintendo",
                            ProductName = "Nintendo Gameboy",
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Price = 50m,
                            ProductDescription = "Very comfortable black leather office chair",
                            ProductName = "Black Leather Office Chair",
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Price = 50m,
                            ProductDescription = "Very comfortable pink leather office chair",
                            ProductName = "Pink Leather Office Chair",
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Price = 70m,
                            ProductDescription = "Very comfortable lounge chair",
                            ProductName = "Lounge Chair",
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Price = 120m,
                            ProductDescription = "Very comfortable Silver lounge chair",
                            ProductName = "Silver Lounge Chair",
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Price = 15m,
                            ProductDescription = "White and blue Porcelain Table Lamp",
                            ProductName = "Porcelain Table Lamp",
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Price = 20m,
                            ProductDescription = "Office Table Lamp",
                            ProductName = "Office Table Lamp",
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Price = 100m,
                            ProductDescription = "Comfortable Puma Sneakers in most sizes",
                            ProductName = "Puma Sneakers",
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Price = 150m,
                            ProductDescription = "Colorful trainsers - available in most sizes",
                            ProductName = "Colorful Trainers",
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Price = 200m,
                            ProductDescription = "Blue Nike Trainers - available in most sizes",
                            ProductName = "Blue Nike Trainers",
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Price = 120m,
                            ProductDescription = "Colorful Hummel Trainers - available in most sizes",
                            ProductName = "Colorful Hummel Trainers",
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Price = 200m,
                            ProductDescription = "Red Nike Trainers - available in most sizes",
                            ProductName = "Red Nike Trainers",
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Price = 50m,
                            ProductDescription = "Birkenstock Sandles - available in most sizes",
                            ProductName = "Birkenstock Sandles",
                            Qty = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductCategoryName = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            ProductCategoryName = "Furniture"
                        },
                        new
                        {
                            Id = 3,
                            ProductCategoryName = "Electronics"
                        },
                        new
                        {
                            Id = 4,
                            ProductCategoryName = "Shoes"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}