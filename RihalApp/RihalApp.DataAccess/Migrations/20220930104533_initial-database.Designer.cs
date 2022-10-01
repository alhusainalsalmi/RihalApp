﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RihalApp.DataAccess.DbContext;

#nullable disable

namespace RihalApp.DataAccess.Migrations
{
    [DbContext(typeof(RihalAppDbContext))]
    [Migration("20220930104533_initial-database")]
    partial class initialdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("RihalApp.Domain.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("creation_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_classes");

                    b.ToTable("classes", (string)null);
                });

            modelBuilder.Entity("RihalApp.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("creation_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_countries");

                    b.ToTable("countries", (string)null);
                });

            modelBuilder.Entity("RihalApp.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("class_id");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("country_id");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("creation_date");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.HasIndex("ClassId")
                        .HasDatabaseName("ix_students_class_id");

                    b.HasIndex("CountryId")
                        .HasDatabaseName("ix_students_country_id");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("RihalApp.Domain.Entities.Student", b =>
                {
                    b.HasOne("RihalApp.Domain.Entities.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_students_classes_class_id");

                    b.HasOne("RihalApp.Domain.Entities.Country", "Country")
                        .WithMany("Students")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_students_countries_country_id");

                    b.Navigation("Class");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("RihalApp.Domain.Entities.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("RihalApp.Domain.Entities.Country", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
