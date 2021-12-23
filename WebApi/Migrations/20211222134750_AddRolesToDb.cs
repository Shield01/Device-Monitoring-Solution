using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74905de9-46c4-4c67-aa34-a91eab577dad", "8a1618e6-6d0a-48ca-b6da-4d20c9629c59", "Operations", "OPERATIONS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d055450-ac1c-4e98-b460-8a6eaed9e0ff", "5f6c9d3e-612f-417b-b7b8-612e64c73f74", "Store Manager", "STORE MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6883de54-5511-4291-820e-f282c7e1b80b", "b33ca1da-020b-4544-897b-3f22092a83f4", "Procurement Agent", "PROCUREMENT AGENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f52e468-7786-4312-ac07-bf5ae22fa4ab", "8e207d45-e14a-4e1a-9e0b-d2b3d637e59a", "Sales Agent", "SALES AGENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c07cbdf8-b0a6-4e4e-92b1-6465ef6ff915", "247ea326-1fc6-413b-86b8-d336f19ac3aa", "Receptionist", "RECEPTIONIST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ba722cb-dbbf-4a13-9730-ce8bf9c94d2d", "2e6c3d31-4de2-4d01-aa1f-c62c2ead8efa", "Repair And Maintenance", "REPAIR AND MAINTENANCE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ba722cb-dbbf-4a13-9730-ce8bf9c94d2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f52e468-7786-4312-ac07-bf5ae22fa4ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6883de54-5511-4291-820e-f282c7e1b80b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74905de9-46c4-4c67-aa34-a91eab577dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d055450-ac1c-4e98-b460-8a6eaed9e0ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c07cbdf8-b0a6-4e4e-92b1-6465ef6ff915");
        }
    }
}
