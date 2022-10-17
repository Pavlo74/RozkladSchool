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
                            Id = "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1",
                            ConcurrencyStamp = "d5bf66c4-9f95-4359-b8dc-17b20cbcad8c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9fd1a930-4410-43b6-b789-1a0a4632a45f",
                            ConcurrencyStamp = "bd69cdd8-9858-4de6-bf0b-f90226958d25",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "1a4ce891-ab9a-42e6-a049-15b763a2a093",
                            ConcurrencyStamp = "222b7878-0a1e-4b15-83ed-67ba5243141f",
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
                            UserId = "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e",
                            RoleId = "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1"
                        },
                        new
                        {
                            UserId = "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e",
                            RoleId = "1a4ce891-ab9a-42e6-a049-15b763a2a093"
                        },
                        new
                        {
                            UserId = "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e",
                            RoleId = "9fd1a930-4410-43b6-b789-1a0a4632a45f"
                        },
                        new
                        {
                            UserId = "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca",
                            RoleId = "1a4ce891-ab9a-42e6-a049-15b763a2a093"
                        },
                        new
                        {
                            UserId = "1f54936b-f4b0-4f8a-93d0-dc26538e3681",
                            RoleId = "1a4ce891-ab9a-42e6-a049-15b763a2a093"
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

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("CabinetId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Cabinets");
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"), 1L, 1);

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("DayId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"), 1L, 1);

                    b.Property<string>("DisciplineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("DisciplineId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Lessons");
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

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.ToTable("Timetables");
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
                            Id = "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1806f973-b3e4-457a-a40d-5ce836aa7fd7",
                            Email = "admin@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "ADMIN@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI+XeJlEwv16Jk0D1bctfkCTfrNWu9XgrzckT8jJ6KIWqEUnPcMzXMPB2CC2yPwpZw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f1cdcd3e-b114-4feb-a845-cb1729d2b00d",
                            TwoFactorEnabled = false,
                            UserName = "admin@rozkladschool.com"
                        },
                        new
                        {
                            Id = "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "793d4e29-d14e-41bc-98ef-97d3aa1c2e57",
                            Email = "moderator@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "MODERATOR@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGzkYYmuS0s3PxzT22g2LWJ52h87gLJP70JtPeIOkJ4x4wvDbP62sw8bqMKWiRqQrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "623a7f9c-8069-44f4-92c4-2ffb42629c37",
                            TwoFactorEnabled = false,
                            UserName = "moderator@rozkladschool.com"
                        },
                        new
                        {
                            Id = "1f54936b-f4b0-4f8a-93d0-dc26538e3681",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2ac04be0-42e1-4b44-86bd-b4c9ce6e759a",
                            Email = "user@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "USER@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBB4ZRgXKoaxlmrYlFv76GKzb1tHH9D9kAE0RNteOHAMUhQBVTMgSHDtombtD45odA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cbaccb02-a37b-4270-8ae5-3cf48181fede",
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

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.HasOne("Rozklad.Core.Timetable", null)
                        .WithMany("Cabinets")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.HasOne("Rozklad.Core.Timetable", null)
                        .WithMany("Classes")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.HasOne("Rozklad.Core.Timetable", null)
                        .WithMany("Days")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.HasOne("Rozklad.Core.Timetable", null)
                        .WithMany("Disciplines")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.HasOne("Rozklad.Core.Timetable", null)
                        .WithMany("Lessons")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.Navigation("Cabinets");

                    b.Navigation("Classes");

                    b.Navigation("Days");

                    b.Navigation("Disciplines");

                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
