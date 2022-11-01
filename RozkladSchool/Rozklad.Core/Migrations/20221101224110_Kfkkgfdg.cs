using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class Kfkkgfdg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91ac6f4d-eee6-44ba-9dd4-01d684957fea", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8873450-7d37-4bb0-bf05-f63b95e508cc", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "49c43f35-8a90-4eff-a277-c50542db7d6c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "e1013275-165a-419c-9e01-105c5295141f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8873450-7d37-4bb0-bf05-f63b95e508cc", "e1013275-165a-419c-9e01-105c5295141f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91ac6f4d-eee6-44ba-9dd4-01d684957fea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8873450-7d37-4bb0-bf05-f63b95e508cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17373436-a14b-4e95-bd3e-1b1ceeaca1fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49c43f35-8a90-4eff-a277-c50542db7d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1013275-165a-419c-9e01-105c5295141f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4bd71e05-0f77-460e-9b56-f35ebd059d84", "54bac86c-68c6-4f3e-9e9d-d9e1630617eb", "Moderator", "MODERATOR" },
                    { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "0137c60e-3414-4472-9fc7-72a6128fcb78", "User", "USER" },
                    { "a2ec1c14-d8a6-4bfe-ba68-8cdd5b9f7fe6", "a3bbf469-c1ff-4307-96cb-f13a66c0f07c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac", 0, "f11cb17f-e222-41d5-8e8d-757e0bef0d7a", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEFyGprb28wyLvZSJipaVhZF2mQgWk+0gY/w8KpCyK751kG345ogEn3fHir2D7SjJxg==", null, false, "76b59026-9922-47a7-b1ad-62d75c8bae8f", false, "moderator@rozkladschool.com" },
                    { "82148c97-32d1-4c4c-b455-f7492454b490", 0, "c24fc272-2ab5-470d-afca-2580f452c7e4", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEO7Mc/0E/w04TLhz406XTWDoThk0kwSiT01ndX0Q+R96ZY2V76a94nTbEOFfk8K/HA==", null, false, "b6fcd712-7144-4a4c-9ee7-9c21476f01b5", false, "user@rozkladschool.com" },
                    { "dbe06bc0-6547-4a20-9106-88d63961f350", 0, "ae7bd489-8e1f-443a-aa5a-a2110e09e32b", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEImcnToRINk8h64WNPtX5UzOtIxXMbW2OlDXMonShVMAMuzOyJFvyifKd693WllQsw==", null, false, "2cd0004c-ab21-46dd-853d-e2e4b623d060", false, "admin@rozkladschool.com" }
                });

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 1,
                column: "CabinetName",
                value: "GeographyLab");

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 2,
                column: "CabinetName",
                value: "BiologyLab");

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 3,
                column: "CabinetName",
                value: "MathLab");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 2,
                column: "ClassRoomName",
                value: "1-B");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 1,
                column: "DisciplineName",
                value: "Geography");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 2,
                column: "DisciplineName",
                value: "Biology");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 3,
                column: "DisciplineName",
                value: "Math");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                column: "LessonName",
                value: "Geography, 1-st year, 1-A clas");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                column: "LessonName",
                value: "Biology, 1-st year, 1-B clas");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                column: "LessonName",
                value: "Math, 2-st year, 2-A clas");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 1,
                column: "PupilName",
                value: "Belinskiy O.O");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 2,
                column: "PupilName",
                value: "Koshubinskiy P.R");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 3,
                column: "PupilName",
                value: "Bohach V.E");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "TeacherName",
                value: "Kvashuk O.V.");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "TeacherName",
                value: "Zubenko I.R.");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "TeacherName",
                value: "Popchuk M.A.");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 1,
                column: "Day",
                value: "Monday");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 2,
                column: "Day",
                value: "Tuesday");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 3,
                column: "Day",
                value: "Wednesday");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4bd71e05-0f77-460e-9b56-f35ebd059d84", "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac" },
                    { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac" },
                    { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "82148c97-32d1-4c4c-b455-f7492454b490" },
                    { "4bd71e05-0f77-460e-9b56-f35ebd059d84", "dbe06bc0-6547-4a20-9106-88d63961f350" },
                    { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "dbe06bc0-6547-4a20-9106-88d63961f350" },
                    { "a2ec1c14-d8a6-4bfe-ba68-8cdd5b9f7fe6", "dbe06bc0-6547-4a20-9106-88d63961f350" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bd71e05-0f77-460e-9b56-f35ebd059d84", "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "82148c97-32d1-4c4c-b455-f7492454b490" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bd71e05-0f77-460e-9b56-f35ebd059d84", "dbe06bc0-6547-4a20-9106-88d63961f350" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5217c34f-c94b-4cd0-97de-41d6c2e96a9e", "dbe06bc0-6547-4a20-9106-88d63961f350" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2ec1c14-d8a6-4bfe-ba68-8cdd5b9f7fe6", "dbe06bc0-6547-4a20-9106-88d63961f350" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bd71e05-0f77-460e-9b56-f35ebd059d84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5217c34f-c94b-4cd0-97de-41d6c2e96a9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2ec1c14-d8a6-4bfe-ba68-8cdd5b9f7fe6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d3aa3d8-a40f-4640-b9ab-57cc7a2dabac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82148c97-32d1-4c4c-b455-f7492454b490");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbe06bc0-6547-4a20-9106-88d63961f350");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91ac6f4d-eee6-44ba-9dd4-01d684957fea", "9509be73-8995-4b29-8868-6d9280627486", "Admin", "ADMIN" },
                    { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "5c90d634-9881-41f3-90d7-9d7ef2147634", "User", "USER" },
                    { "c8873450-7d37-4bb0-bf05-f63b95e508cc", "626ffe1a-e191-41c9-a250-4687639196bd", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17373436-a14b-4e95-bd3e-1b1ceeaca1fd", 0, "8426ab97-a6a4-4b2d-980c-96fc818de965", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEDUaLDL8r42lLUEeJT0lLYYc6LCA7FRV3S/GZqyV3ETKgUEfDx84EgxnO7158BlJsQ==", null, false, "e1bf55fe-1364-4907-abc8-999188aea8e4", false, "admin@rozkladschool.com" },
                    { "49c43f35-8a90-4eff-a277-c50542db7d6c", 0, "019749b8-5daf-4fcc-8373-d6a18af585bd", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEM0A5EhN0IN2aCo85K79HDQFdVR6+aAxmS7mRi0d9jThYHwhLPwnnmRfWuyHBx9yLw==", null, false, "daa2c754-10dc-4cbf-a7d2-88152736ed1a", false, "user@rozkladschool.com" },
                    { "e1013275-165a-419c-9e01-105c5295141f", 0, "6cb2d62d-a1cb-4413-8122-aa10201f9c9f", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAECRszaPd87+qQEdeJ6Hs0p3qL5DeKxoiU9OgFqrS7aTQ/DqyVLSd1fK9Rqck17oaHw==", null, false, "7d8a947f-a2a6-4712-8ece-d10078fc8f7d", false, "moderator@rozkladschool.com" }
                });

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 1,
                column: "CabinetName",
                value: "Географія");

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 2,
                column: "CabinetName",
                value: "Біологія");

            migrationBuilder.UpdateData(
                table: "Cabinets",
                keyColumn: "CabinetId",
                keyValue: 3,
                column: "CabinetName",
                value: "Математика");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 2,
                column: "ClassRoomName",
                value: "1-Б");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 1,
                column: "DisciplineName",
                value: "Географія");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 2,
                column: "DisciplineName",
                value: "Біологія");

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 3,
                column: "DisciplineName",
                value: "Математика");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                column: "LessonName",
                value: "Географія, 1-й рік, 1-А клас");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                column: "LessonName",
                value: "Біологія, 1-й рік, 1-Б клас");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                column: "LessonName",
                value: "Математика, 2-й рік, 2-А клас");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 1,
                column: "PupilName",
                value: "Белінський О.О");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 2,
                column: "PupilName",
                value: "Кошубінський П.Р");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 3,
                column: "PupilName",
                value: "Богач В.Е");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "TeacherName",
                value: "Квашук О.В.");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "TeacherName",
                value: "Зубенко І.Р.");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "TeacherName",
                value: "Попчук М.А.");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 1,
                column: "Day",
                value: "Понеділок");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 2,
                column: "Day",
                value: "Вівторок");

            migrationBuilder.UpdateData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 3,
                column: "Day",
                value: "Середа");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "91ac6f4d-eee6-44ba-9dd4-01d684957fea", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" },
                    { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" },
                    { "c8873450-7d37-4bb0-bf05-f63b95e508cc", "17373436-a14b-4e95-bd3e-1b1ceeaca1fd" },
                    { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "49c43f35-8a90-4eff-a277-c50542db7d6c" },
                    { "a432d9e5-62a1-4cd4-8b92-dc5d910e5b22", "e1013275-165a-419c-9e01-105c5295141f" },
                    { "c8873450-7d37-4bb0-bf05-f63b95e508cc", "e1013275-165a-419c-9e01-105c5295141f" }
                });
        }
    }
}
