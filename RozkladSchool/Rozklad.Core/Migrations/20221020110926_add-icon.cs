using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221020124904_testmig.cs
    public partial class testmig : Migration
========
    public partial class addicon : Migration
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221020110926_add-icon.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabinets",
                columns: table => new
                {
                    CabinetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinets", x => x.CabinetId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    DisciplineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.DisciplineId);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonNumber = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timetables",
                columns: table => new
                {
                    TimetableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    CabinetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.TimetableId);
                    table.ForeignKey(
                        name: "FK_Timetables_Cabinets_CabinetId",
                        column: x => x.CabinetId,
                        principalTable: "Cabinets",
                        principalColumn: "CabinetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221020124904_testmig.cs
                    { "212cee6e-aa55-4e9f-abe6-f82d2d5dc918", "f8b14907-4dcc-49db-ad1d-518409800340", "Moderator", "MODERATOR" },
                    { "40777208-6069-481b-81ce-0a53c8c6552f", "ba9a5434-6d8f-4091-8d91-871b8f4f9808", "User", "USER" },
                    { "d4d24cd2-8c69-49ca-a150-1876780357ea", "6b0480ee-a2d8-41d8-b776-a9ac3777f712", "Admin", "ADMIN" }
========
                    { "2fbbc482-c0b6-4ace-b8c6-28663d41ad98", "69b3cee7-830e-4abd-9d0a-d76c242528e0", "User", "USER" },
                    { "a045b04b-c847-4d7f-8751-b1b6b0c529a4", "4f589d0c-f8a6-4370-9b94-c0b8feec4945", "Admin", "ADMIN" },
                    { "b3407ff8-714d-4e90-8a66-6f41137d3a81", "00e2f188-47f6-484e-9944-8705c29f95b1", "Moderator", "MODERATOR" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221020110926_add-icon.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221020124904_testmig.cs
                    { "08f450f6-ae16-4519-bd44-4b320f2702f5", 0, "93efe738-ae25-4973-b369-0b55aa09051d", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEN6bqt/XDJ9a2BIJIZiRKDZVtwGeHK2Trh3FGfJsA61P0OMGOiMsM86nxiGltczODg==", null, false, "deff61dd-8628-444d-87b8-57439227c6fb", false, "moderator@rozkladschool.com" },
                    { "1c8353c3-fed8-4199-af09-59bda8861294", 0, "f445b41d-fa2c-42e1-bb58-42f3d0392d14", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEBtTjAo2VlbDo+t92yA9X4qYtJ14/fCtLy5wdjCqCJoH5J8rFI2RUnXw+w56TrFv2w==", null, false, "8314e549-8eed-436b-94d0-cddc767c8bdc", false, "admin@rozkladschool.com" },
                    { "79c6622f-b8c0-4ff6-bb49-3faf738ce6ff", 0, "d4babb42-52fb-423f-b100-8fb742b573f1", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEAf+0mWeBMuJ+W4Bb9rnxWZ6oJHh2dYmeWr0jdJ97bUIHjMv4lRl/CHLOf/XJQIwfA==", null, false, "24923fd2-fa28-4224-9c5d-f528843bc9a4", false, "user@rozkladschool.com" }
========
                    { "3294d846-8856-40c4-ba1b-b4c929593b76", 0, "1ca7dee0-5140-461f-ba2c-6dda71025424", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEOOXCxYegk+OiA70xk7760AXKIo8TibvNq3DtGYlnR1mYCZlSBmqxw752XXVJDhGaA==", null, false, "24c15b18-de64-46d2-8fc0-afbb725bede1", false, "moderator@rozkladschool.com" },
                    { "7318a390-69a1-4b25-be35-444f38ee9c27", 0, "232260ba-d656-42d9-a794-665eb05aff08", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEAhNNqgFKqTPno65fwIePvCGVWgo2MructbayolpmzOEGcmZEYCSII0qrgvRnK98Jw==", null, false, "b1fccd98-defb-4e85-9a92-b1a9f3c1eb65", false, "user@rozkladschool.com" },
                    { "e043861a-1988-4355-94b8-636e9b8be143", 0, "5310717d-315d-4ebb-9841-3ccf749456ac", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAECZEItLKRnaIDVC0W8v2byAfT1a9W5+FsYisIDdFcqTAQ7naFw7M2BwePWaNAs8gxQ==", null, false, "74932f26-84d8-46ae-bec4-07ad59b2deba", false, "admin@rozkladschool.com" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221020110926_add-icon.cs
                });

            migrationBuilder.InsertData(
                table: "Cabinets",
                columns: new[] { "CabinetId", "Name" },
                values: new object[,]
                {
                    { 1, "Географія" },
                    { 2, "Біологія" },
                    { 3, "Математика" },
                    { 4, "Укр мова" },
                    { 5, "Історія" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName" },
                values: new object[,]
                {
                    { 1, "1-A" },
                    { 2, "1-B" },
                    { 3, "2-A" },
                    { 4, "2-B" },
                    { 5, "3-A" }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "DayName" },
                values: new object[,]
                {
                    { 1, "Понеділок" },
                    { 2, "Вівторок" },
                    { 3, "Середа" },
                    { 4, "Четвер" },
                    { 5, "Пятниця" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "DisciplineId", "DisciplineName" },
                values: new object[,]
                {
                    { 1, "Географія" },
                    { 2, "Біологія" },
                    { 3, "Математика" },
                    { 4, "Укр мова" },
                    { 5, "Історія" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "EndTime", "LessonNumber", "StartTime" },
                values: new object[,]
                {
                    { 1, "12.45", 1, "12.00" },
                    { 2, "13.45", 2, "13.00" },
                    { 3, "14.45", 3, "14.00" },
                    { 4, "15.45", 4, "15.00 " },
                    { 5, "16.45", 5, "16.00" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221020124904_testmig.cs
                    { "40777208-6069-481b-81ce-0a53c8c6552f", "1c8353c3-fed8-4199-af09-59bda8861294" },
                    { "d4d24cd2-8c69-49ca-a150-1876780357ea", "1c8353c3-fed8-4199-af09-59bda8861294" },
                    { "40777208-6069-481b-81ce-0a53c8c6552f", "79c6622f-b8c0-4ff6-bb49-3faf738ce6ff" }
========
                    { "2fbbc482-c0b6-4ace-b8c6-28663d41ad98", "3294d846-8856-40c4-ba1b-b4c929593b76" },
                    { "b3407ff8-714d-4e90-8a66-6f41137d3a81", "3294d846-8856-40c4-ba1b-b4c929593b76" },
                    { "2fbbc482-c0b6-4ace-b8c6-28663d41ad98", "7318a390-69a1-4b25-be35-444f38ee9c27" },
                    { "2fbbc482-c0b6-4ace-b8c6-28663d41ad98", "e043861a-1988-4355-94b8-636e9b8be143" },
                    { "a045b04b-c847-4d7f-8751-b1b6b0c529a4", "e043861a-1988-4355-94b8-636e9b8be143" },
                    { "b3407ff8-714d-4e90-8a66-6f41137d3a81", "e043861a-1988-4355-94b8-636e9b8be143" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221020110926_add-icon.cs
                });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassId", "DayId", "DisciplineId", "IconPath", "LessonId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, "Images\\1200h790_1-4_klass_t.png", 1 },
                    { 2, 2, 2, 2, 2, "Images\\1200TE790_5_klass_t.png", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_CabinetId",
                table: "Timetables",
                column: "CabinetId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_ClassId",
                table: "Timetables",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_DayId",
                table: "Timetables",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_DisciplineId",
                table: "Timetables",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_LessonId",
                table: "Timetables",
                column: "LessonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Timetables");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cabinets");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
