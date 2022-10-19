using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
    public partial class output : Migration
========
    public partial class firstmig : Migration
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
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
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
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
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    CabinetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.TimetableId);
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
                name: "CabinetTimetable",
                columns: table => new
                {
                    CabinetsCabinetId = table.Column<int>(type: "int", nullable: false),
                    TimetablesTimetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabinetTimetable", x => new { x.CabinetsCabinetId, x.TimetablesTimetableId });
                    table.ForeignKey(
                        name: "FK_CabinetTimetable_Cabinets_CabinetsCabinetId",
                        column: x => x.CabinetsCabinetId,
                        principalTable: "Cabinets",
                        principalColumn: "CabinetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabinetTimetable_Timetables_TimetablesTimetableId",
                        column: x => x.TimetablesTimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassTimetable",
                columns: table => new
                {
                    ClassesClassId = table.Column<int>(type: "int", nullable: false),
                    TimetablesTimetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTimetable", x => new { x.ClassesClassId, x.TimetablesTimetableId });
                    table.ForeignKey(
                        name: "FK_ClassTimetable_Classes_ClassesClassId",
                        column: x => x.ClassesClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTimetable_Timetables_TimetablesTimetableId",
                        column: x => x.TimetablesTimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayTimetable",
                columns: table => new
                {
                    DaysDayId = table.Column<int>(type: "int", nullable: false),
                    TimetablesTimetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayTimetable", x => new { x.DaysDayId, x.TimetablesTimetableId });
                    table.ForeignKey(
                        name: "FK_DayTimetable_Days_DaysDayId",
                        column: x => x.DaysDayId,
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayTimetable_Timetables_TimetablesTimetableId",
                        column: x => x.TimetablesTimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineTimetable",
                columns: table => new
                {
                    DisciplinesDisciplineId = table.Column<int>(type: "int", nullable: false),
                    TimetablesTimetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineTimetable", x => new { x.DisciplinesDisciplineId, x.TimetablesTimetableId });
                    table.ForeignKey(
                        name: "FK_DisciplineTimetable_Disciplines_DisciplinesDisciplineId",
                        column: x => x.DisciplinesDisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplineTimetable_Timetables_TimetablesTimetableId",
                        column: x => x.TimetablesTimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonTimetable",
                columns: table => new
                {
                    LessonsLessonId = table.Column<int>(type: "int", nullable: false),
                    TimetablesTimetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTimetable", x => new { x.LessonsLessonId, x.TimetablesTimetableId });
                    table.ForeignKey(
                        name: "FK_LessonTimetable_Lessons_LessonsLessonId",
                        column: x => x.LessonsLessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTimetable_Timetables_TimetablesTimetableId",
                        column: x => x.TimetablesTimetableId,
                        principalTable: "Timetables",
                        principalColumn: "TimetableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                    { "6934fd7d-d37c-49b0-9613-539f964eabd2", "96bbd76c-10d7-4385-aeb1-7bc1c27c41f2", "Admin", "ADMIN" },
                    { "b771c012-2461-4258-a2c8-9772ebbadaaa", "69745975-3b79-49e1-92b0-00fc2f831c8d", "Moderator", "MODERATOR" },
                    { "c9c3347a-89f9-4e49-a7d3-b7a90c549792", "9f95f175-6d2a-474e-b442-99b276586c25", "User", "USER" }
========
                    { "5e7ee416-f31d-4e6d-9614-62c77f0ec09f", "a99f5a28-bd9a-4c82-bb2b-4f972ae1072d", "Admin", "ADMIN" },
                    { "69797f60-b7a1-4c60-9ceb-99d534a9043b", "9309e9c1-336b-448d-91b2-ad508b4fd9c3", "Moderator", "MODERATOR" },
                    { "83f8e292-46dd-4a8f-afe5-04120f788094", "e7c0f7ba-ef8d-4d1a-a95d-6eb8cb02b546", "User", "USER" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                    { "79375854-e4c6-4614-b6f8-1eb4f3188e95", 0, "0e6ba2d4-d810-4428-85a9-526e7a3fd2ad", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEKPRYWCvm4D4tfg2yOfRCHe3QnzKlT9RWPZGl+rskUvIZmiTMpfDzSkSoT3p95xkbQ==", null, false, "8f6c0734-3e9e-4670-9e96-19a32c31a768", false, "moderator@rozkladschool.com" },
                    { "aa4b6839-1a0b-49b3-aefc-589cf99c81f5", 0, "cae1e9f7-b2b9-4418-a4de-8e5b33fc704d", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEA92CN8BtopQrsEQkPsONSihFsfYM6Y4qqFx/b+J0jABppJFeClE0K3rN/y8NEMf1g==", null, false, "02aca63f-dbf2-49c5-8655-8e1c1a7404d8", false, "user@rozkladschool.com" },
                    { "ca7e6123-56af-40f7-ad79-545c53c035f1", 0, "316869f8-a1b3-4d12-9e94-2ec788a99c81", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEJ/oAfRAkzmg+jXjZzgynypdhpqfm74JSItEoLKCqSdTthRp+XDYv3Y0MLEPyQ/5IA==", null, false, "1f16b1a6-0050-451f-8415-778088db2147", false, "admin@rozkladschool.com" }
========
                    { "4862ea87-77ea-4f1c-9e29-d4d433ebc856", 0, "2889c800-b333-49f8-aced-a52c7a9c7691", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEC87Ki5aJY7RanO5OzB1gmQDOVYa4rtt0oppQnPdgxWKwyX9DLnG+OwUnS/9+TEiWQ==", null, false, "a9c1d4d1-4688-4cf2-9753-dc18bedd30d8", false, "moderator@rozkladschool.com" },
                    { "8abee03e-a608-4cb6-8a20-309e5c6e920f", 0, "293c9b8a-d053-4410-8ea6-a93939d68590", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEAoiO/S+jdeb7xAKQ+y8xqr5fArePYRYh1BqchWWSMdTql4sfiKlC13nz3wKukGe/g==", null, false, "d17a7824-a5fb-4d25-b13b-d80298a9176b", false, "admin@rozkladschool.com" },
                    { "c31d168a-fec8-47a2-a682-c1bdd9a567db", 0, "417f1175-a397-4365-a92b-cda1812ff4e0", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEEzsTxS/mTqJcMkk0GffGoe++PQwMRirI1ZyEiruhak79NepYT9qpUldUZtq2IuMfA==", null, false, "cb6f7f9f-7b80-4235-86b6-54460d2b3ccb", false, "user@rozkladschool.com" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Cabinets",
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                columns: new[] { "CabinetId", "Name", "TimetableId" },
                values: new object[,]
                {
                    { 1, "Географія", null },
                    { 2, "Біологія", null },
                    { 3, "Математика", null },
                    { 4, "Укр мова", null },
                    { 5, "Історія", null }
========
                columns: new[] { "CabinetId", "Name" },
                values: new object[,]
                {
                    { 1, "Географія" },
                    { 2, "Біологія" },
                    { 3, "Математика" },
                    { 4, "Укр мова" },
                    { 5, "Історія" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Classes",
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                columns: new[] { "ClassId", "ClassName", "TimetableId" },
                values: new object[,]
                {
                    { 1, "", null },
                    { 2, "", null },
                    { 3, "", null },
                    { 4, "", null },
                    { 5, "", null }
========
                columns: new[] { "ClassId", "ClassName" },
                values: new object[,]
                {
                    { 1, "" },
                    { 2, "" },
                    { 3, "" },
                    { 4, "" },
                    { 5, "" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Days",
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                columns: new[] { "DayId", "DayName", "TimetableId" },
                values: new object[,]
                {
                    { 1, "Понеділок", null },
                    { 2, "Вівторок", null },
                    { 3, "Середа", null },
                    { 4, "Четвер", null },
                    { 5, "Пятниця", null }
========
                columns: new[] { "DayId", "DayName" },
                values: new object[,]
                {
                    { 1, "Понеділок" },
                    { 2, "Вівторок" },
                    { 3, "Середа" },
                    { 4, "Четвер" },
                    { 5, "Пятниця" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                columns: new[] { "DisciplineId", "DisciplineName", "TimetableId" },
                values: new object[,]
                {
                    { 1, "Географія", null },
                    { 2, "Біологія", null },
                    { 3, "Математика", null },
                    { 4, "Укр мова", null },
                    { 5, "Історія", null }
========
                columns: new[] { "DisciplineId", "DisciplineName" },
                values: new object[,]
                {
                    { 1, "Географія" },
                    { 2, "Біологія" },
                    { 3, "Математика" },
                    { 4, "Укр мова" },
                    { 5, "Історія" }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Lessons",
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                columns: new[] { "LessonId", "EndTime", "LessonNumber", "StartTime", "TimetableId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
========
                columns: new[] { "LessonId", "EndTime", "LessonNumber", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs
                });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassId", "DayId", "DisciplineId", "LessonId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:RozkladSchool/Rozklad.Core/Migrations/20221018165529_output.cs
                values: new object[,]
                {
                    { "b771c012-2461-4258-a2c8-9772ebbadaaa", "79375854-e4c6-4614-b6f8-1eb4f3188e95" },
                    { "c9c3347a-89f9-4e49-a7d3-b7a90c549792", "79375854-e4c6-4614-b6f8-1eb4f3188e95" },
                    { "c9c3347a-89f9-4e49-a7d3-b7a90c549792", "aa4b6839-1a0b-49b3-aefc-589cf99c81f5" },
                    { "6934fd7d-d37c-49b0-9613-539f964eabd2", "ca7e6123-56af-40f7-ad79-545c53c035f1" },
                    { "b771c012-2461-4258-a2c8-9772ebbadaaa", "ca7e6123-56af-40f7-ad79-545c53c035f1" },
                    { "c9c3347a-89f9-4e49-a7d3-b7a90c549792", "ca7e6123-56af-40f7-ad79-545c53c035f1" }
                });
========
                values: new object[] { "5e7ee416-f31d-4e6d-9614-62c77f0ec09f", "8abee03e-a608-4cb6-8a20-309e5c6e920f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "83f8e292-46dd-4a8f-afe5-04120f788094", "8abee03e-a608-4cb6-8a20-309e5c6e920f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "83f8e292-46dd-4a8f-afe5-04120f788094", "c31d168a-fec8-47a2-a682-c1bdd9a567db" });
>>>>>>>> main:RozkladSchool/Rozklad.Core/Migrations/20221019131010_firstmig.cs

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
                name: "IX_CabinetTimetable_TimetablesTimetableId",
                table: "CabinetTimetable",
                column: "TimetablesTimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTimetable_TimetablesTimetableId",
                table: "ClassTimetable",
                column: "TimetablesTimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_DayTimetable_TimetablesTimetableId",
                table: "DayTimetable",
                column: "TimetablesTimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineTimetable_TimetablesTimetableId",
                table: "DisciplineTimetable",
                column: "TimetablesTimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTimetable_TimetablesTimetableId",
                table: "LessonTimetable",
                column: "TimetablesTimetableId");
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
                name: "CabinetTimetable");

            migrationBuilder.DropTable(
                name: "ClassTimetable");

            migrationBuilder.DropTable(
                name: "DayTimetable");

            migrationBuilder.DropTable(
                name: "DisciplineTimetable");

            migrationBuilder.DropTable(
                name: "LessonTimetable");

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

            migrationBuilder.DropTable(
                name: "Timetables");
        }
    }
}
