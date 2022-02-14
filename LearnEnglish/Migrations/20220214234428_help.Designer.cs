﻿// <auto-generated />
using System;
using LearnEnglish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnEnglish.Migrations
{
    [DbContext(typeof(LearnEnglishContext))]
    [Migration("20220214234428_help")]
    partial class help
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LearnEnglish.Models.Content", b =>
                {
                    b.Property<int>("ContentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Rank")
                        .HasColumnType("smallint");

                    b.Property<int?>("SectionID")
                        .HasColumnType("int");

                    b.HasKey("ContentID");

                    b.HasIndex("SectionID");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("LearnEnglish.Models.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("Rank")
                        .HasColumnType("smallint");

                    b.Property<int?>("ThemeID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionID");

                    b.HasIndex("ThemeID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("LearnEnglish.Models.Theme", b =>
                {
                    b.Property<int>("ThemeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<short>("Rank")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThemeID");

                    b.ToTable("Themes");

                    b.HasData(
                        new
                        {
                            ThemeID = 1,
                            CreatedDate = new DateTime(2022, 2, 15, 2, 44, 27, 806, DateTimeKind.Local).AddTicks(1410),
                            IsActive = (short)1,
                            Level = 0,
                            Rank = (short)0,
                            Title = "Theme-1"
                        });
                });

            modelBuilder.Entity("LearnEnglish.Models.Content", b =>
                {
                    b.HasOne("LearnEnglish.Models.Section", "Section")
                        .WithMany("Contents")
                        .HasForeignKey("SectionID");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("LearnEnglish.Models.Section", b =>
                {
                    b.HasOne("LearnEnglish.Models.Theme", "Theme")
                        .WithMany("Sections")
                        .HasForeignKey("ThemeID");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("LearnEnglish.Models.Section", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("LearnEnglish.Models.Theme", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}