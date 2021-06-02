﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210602210323_m-n-StudentsTeachers")]
    partial class mnStudentsTeachers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CodeFirst.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Amal@Amal",
                            FirstName = "Amal",
                            LastName = "Fahad"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Amal@Amal",
                            FirstName = "Leenah",
                            LastName = "Fahad"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Amal@Amal",
                            FirstName = "Sarah",
                            LastName = "Fahad"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Amal@Amal",
                            FirstName = "Reem",
                            LastName = "Fahad"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Amal@Amal",
                            FirstName = "Ali",
                            LastName = "Fahad"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.StudentTeacherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentTeacherModel");
                });

            modelBuilder.Entity("CodeFirst.Models.TeacherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CodeFirst.Models.RoomModel", b =>
                {
                    b.HasOne("CodeFirst.Models.StudentModel", "Student")
                        .WithOne("Room")
                        .HasForeignKey("CodeFirst.Models.RoomModel", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Models.StudentTeacherModel", b =>
                {
                    b.HasOne("CodeFirst.Models.StudentModel", "Student")
                        .WithMany("Teachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst.Models.TeacherModel", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}