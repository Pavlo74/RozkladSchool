using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class sho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4372075b-1b7f-41dc-8d32-010bf733b07e", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f16ba2e4-c460-4ed5-9287-b2eeb3faada7", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "4fd6d94c-2692-444c-9079-3daeef9467e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "552ba482-f2b9-4932-bc3c-2b29aa23a840" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4372075b-1b7f-41dc-8d32-010bf733b07e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f16ba2e4-c460-4ed5-9287-b2eeb3faada7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "467dbd8c-e47a-431d-b611-be8d8a8fb4af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd6d94c-2692-444c-9079-3daeef9467e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "552ba482-f2b9-4932-bc3c-2b29aa23a840");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "222b7878-0a1e-4b15-83ed-67ba5243141f", "User", "USER" },
                    { "9fd1a930-4410-43b6-b789-1a0a4632a45f", "bd69cdd8-9858-4de6-bf0b-f90226958d25", "Moderator", "MODERATOR" },
                    { "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1", "d5bf66c4-9f95-4359-b8dc-17b20cbcad8c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f54936b-f4b0-4f8a-93d0-dc26538e3681", 0, "2ac04be0-42e1-4b44-86bd-b4c9ce6e759a", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEBB4ZRgXKoaxlmrYlFv76GKzb1tHH9D9kAE0RNteOHAMUhQBVTMgSHDtombtD45odA==", null, false, "cbaccb02-a37b-4270-8ae5-3cf48181fede", false, "user@rozkladschool.com" },
                    { "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e", 0, "1806f973-b3e4-457a-a40d-5ce836aa7fd7", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEI+XeJlEwv16Jk0D1bctfkCTfrNWu9XgrzckT8jJ6KIWqEUnPcMzXMPB2CC2yPwpZw==", null, false, "f1cdcd3e-b114-4feb-a845-cb1729d2b00d", false, "admin@rozkladschool.com" },
                    { "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca", 0, "793d4e29-d14e-41bc-98ef-97d3aa1c2e57", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEGzkYYmuS0s3PxzT22g2LWJ52h87gLJP70JtPeIOkJ4x4wvDbP62sw8bqMKWiRqQrA==", null, false, "623a7f9c-8069-44f4-92c4-2ffb42629c37", false, "moderator@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "1f54936b-f4b0-4f8a-93d0-dc26538e3681" },
                    { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" },
                    { "9fd1a930-4410-43b6-b789-1a0a4632a45f", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" },
                    { "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" },
                    { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "1f54936b-f4b0-4f8a-93d0-dc26538e3681" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9fd1a930-4410-43b6-b789-1a0a4632a45f", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1", "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a4ce891-ab9a-42e6-a049-15b763a2a093", "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4ce891-ab9a-42e6-a049-15b763a2a093");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fd1a930-4410-43b6-b789-1a0a4632a45f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f05a4d-5c46-4a72-9e24-b8f9ca91dae1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f54936b-f4b0-4f8a-93d0-dc26538e3681");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d76b1da-c4a3-4fd7-8ef4-5a3990ad116e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c9a2c8-5523-4f3f-a3ea-f862a96afeca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4372075b-1b7f-41dc-8d32-010bf733b07e", "0c62e6c9-c701-4aad-8a65-b0c0eb011401", "Moderator", "MODERATOR" },
                    { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "8f25cbd4-214c-4d30-84e3-f1bd0a38091b", "User", "USER" },
                    { "f16ba2e4-c460-4ed5-9287-b2eeb3faada7", "613152ea-0744-463a-acc1-c35d837782c7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "467dbd8c-e47a-431d-b611-be8d8a8fb4af", 0, "647695bf-cf62-4c3c-883d-b9f1475fc375", "admin@rozkladschool.com", true, null, null, false, null, "ADMIN@ROZKLADSCHOOL.COM", "ADMIN@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEKIDg21kcStvYHOpwLzi9RiyERNqma6+AWdrqAVCyPdgL5hT8iJhtFESpLRj4a2RhA==", null, false, "d8b90b95-c731-439f-9570-b6a172dbf259", false, "admin@rozkladschool.com" },
                    { "4fd6d94c-2692-444c-9079-3daeef9467e9", 0, "976c4ba1-4333-4eea-b043-0ac24d279287", "user@rozkladschool.com", true, null, null, false, null, "USER@ROZKLADSCHOOL.COM", "USER@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAECVDRfEVo+jqLzz/lwXkqrEXY9r53LpjsMspmxATrjOVVfj7Fz8DW2DfRMnzjV8u/Q==", null, false, "0a8e4862-d7ae-48b1-a4a4-b23f01e26f50", false, "user@rozkladschool.com" },
                    { "552ba482-f2b9-4932-bc3c-2b29aa23a840", 0, "715bff08-56ca-4ff9-a9d0-5fb8dbfcdab5", "moderator@rozkladschool.com", true, null, null, false, null, "MODERATOR@ROZKLADSCHOOL.COM", "MODERATOR@ROZKLADSCHOOL.COM", "AQAAAAEAACcQAAAAEAvvHm9BiYjJdBeR/xuMnpnsCHvlWr5OcbgH+ZeQTq+VW62HXZ0X9NWKZ0Zrw253vg==", null, false, "921e6f50-601f-45aa-b1b1-d0eaa1283e03", false, "moderator@rozkladschool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4372075b-1b7f-41dc-8d32-010bf733b07e", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" },
                    { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" },
                    { "f16ba2e4-c460-4ed5-9287-b2eeb3faada7", "467dbd8c-e47a-431d-b611-be8d8a8fb4af" },
                    { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "4fd6d94c-2692-444c-9079-3daeef9467e9" },
                    { "ce1c179f-2ea9-4e48-bfe4-9b416334f5d6", "552ba482-f2b9-4932-bc3c-2b29aa23a840" }
                });
        }
    }
}
