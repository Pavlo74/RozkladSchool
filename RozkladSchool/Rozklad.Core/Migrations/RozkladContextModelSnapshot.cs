﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rozklad.Core;

#nullable disable

namespace Rozklad.Core.Migrations
{
    [DbContext(typeof(RozkladContext))]
    partial class RozkladContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
                            Id = "d4d24cd2-8c69-49ca-a150-1876780357ea",
                            ConcurrencyStamp = "6b0480ee-a2d8-41d8-b776-a9ac3777f712",
=======
                            Id = "a045b04b-c847-4d7f-8751-b1b6b0c529a4",
                            ConcurrencyStamp = "4f589d0c-f8a6-4370-9b94-c0b8feec4945",
>>>>>>> main
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "212cee6e-aa55-4e9f-abe6-f82d2d5dc918",
                            ConcurrencyStamp = "f8b14907-4dcc-49db-ad1d-518409800340",
=======
                            Id = "b3407ff8-714d-4e90-8a66-6f41137d3a81",
                            ConcurrencyStamp = "00e2f188-47f6-484e-9944-8705c29f95b1",
>>>>>>> main
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "40777208-6069-481b-81ce-0a53c8c6552f",
                            ConcurrencyStamp = "ba9a5434-6d8f-4091-8d91-871b8f4f9808",
=======
                            Id = "2fbbc482-c0b6-4ace-b8c6-28663d41ad98",
                            ConcurrencyStamp = "69b3cee7-830e-4abd-9d0a-d76c242528e0",
>>>>>>> main
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
                            UserId = "1c8353c3-fed8-4199-af09-59bda8861294",
                            RoleId = "d4d24cd2-8c69-49ca-a150-1876780357ea"
                        },
                        new
                        {
                            UserId = "1c8353c3-fed8-4199-af09-59bda8861294",
                            RoleId = "40777208-6069-481b-81ce-0a53c8c6552f"
                        },
                        new
                        {
                            UserId = "79c6622f-b8c0-4ff6-bb49-3faf738ce6ff",
                            RoleId = "40777208-6069-481b-81ce-0a53c8c6552f"
=======
                            UserId = "e043861a-1988-4355-94b8-636e9b8be143",
                            RoleId = "a045b04b-c847-4d7f-8751-b1b6b0c529a4"
                        },
                        new
                        {
                            UserId = "e043861a-1988-4355-94b8-636e9b8be143",
                            RoleId = "b3407ff8-714d-4e90-8a66-6f41137d3a81"
                        },
                        new
                        {
                            UserId = "e043861a-1988-4355-94b8-636e9b8be143",
                            RoleId = "2fbbc482-c0b6-4ace-b8c6-28663d41ad98"
                        },
                        new
                        {
                            UserId = "3294d846-8856-40c4-ba1b-b4c929593b76",
                            RoleId = "b3407ff8-714d-4e90-8a66-6f41137d3a81"
                        },
                        new
                        {
                            UserId = "3294d846-8856-40c4-ba1b-b4c929593b76",
                            RoleId = "2fbbc482-c0b6-4ace-b8c6-28663d41ad98"
                        },
                        new
                        {
                            UserId = "7318a390-69a1-4b25-be35-444f38ee9c27",
                            RoleId = "2fbbc482-c0b6-4ace-b8c6-28663d41ad98"
>>>>>>> main
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.Property<int>("CabinetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CabinetId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CabinetId");

                    b.ToTable("Cabinets");

                    b.HasData(
                        new
                        {
                            CabinetId = 1,
                            Name = "Географія"
                        },
                        new
                        {
                            CabinetId = 2,
                            Name = "Біологія"
                        },
                        new
                        {
                            CabinetId = 3,
                            Name = "Математика"
                        },
                        new
                        {
                            CabinetId = 4,
                            Name = "Укр мова"
                        },
                        new
                        {
                            CabinetId = 5,
                            Name = "Історія"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "1-A"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "1-B"
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "2-A"
                        },
                        new
                        {
                            ClassId = 4,
                            ClassName = "2-B"
                        },
                        new
                        {
                            ClassId = 5,
                            ClassName = "3-A"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"), 1L, 1);

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            DayName = "Понеділок"
                        },
                        new
                        {
                            DayId = 2,
                            DayName = "Вівторок"
                        },
                        new
                        {
                            DayId = 3,
                            DayName = "Середа"
                        },
                        new
                        {
                            DayId = 4,
                            DayName = "Четвер"
                        },
                        new
                        {
                            DayId = 5,
                            DayName = "Пятниця"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"), 1L, 1);

                    b.Property<string>("DisciplineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplineId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            DisciplineId = 1,
                            DisciplineName = "Географія"
                        },
                        new
                        {
                            DisciplineId = 2,
                            DisciplineName = "Біологія"
                        },
                        new
                        {
                            DisciplineId = 3,
                            DisciplineName = "Математика"
                        },
                        new
                        {
                            DisciplineId = 4,
                            DisciplineName = "Укр мова"
                        },
                        new
                        {
                            DisciplineId = 5,
                            DisciplineName = "Історія"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            EndTime = "12.45",
                            LessonNumber = 1,
                            StartTime = "12.00"
                        },
                        new
                        {
                            LessonId = 2,
                            EndTime = "13.45",
                            LessonNumber = 2,
                            StartTime = "13.00"
                        },
                        new
                        {
                            LessonId = 3,
                            EndTime = "14.45",
                            LessonNumber = 3,
                            StartTime = "14.00"
                        },
                        new
                        {
                            LessonId = 4,
                            EndTime = "15.45",
                            LessonNumber = 4,
                            StartTime = "15.00 "
                        },
                        new
                        {
                            LessonId = 5,
                            EndTime = "16.45",
                            LessonNumber = 5,
                            StartTime = "16.00"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.Property<int>("TimetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimetableId"), 1L, 1);

                    b.Property<int>("CabinetId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.HasIndex("CabinetId");

                    b.HasIndex("ClassId");

                    b.HasIndex("DayId");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("LessonId");

                    b.ToTable("Timetables");

                    b.HasData(
                        new
                        {
                            TimetableId = 1,
                            CabinetId = 1,
                            ClassId = 1,
                            DayId = 1,
                            DisciplineId = 1,
                            IconPath = "Images\\1200h790_1-4_klass_t.png",
                            LessonId = 1
                        },
                        new
                        {
                            TimetableId = 2,
                            CabinetId = 2,
                            ClassId = 2,
                            DayId = 2,
                            DisciplineId = 2,
                            IconPath = "Images\\1200TE790_5_klass_t.png",
                            LessonId = 2
                        });
                });

            modelBuilder.Entity("Rozklad.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<< HEAD
                            Id = "1c8353c3-fed8-4199-af09-59bda8861294",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f445b41d-fa2c-42e1-bb58-42f3d0392d14",
=======
                            Id = "e043861a-1988-4355-94b8-636e9b8be143",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5310717d-315d-4ebb-9841-3ccf749456ac",
>>>>>>> main
                            Email = "admin@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "ADMIN@ROZKLADSCHOOL.COM",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEBtTjAo2VlbDo+t92yA9X4qYtJ14/fCtLy5wdjCqCJoH5J8rFI2RUnXw+w56TrFv2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8314e549-8eed-436b-94d0-cddc767c8bdc",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAECZEItLKRnaIDVC0W8v2byAfT1a9W5+FsYisIDdFcqTAQ7naFw7M2BwePWaNAs8gxQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "74932f26-84d8-46ae-bec4-07ad59b2deba",
>>>>>>> main
                            TwoFactorEnabled = false,
                            UserName = "admin@rozkladschool.com"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "08f450f6-ae16-4519-bd44-4b320f2702f5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "93efe738-ae25-4973-b369-0b55aa09051d",
=======
                            Id = "3294d846-8856-40c4-ba1b-b4c929593b76",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ca7dee0-5140-461f-ba2c-6dda71025424",
>>>>>>> main
                            Email = "moderator@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "MODERATOR@ROZKLADSCHOOL.COM",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEN6bqt/XDJ9a2BIJIZiRKDZVtwGeHK2Trh3FGfJsA61P0OMGOiMsM86nxiGltczODg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "deff61dd-8628-444d-87b8-57439227c6fb",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEOOXCxYegk+OiA70xk7760AXKIo8TibvNq3DtGYlnR1mYCZlSBmqxw752XXVJDhGaA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "24c15b18-de64-46d2-8fc0-afbb725bede1",
>>>>>>> main
                            TwoFactorEnabled = false,
                            UserName = "moderator@rozkladschool.com"
                        },
                        new
                        {
<<<<<<< HEAD
                            Id = "79c6622f-b8c0-4ff6-bb49-3faf738ce6ff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d4babb42-52fb-423f-b100-8fb742b573f1",
=======
                            Id = "7318a390-69a1-4b25-be35-444f38ee9c27",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "232260ba-d656-42d9-a794-665eb05aff08",
>>>>>>> main
                            Email = "user@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "USER@ROZKLADSCHOOL.COM",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEAf+0mWeBMuJ+W4Bb9rnxWZ6oJHh2dYmeWr0jdJ97bUIHjMv4lRl/CHLOf/XJQIwfA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "24923fd2-fa28-4224-9c5d-f528843bc9a4",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEAhNNqgFKqTPno65fwIePvCGVWgo2MructbayolpmzOEGcmZEYCSII0qrgvRnK98Jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b1fccd98-defb-4e85-9a92-b1a9f3c1eb65",
>>>>>>> main
                            TwoFactorEnabled = false,
                            UserName = "user@rozkladschool.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.HasOne("Rozklad.Core.Cabinet", "Cabinet")
                        .WithMany("Timetables")
                        .HasForeignKey("CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Class", "Class")
                        .WithMany("Timetables")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Day", "Day")
                        .WithMany("Timetables")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Discipline", "Discipline")
                        .WithMany("Timetables")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Lesson", "Lesson")
                        .WithMany("Timetables")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabinet");

                    b.Navigation("Class");

                    b.Navigation("Day");

                    b.Navigation("Discipline");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Navigation("Timetables");
                });
#pragma warning restore 612, 618
        }
    }
}
