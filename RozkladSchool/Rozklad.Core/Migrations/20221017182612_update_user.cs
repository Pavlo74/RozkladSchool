using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class update_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "072185fd-2cda-4880-b76d-925abbc4844e", "b4b8242e-1c46-4be0-870f-fdccd751c18c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8c16eb5-4aee-4d37-b131-f99ef176d8b7", "b4b8242e-1c46-4be0-870f-fdccd751c18c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8c16eb5-4aee-4d37-b131-f99ef176d8b7", "f3cfcbc8-d53a-48b9-8305-ea4a11bc5a43" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "072185fd-2cda-4880-b76d-925abbc4844e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c16eb5-4aee-4d37-b131-f99ef176d8b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4b8242e-1c46-4be0-870f-fdccd751c18c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3cfcbc8-d53a-48b9-8305-ea4a11bc5a43");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "436113e0-b74b-40ba-8f4d-9adbe79f12e0", "89d9314e-335c-40ab-a405-b0130e55ca1e", "User", "USER" },
                    { "da7fdea2-d91f-4b8a-a1e1-a7e2bb8302b9", "04264dbc-e88d-44cb-a2ed-ed0c87b77092", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "543be1f1-3766-456e-b348-0e32684ad812", 0, "25d729c3-0637-4de1-9de5-e74559dc0137", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEJIZ1MYrfTgVdOW6JP1YeVszgcL6fHMerorExM47tw4AF/ao8nHiHJ36DDoRpqLvgQ==", null, false, "2d9f1eb1-7edb-46e3-8618-ddb6707ef111", false, "admin@rozkladschool.com" },
                    { "917ebc1f-f334-4878-a141-1e9ca8d95b01", 0, "01384881-86eb-42e0-9826-ee957b7a7037", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEJEAcXUKf8fSvVUSOzbH2aA4bl4VCwYA7JpUH/ft/L3O+pjsmL6iyXlSV/rFayP7Wg==", null, false, "1275158e-b6c3-46bb-b545-e224b2d6328c", false, "user@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "436113e0-b74b-40ba-8f4d-9adbe79f12e0", "543be1f1-3766-456e-b348-0e32684ad812" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "da7fdea2-d91f-4b8a-a1e1-a7e2bb8302b9", "543be1f1-3766-456e-b348-0e32684ad812" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "436113e0-b74b-40ba-8f4d-9adbe79f12e0", "917ebc1f-f334-4878-a141-1e9ca8d95b01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "436113e0-b74b-40ba-8f4d-9adbe79f12e0", "543be1f1-3766-456e-b348-0e32684ad812" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da7fdea2-d91f-4b8a-a1e1-a7e2bb8302b9", "543be1f1-3766-456e-b348-0e32684ad812" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "436113e0-b74b-40ba-8f4d-9adbe79f12e0", "917ebc1f-f334-4878-a141-1e9ca8d95b01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436113e0-b74b-40ba-8f4d-9adbe79f12e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da7fdea2-d91f-4b8a-a1e1-a7e2bb8302b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "543be1f1-3766-456e-b348-0e32684ad812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "917ebc1f-f334-4878-a141-1e9ca8d95b01");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "072185fd-2cda-4880-b76d-925abbc4844e", "8643cfd1-cc90-4b37-880a-981912aeeec5", "User", "USER" },
                    { "c8c16eb5-4aee-4d37-b131-f99ef176d8b7", "b906f61d-b6e9-457c-9a09-bedb2fe86196", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b4b8242e-1c46-4be0-870f-fdccd751c18c", 0, "78ec1ba8-cd05-4def-b96a-e4baa17c0356", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEA+ZsxPRJqaZIRjFduc8SgIAJJhFiOe24DULGLWFGNbjbVvHdr8V81anImUdtTP2hQ==", null, false, "330ee08a-d9bd-4027-a08c-9cd2a2c8d602", false, "user@rozkladschool.com" },
                    { "f3cfcbc8-d53a-48b9-8305-ea4a11bc5a43", 0, "8841e4bf-70b4-414c-a048-ba48caa5f622", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEH4RaYlSDAvKeYlYr+JCZ7mkVgCYqAiSaw4vOC+7Eictqh4QqNWIs2nB4wKrEndBcA==", null, false, "ba3fa142-150e-4fa8-8537-fee2a165df06", false, "admin@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "072185fd-2cda-4880-b76d-925abbc4844e", "b4b8242e-1c46-4be0-870f-fdccd751c18c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8c16eb5-4aee-4d37-b131-f99ef176d8b7", "b4b8242e-1c46-4be0-870f-fdccd751c18c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8c16eb5-4aee-4d37-b131-f99ef176d8b7", "f3cfcbc8-d53a-48b9-8305-ea4a11bc5a43" });
        }
    }
}
