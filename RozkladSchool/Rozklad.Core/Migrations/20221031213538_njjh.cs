using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class njjh : Migration
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
                    CabinetName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinets", x => x.CabinetId);
                });

            migrationBuilder.CreateTable(
                name: "Pupils",
                columns: table => new
                {
                    PupilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PupilName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.PupilId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
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
                name: "ClassRooms",
                columns: table => new
                {
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PupilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ClassRoomId);
                    table.ForeignKey(
                        name: "FK_ClassRooms_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "PupilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    DisciplineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.DisciplineId);
                    table.ForeignKey(
                        name: "FK_Disciplines_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timetables",
                columns: table => new
                {
                    TimetableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    LessonNumber = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Timetables_ClassRooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRooms",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3512e124-e932-4092-ba32-3ca7f023573a", "26a37d62-a40a-45b8-8e28-939e2d635bb5", "Moderator", "MODERATOR" },
                    { "93beed3f-22fe-483e-9a95-42e3182041fb", "c80fd94b-3068-4fa7-9c9a-b5c7b9c26f7d", "Admin", "ADMIN" },
                    { "940ca708-595f-4ed7-8313-7e77e93ef064", "8392f2f1-fc63-46e0-88fa-763914525576", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24f50eea-9368-46a7-904a-c7cbee59defa", 0, "308f657b-67b6-49ea-928a-e3b5d1ae3da8", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAELfbVLE0oiOgDb6lPbSfZUTxsjdpcCu0ZqaYNcrybYkW/wKN4VgDPB1frO2K6c0fhw==", null, false, "ab3c6e0c-c91e-4b87-a5af-bfa8e9c63e1b", false, "user@rozkladschool.com" },
                    { "cedbbb78-2302-4cc5-b72e-a17943563f4d", 0, "8a4559c0-9a60-4579-b289-40ccb494f0ed", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEOFmGx0VUKj5iC5PCua5008umKSnhyQHrSVXzNt6QwzWGrf9vGuKubhoStNDhnE+MA==", null, false, "9c48b9d5-bec9-4dce-aac6-dec5dc51a433", false, "admin@rozkladschool.com" },
                    { "ff1d308a-324a-4063-bbcf-863d6fbc3639", 0, "2c8cf925-4376-4864-8c8c-ffda07f0637e", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEJ5BVtXN0pRcxgF8NExvhxUlsfSIJcJRllM4d3nTqBVveKMCRscf1nLIdOCKy5Tqyg==", null, false, "0a19bf86-b822-40b6-931f-a3c692a17407", false, "moderator@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "Cabinets",
                columns: new[] { "CabinetId", "CabinetName" },
                values: new object[,]
                {
                    { 1, "Географія" },
                    { 2, "Біологія" },
                    { 3, "Математика" }
                });

            migrationBuilder.InsertData(
                table: "Pupils",
                columns: new[] { "PupilId", "PupilName" },
                values: new object[,]
                {
                    { 1, "Белінський О.О" },
                    { 2, "Кошубінський П.Р" },
                    { 3, "Богач В.Е" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TeacherName" },
                values: new object[,]
                {
                    { 1, "Квашук О.В." },
                    { 2, "Зубенко І.Р." },
                    { 3, "Попчук М.А." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "940ca708-595f-4ed7-8313-7e77e93ef064", "24f50eea-9368-46a7-904a-c7cbee59defa" },
                    { "3512e124-e932-4092-ba32-3ca7f023573a", "cedbbb78-2302-4cc5-b72e-a17943563f4d" },
                    { "93beed3f-22fe-483e-9a95-42e3182041fb", "cedbbb78-2302-4cc5-b72e-a17943563f4d" },
                    { "940ca708-595f-4ed7-8313-7e77e93ef064", "cedbbb78-2302-4cc5-b72e-a17943563f4d" },
                    { "3512e124-e932-4092-ba32-3ca7f023573a", "ff1d308a-324a-4063-bbcf-863d6fbc3639" },
                    { "940ca708-595f-4ed7-8313-7e77e93ef064", "ff1d308a-324a-4063-bbcf-863d6fbc3639" }
                });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "ClassRoomName", "PupilId" },
                values: new object[,]
                {
                    { 1, "1-A", 1 },
                    { 2, "1-Б", 2 },
                    { 3, "2-A", 3 }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "DisciplineId", "DisciplineName", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Географія", 1 },
                    { 2, "Біологія", 2 },
                    { 3, "Математика", 3 }
                });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassRoomId", "Day", "DisciplineId", "IconPath", "LessonNumber", "TimeEnd", "TimeStart" },
                values: new object[] { 1, 1, 1, "Понеділок", 1, "Images\\1200h790_1-4_klass_t.png", 1, "9:45", "9:00" });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassRoomId", "Day", "DisciplineId", "IconPath", "LessonNumber", "TimeEnd", "TimeStart" },
                values: new object[] { 2, 2, 2, "Вівторок", 2, "Images\\1200h790_1-4_klass_t.png", 2, "10:45", "10:00" });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassRoomId", "Day", "DisciplineId", "IconPath", "LessonNumber", "TimeEnd", "TimeStart" },
                values: new object[] { 3, 3, 3, "Середа", 3, "Images\\1200h790_1-4_klass_t.png", 3, "11:45", "11:00" });

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
                name: "IX_ClassRooms_PupilId",
                table: "ClassRooms",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Disciplines",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_CabinetId",
                table: "Timetables",
                column: "CabinetId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_ClassRoomId",
                table: "Timetables",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_DisciplineId",
                table: "Timetables",
                column: "DisciplineId");
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
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Pupils");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
