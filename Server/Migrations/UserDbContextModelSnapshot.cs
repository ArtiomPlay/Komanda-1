﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projektas.Server.Database;

#nullable disable

namespace Projektas.Server.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.AimTrainerData>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("aimTrainerScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.MathGameData>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("mathGameScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.PairUpData>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("pairUpScores", (string)null);
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.SudokuData>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

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

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.AimTrainerData>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("AimTrainerScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Projektas.Shared.Models.AimTrainerData", "GameData", b1 =>
                        {
                            b1.Property<int>("ScoreId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Scores")
                                .HasColumnType("INTEGER")
                                .HasColumnName("score");

                            b1.HasKey("ScoreId");

                            b1.ToTable("aimTrainerScores");

                            b1.WithOwner()
                                .HasForeignKey("ScoreId");
                        });

                    b.Navigation("GameData");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.MathGameData>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("MathGameScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Projektas.Shared.Models.MathGameData", "GameData", b1 =>
                        {
                            b1.Property<int>("ScoreId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Scores")
                                .HasColumnType("INTEGER")
                                .HasColumnName("score");

                            b1.HasKey("ScoreId");

                            b1.ToTable("mathGameScores");

                            b1.WithOwner()
                                .HasForeignKey("ScoreId");
                        });

                    b.Navigation("GameData");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.PairUpData>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("PairUpScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Projektas.Shared.Models.PairUpData", "GameData", b1 =>
                        {
                            b1.Property<int>("ScoreId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Fails")
                                .HasColumnType("INTEGER")
                                .HasColumnName("fails");

                            b1.Property<int>("TimeInSeconds")
                                .HasColumnType("INTEGER")
                                .HasColumnName("timeInSeconds");

                            b1.HasKey("ScoreId");

                            b1.ToTable("pairUpScores");

                            b1.WithOwner()
                                .HasForeignKey("ScoreId");
                        });

                    b.Navigation("GameData");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projektas.Shared.Models.Score<Projektas.Shared.Models.SudokuData>", b =>
                {
                    b.HasOne("Projektas.Shared.Models.User", "User")
                        .WithMany("SudokuScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Projektas.Shared.Models.SudokuData", "GameData", b1 =>
                        {
                            b1.Property<int>("ScoreId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("TimeInSeconds")
                                .HasColumnType("INTEGER")
                                .HasColumnName("timeInSeconds");

                            b1.HasKey("ScoreId");

                            b1.ToTable("sudokuScores");

                            b1.WithOwner()
                                .HasForeignKey("ScoreId");
                        });

                    b.Navigation("GameData");

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
