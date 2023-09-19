﻿// <auto-generated />
using System;
using KB_WebAPI.databaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KB_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230916181308_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KB_WebAPI.Models.csAddress", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttractionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Zipcode")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("AttractionId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csAttraction", b =>
                {
                    b.Property<Guid>("AttractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AttractionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AttractionId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csRating", b =>
                {
                    b.Property<Guid>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttractionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<Guid>("UserId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RatingId");

                    b.HasIndex("AttractionId");

                    b.HasIndex("UserId1");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csReview", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttractionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReviewId");

                    b.HasIndex("AttractionId");

                    b.HasIndex("UserId1");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csAddress", b =>
                {
                    b.HasOne("KB_WebAPI.Models.csAttraction", "Attraction")
                        .WithOne("Address")
                        .HasForeignKey("KB_WebAPI.Models.csAddress", "AttractionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attraction");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csRating", b =>
                {
                    b.HasOne("KB_WebAPI.Models.csAttraction", "Attraction")
                        .WithMany("Rating")
                        .HasForeignKey("AttractionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KB_WebAPI.Models.csUser", "UserId")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attraction");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csReview", b =>
                {
                    b.HasOne("KB_WebAPI.Models.csAttraction", "Attraction")
                        .WithMany("Review")
                        .HasForeignKey("AttractionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KB_WebAPI.Models.csUser", "UserId")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attraction");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csAttraction", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Rating");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("KB_WebAPI.Models.csUser", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
