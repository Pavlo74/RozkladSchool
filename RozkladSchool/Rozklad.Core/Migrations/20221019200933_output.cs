using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class output : Migration
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
                    { "5d8364d0-642a-4fa8-a0cd-10728d91320a", "2754900d-adb7-4dfe-be5f-a0cb829cff71", "User", "USER" },
                    { "bb0e3f2c-21ee-46ac-9c97-aaf5c23ce125", "f6d5df3f-f077-47af-8593-9443475ac377", "Admin", "ADMIN" },
                    { "ef3bb4c1-7ef8-45b8-84cc-58e8a5a6f455", "9c9848c0-2fb9-4ee4-acfb-6b48103bce95", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08b84508-f6ab-4289-a03a-e7a281f6982a", 0, "040a30e1-10fa-47f1-b58b-ed7ad68a254e", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEP0MmalUNUQ5G6odqj0llIpHnTpov5fQtgaxz5iLoyG4fJv1sruzi+ReQvzhr+ds+A==", null, false, "36b7fa25-224a-405b-a260-747d2a0726ab", false, "moderator@rozkladschool.com" },
                    { "81d9d1a8-4b38-45ad-84ca-4f4a53960d25", 0, "a266ce4a-f9f9-4841-b030-bb1fffa7549d", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEEwMFjUOBxjSPLnLWyFIwA2qVJGjp3xlDs1RkhupjBsc/yJ1QSitgqmHUlqHrHgaRw==", null, false, "4e937273-03db-40f2-ae5b-ecb944ce5229", false, "user@rozkladschool.com" },
                    { "9d355ca9-7109-40ed-a331-b53b003c8be6", 0, "fe30b8f3-cbec-4c72-95a0-f1d1f4689d91", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEEdhvdt0tqv32H5/G8F1c1zgWmm2yiZhWAtSafzKGcF72f7/UxM+05o8zW8wOtFCrA==", null, false, "c7cf7c83-15bf-4cf1-996f-08999035d475", false, "admin@rozkladschool.com" }
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
                    { "5d8364d0-642a-4fa8-a0cd-10728d91320a", "08b84508-f6ab-4289-a03a-e7a281f6982a" },
                    { "ef3bb4c1-7ef8-45b8-84cc-58e8a5a6f455", "08b84508-f6ab-4289-a03a-e7a281f6982a" },
                    { "5d8364d0-642a-4fa8-a0cd-10728d91320a", "81d9d1a8-4b38-45ad-84ca-4f4a53960d25" },
                    { "5d8364d0-642a-4fa8-a0cd-10728d91320a", "9d355ca9-7109-40ed-a331-b53b003c8be6" },
                    { "bb0e3f2c-21ee-46ac-9c97-aaf5c23ce125", "9d355ca9-7109-40ed-a331-b53b003c8be6" },
                    { "ef3bb4c1-7ef8-45b8-84cc-58e8a5a6f455", "9d355ca9-7109-40ed-a331-b53b003c8be6" }
                });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "ClassId", "DayId", "DisciplineId", "LessonId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 2, 2, 2 }
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
