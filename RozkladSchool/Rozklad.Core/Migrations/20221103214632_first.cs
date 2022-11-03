using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class first : Migration
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
                    CabinetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinets", x => x.CabinetId);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ClassRoomId);
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
                name: "Pupils",
                columns: table => new
                {
                    PupilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PupilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.PupilId);
                    table.ForeignKey(
                        name: "FK_Pupils_ClassRooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRooms",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    PupilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "PupilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Teachers_TeacherId",
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
                    LessonNumber = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CabinetId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.TimetableId);
                    table.ForeignKey(
                        name: "FK_Timetables_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Timetables_Cabinets_CabinetId",
                        column: x => x.CabinetId,
                        principalTable: "Cabinets",
                        principalColumn: "CabinetId",
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
                    { "11fc7059-8e8f-4b4f-a9bb-824064fff6fe", "01bab073-5d42-4030-a246-fd3be16986bf", "User", "USER" },
                    { "73f797a3-9b3a-41ca-ad1d-e6d5250539da", "0f9e5f04-f7d1-472f-986f-82eca61f5386", "Admin", "ADMIN" },
                    { "ae6eba23-67e5-41f2-a5ad-71b670b64797", "b432f2e5-6517-4f1f-ae00-39a3c42db933", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15bfeabb-cb08-4c88-95bb-af3b199ecb92", 0, "c2c02e75-e989-42ed-9c31-fd22164017d6", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEIkAfgn59cK9OI1wiQq5jmiS4KXweUxgvdcP0e59EB1f24J0qvCETqCrZtzQsxXAYA==", null, false, "8c88886c-1f3c-4e7d-808d-b3872e488099", false, "admin@rozkladschool.com" },
                    { "8679fe64-0be2-443d-8159-5f7bbe59641e", 0, "91cfef87-459a-4766-bf31-f851ae731969", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEDH9kAix1e/v6qglLxLbA735OT9m33PCM+5o6VUi3zdf+rOOuObweimnD27mBHD5Bw==", null, false, "f6ce31fa-a4b7-4f22-b2a6-d9bfb51eaba2", false, "moderator@rozkladschool.com" },
                    { "87af35a1-3244-46ea-a929-04c7cff48498", 0, "6ba3774f-1946-4668-9ee0-9826ae88addb", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAELYi7t+znzSB4kPe/tdgaEPt9cr8cFWXU+KkVXMcTdJSF+ZTr/BMnxBX5EGJW3k4mw==", null, false, "bcdbe2d9-b999-4e6e-b8e1-6b09bd6ff562", false, "user@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "Cabinets",
                columns: new[] { "CabinetId", "CabinetName", "RoomCapacity" },
                values: new object[,]
                {
                    { 1, "GeographyLab", 0 },
                    { 2, "BiologyLab", 0 },
                    { 3, "MathLab", 0 }
                });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "ClassRoomName", "Year" },
                values: new object[,]
                {
                    { 1, "1-A", 1 },
                    { 2, "1-B", 1 },
                    { 3, "2-A", 2 }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "DisciplineId", "DisciplineName" },
                values: new object[,]
                {
                    { 1, "Geography" },
                    { 2, "Biology" },
                    { 3, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TeacherName" },
                values: new object[,]
                {
                    { 1, "Kvashuk O.V." },
                    { 2, "Zubenko I.R." },
                    { 3, "Popchuk M.A." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "11fc7059-8e8f-4b4f-a9bb-824064fff6fe", "15bfeabb-cb08-4c88-95bb-af3b199ecb92" },
                    { "73f797a3-9b3a-41ca-ad1d-e6d5250539da", "15bfeabb-cb08-4c88-95bb-af3b199ecb92" },
                    { "11fc7059-8e8f-4b4f-a9bb-824064fff6fe", "87af35a1-3244-46ea-a929-04c7cff48498" }
                });

            migrationBuilder.InsertData(
                table: "Pupils",
                columns: new[] { "PupilId", "ClassRoomId", "IconPath", "PupilName", "Year" },
                values: new object[,]
                {
                    { 1, 1, "Images\\1200h790_1-4_klass_t.png", "Belinskiy O.O", 1 },
                    { 2, 2, "Images\\1200h790_1-4_klass_t.png", "Koshubinskiy P.R", 1 },
                    { 3, 3, "Images\\1200h790_1-4_klass_t.png", "Bohach V.E", 2 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "DisciplineId", "LessonName", "PupilId", "TeacherId", "Year" },
                values: new object[] { 1, 1, "Geography, 1-st year, 1-A clas", 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "DisciplineId", "LessonName", "PupilId", "TeacherId", "Year" },
                values: new object[] { 2, 2, "Biology, 1-st year, 1-B clas", 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "DisciplineId", "LessonName", "PupilId", "TeacherId", "Year" },
                values: new object[] { 3, 3, "Math, 2-st year, 2-A clas", 3, 3, 2 });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "Day", "LessonId", "LessonNumber", "TimeEnd", "TimeStart", "UserId" },
                values: new object[] { 1, 1, "Monday", 1, 1, "9:45", "9:00", null });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "Day", "LessonId", "LessonNumber", "TimeEnd", "TimeStart", "UserId" },
                values: new object[] { 2, 2, "Tuesday", 2, 2, "10:45", "10:00", null });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "CabinetId", "Day", "LessonId", "LessonNumber", "TimeEnd", "TimeStart", "UserId" },
                values: new object[] { 3, 3, "Wednesday", 3, 3, "11:45", "11:00", null });

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
                name: "IX_Lessons_DisciplineId",
                table: "Lessons",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_PupilId",
                table: "Lessons",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TeacherId",
                table: "Lessons",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_ClassRoomId",
                table: "Pupils",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_CabinetId",
                table: "Timetables",
                column: "CabinetId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_LessonId",
                table: "Timetables",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_UserId",
                table: "Timetables",
                column: "UserId");
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
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Pupils");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "ClassRooms");
        }
    }
}
