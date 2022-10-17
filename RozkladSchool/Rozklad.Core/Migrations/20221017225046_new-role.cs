using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class newrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "86e01288-e26f-4191-929e-c794c2b19567", "89bac5f0-6cf8-446b-aa86-629aae279f76", "Admin", "ADMIN" },
                    { "917d0a25-8533-446d-9284-dc31e2cb3d10", "22f11672-2062-4c77-9224-92f3d75d63f3", "User", "USER" },
                    { "b7d85f35-3038-4425-a03b-9fd78b6e8966", "37ef8341-0ccb-44c6-a2c6-3db2f3dc897f", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31371810-24c2-4fcb-98f0-c7804afb810a", 0, "903b3912-41d2-4e5d-a5c3-f7db7f511ef2", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEIvTzKfS32x8RdZ/3VTW7uNV+Ez8sfLtpaNVPek26H+nvIDnJNGrBD+9d0bmbdiJ6g==", null, false, "c8bce520-78a5-4511-867e-85dbd2f810ef", false, "user@rozkladschool.com" },
                    { "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41", 0, "97cca10e-2128-4b1e-9028-36bc21d3d208", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEOOkomGYK7CmXZmutfykPMXRt3U/m/UIBCn+H6q0siYDl21HZakl9+hdOQxYDxXkLA==", null, false, "20007a3a-fc93-4096-9b63-04899aee8b2c", false, "admin@rozkladschool.com" },
                    { "a2f69a56-373a-47f6-991a-8e431466688e", 0, "4273c957-f2fc-4589-8653-0d2a005b257a", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAENUCem4Rci2rToUSYXTS5FIqRDtUhIm7d3k+UlbxdG8lDKawEFvYigoAiqrZFJyFwQ==", null, false, "b0b4a5b3-c643-47cd-8988-fe5ab321286f", false, "moderator@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "917d0a25-8533-446d-9284-dc31e2cb3d10", "31371810-24c2-4fcb-98f0-c7804afb810a" },
                    { "86e01288-e26f-4191-929e-c794c2b19567", "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41" },
                    { "917d0a25-8533-446d-9284-dc31e2cb3d10", "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41" },
                    { "917d0a25-8533-446d-9284-dc31e2cb3d10", "a2f69a56-373a-47f6-991a-8e431466688e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7d85f35-3038-4425-a03b-9fd78b6e8966");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "917d0a25-8533-446d-9284-dc31e2cb3d10", "31371810-24c2-4fcb-98f0-c7804afb810a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86e01288-e26f-4191-929e-c794c2b19567", "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "917d0a25-8533-446d-9284-dc31e2cb3d10", "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "917d0a25-8533-446d-9284-dc31e2cb3d10", "a2f69a56-373a-47f6-991a-8e431466688e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86e01288-e26f-4191-929e-c794c2b19567");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "917d0a25-8533-446d-9284-dc31e2cb3d10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31371810-24c2-4fcb-98f0-c7804afb810a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71e774ee-3e7d-4bf1-88fd-4a3ff0e0cc41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2f69a56-373a-47f6-991a-8e431466688e");

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
    }
}
