﻿// <auto-generated />
using System;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210811202515_EditionSeeding")]
    partial class EditionSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "tag",
                            Name = "Movies",
                            Url = "movies"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 2,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The son of a zookeeper, Pi Patel has an encyclopedic knowledge of animal behavior and a fervent love of stories. When Pi is sixteen, his family emigrates from India to North America aboard a Japanese cargo ship, along with their zoo animals bound for new homes",
                            Image = "https://upload.wikimedia.org/wikipedia/en/4/45/Life_of_Pi_cover.png",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.99m,
                            Price = 9.99m,
                            Title = "Life Of Pie"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The game takes place in Hope County, a fictional region of Montana, United States. The main story revolves around the Project at Eden's Gate, a doomsday cult that has taken over the county at the command of its charismatic and powerful leader, Joseph Seed. ",
                            Image = "https://upload.wikimedia.org/wikipedia/en/0/03/Far_Cry_5_boxshot.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 39.99m,
                            Price = 8.19m,
                            Title = "Farcry 5"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 499.99m,
                            Price = 399.99m,
                            Title = "Playstation 5 (PS5)"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            DateCreated = new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sarpatta Parambarai, or alternatively Sarpatta tradition, is a 2021 Indian Tamil-language sports action film directed by Pa. Ranjith, who also co-produced the film under his banner Neelam Productions",
                            Image = "https://upload.wikimedia.org/wikipedia/en/a/a6/Sarpatta_Parambarai.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 40.29m,
                            Price = 20.19m,
                            Title = "Sarpatta Parambarai"
                        });
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("EditionsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EditionProduct");

                    b.HasData(
                        new
                        {
                            EditionsId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            EditionsId = 2,
                            ProductsId = 1
                        },
                        new
                        {
                            EditionsId = 3,
                            ProductsId = 1
                        },
                        new
                        {
                            EditionsId = 4,
                            ProductsId = 2
                        },
                        new
                        {
                            EditionsId = 5,
                            ProductsId = 2
                        },
                        new
                        {
                            EditionsId = 6,
                            ProductsId = 2
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.HasOne("BlazingShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.HasOne("BlazingShop.Shared.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingShop.Shared.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
