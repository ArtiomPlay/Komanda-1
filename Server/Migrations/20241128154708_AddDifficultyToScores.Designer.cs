﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projektas.Server.Database;

#nullable disable

namespace Projektas.Server.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20241128154708_AddDifficultyToScores")]
    partial class AddDifficultyToScores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.AimTrainerM>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT")
                        .HasColumnName("Difficulty");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("Timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserScores")
                        .HasColumnType("INTEGER")
                        .HasColumnName("userScore");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("aimTrainerScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.MathGameM>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("Timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserScores")
                        .HasColumnType("INTEGER")
                        .HasColumnName("userScore");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("mathGameScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.PairUpM>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT")
                        .HasColumnName("Difficulty");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("Timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserScores")
                        .HasColumnType("INTEGER")
                        .HasColumnName("userScore");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("pairUpScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.SudokuM>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT")
                        .HasColumnName("Difficulty");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("Timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserScores")
                        .HasColumnType("INTEGER")
                        .HasColumnName("userScore");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("sudokuScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("password");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("surname");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.AimTrainerM>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("AimTrainerScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.MathGameM>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("MathGameScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.PairUpM>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("PairUpScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.SudokuM>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("SudokuScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.User", b =>
                {
                    b.Navigation("AimTrainerScores");

                    b.Navigation("MathGameScores");

                    b.Navigation("PairUpScores");

                    b.Navigation("SudokuScores");
                });
#pragma warning restore 612, 618
        }
    }
}
