﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06.Models;

namespace Mission06.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    [Migration("20230222005627_dataChanges")]
    partial class dataChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Sci-Fi/Fantasy"
                        });
                });

            modelBuilder.Entity("Mission06.Models.MovieEntry", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
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

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("entries");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Director = "Peter Segal",
                            Edited = false,
                            LentTo = "Johnny",
                            Notes = "This is Johnny's all-time favorite movie",
                            Rating = "PG-13",
                            Title = "Tommyboy",
                            Year = 1995
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 4,
                            Director = "Richard Curtis",
                            Edited = false,
                            LentTo = "Johnny",
                            Notes = "This movie has the best message of any movie ever",
                            Rating = "R",
                            Title = "About Time",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 5,
                            Director = "Peter Jackson",
                            Edited = false,
                            LentTo = "Johnny",
                            Notes = "Favorite of all the movies, but the whole trilogy is the best of all time.",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: Return of the King",
                            Year = 2003
                        });
                });

            modelBuilder.Entity("Mission06.Models.MovieEntry", b =>
                {
                    b.HasOne("Mission06.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}