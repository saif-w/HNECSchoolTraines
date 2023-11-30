﻿// <auto-generated />
using System;
using ConsoleApp1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(HNECDBContext))]
    [Migration("20231130084838_TAbelsCreate")]
    partial class TAbelsCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp1.Entity.Courses", b =>
                {
                    b.Property<int>("CoursesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoursesId"));

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursesId");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Budjet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InstructersId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InstructersId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Enrollament", b =>
                {
                    b.Property<int>("EnrollamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollamentId"));

                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudintsId")
                        .HasColumnType("int");

                    b.HasKey("EnrollamentId");

                    b.HasIndex("CoursesId");

                    b.HasIndex("StudintsId");

                    b.ToTable("Enrollaments");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Instructers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CoursesId")
                        .HasColumnType("int");

                    b.Property<string>("FirstMiddelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoursesId");

                    b.ToTable("Instructers");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Offices", b =>
                {
                    b.Property<int>("InstructersId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructersId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Studints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studints");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Courses", b =>
                {
                    b.HasOne("ConsoleApp1.Entity.Departments", "Departments")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Departments", b =>
                {
                    b.HasOne("ConsoleApp1.Entity.Instructers", "Adminstaritor")
                        .WithMany()
                        .HasForeignKey("InstructersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adminstaritor");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Enrollament", b =>
                {
                    b.HasOne("ConsoleApp1.Entity.Courses", "Courses")
                        .WithMany("Enrollament")
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entity.Studints", "Studints")
                        .WithMany("Enrollament")
                        .HasForeignKey("StudintsId");

                    b.Navigation("Courses");

                    b.Navigation("Studints");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Instructers", b =>
                {
                    b.HasOne("ConsoleApp1.Entity.Courses", null)
                        .WithMany("Instructers")
                        .HasForeignKey("CoursesId");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Offices", b =>
                {
                    b.HasOne("ConsoleApp1.Entity.Instructers", "Instructer")
                        .WithOne("Office")
                        .HasForeignKey("ConsoleApp1.Entity.Offices", "InstructersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructer");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Courses", b =>
                {
                    b.Navigation("Enrollament");

                    b.Navigation("Instructers");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Departments", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Instructers", b =>
                {
                    b.Navigation("Office");
                });

            modelBuilder.Entity("ConsoleApp1.Entity.Studints", b =>
                {
                    b.Navigation("Enrollament");
                });
#pragma warning restore 612, 618
        }
    }
}
