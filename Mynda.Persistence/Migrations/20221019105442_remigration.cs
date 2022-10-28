using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mynda.Persistence.Migrations
{
    public partial class remigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0256e4b8-d4ab-4b7b-ba4e-4a1ccb0c6c06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cfc97a0-9885-4946-8468-eeb8a2855e5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b413e5ca-36d3-457a-94cc-91a55301bd87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0ec2ff7-aa07-4d33-be8c-7063316fc458");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd31ab6d-4d2d-4612-876e-fb02eb1f22c0", "5605680b-93ae-402c-92fd-4e4b687f46b0", "Mynda", "MYNDA" },
                    { "cdcc4549-7259-4357-918a-cb2d0213b890", "7de51f3f-3770-4816-b618-f89ba22fd600", "Employer", "EMPLOYER" },
                    { "d65cb378-a30b-4694-81b3-78f05a6e8e60", "7bba7f12-47b8-41f6-bbf7-59575e3f1042", "Hospital", "HOSPITAL" },
                    { "f81d8d4b-b586-48a2-ae0a-3c1fbea54a94", "ad5047f9-61a9-470b-9026-19bea51da859", "Agent", "AGENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd31ab6d-4d2d-4612-876e-fb02eb1f22c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdcc4549-7259-4357-918a-cb2d0213b890");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d65cb378-a30b-4694-81b3-78f05a6e8e60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81d8d4b-b586-48a2-ae0a-3c1fbea54a94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0256e4b8-d4ab-4b7b-ba4e-4a1ccb0c6c06", "80057cf3-eae7-4e52-b9dc-23e15db825fe", "Employer", "EMPLOYER" },
                    { "9cfc97a0-9885-4946-8468-eeb8a2855e5a", "64b1f5d2-b565-42ec-8e4f-25d5f8d3d267", "Mynda", "MYNDA" },
                    { "b413e5ca-36d3-457a-94cc-91a55301bd87", "e4b8643d-fd4f-48d5-bfa0-fd66822dfe74", "Hospital", "HOSPITAL" },
                    { "e0ec2ff7-aa07-4d33-be8c-7063316fc458", "9d93c8fa-6e00-42e7-9d0e-581648f2c548", "Agent", "AGENT" }
                });
        }
    }
}
