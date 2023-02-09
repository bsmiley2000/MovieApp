﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Models;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("MovieApp.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Rating = "PG-13",
                            Title = "Batman Begins",
                            Year = 2005
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Action",
                            Director = "James Cameron",
                            Rating = "PG-13",
                            Title = "Avatar",
                            Year = 2009
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Action",
                            Director = "Anthony Russo",
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = 2012
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
