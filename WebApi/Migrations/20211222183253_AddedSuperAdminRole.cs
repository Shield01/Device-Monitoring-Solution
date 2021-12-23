using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddedSuperAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2c54451-2dfe-4d0b-9d06-a960b34cce87", "487c4d2e-ce91-422f-9309-209332c59dc0", "Operations", "OPERATIONS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d68d457-682b-4583-bfbb-617252daee12", "e0bc8f0c-796b-4ea3-97bd-ec6852a4e9eb", "Store Manager", "STORE MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bb070e1-5659-41c1-9156-6c2172e4a4b3", "c34993c9-b13e-4385-b210-8af23dfce9d4", "Procurement Agent", "PROCUREMENT AGENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32e71947-c907-4ca7-b902-f96008d2ec6f", "360d2f2d-ac32-43f5-8620-910ba3ecf340", "Sales Agent", "SALES AGENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4bb38598-bb22-4354-af79-127c4fdded9e", "996f37ca-7abf-4900-9650-6a01ff3cf9a4", "Receptionist", "RECEPTIONIST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f59ab85d-6780-48d1-9977-920ee4ad98a7", "cfae42ea-8841-45c4-82ba-f4216b56646b", "Repair And Maintenance", "REPAIR AND MAINTENANCE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19e05e54-b656-4ffd-9299-963ad302ea7f", "66cc4a2d-e918-48b7-aa5d-1de3037d3faf", "Super Admin", "SUPER ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19e05e54-b656-4ffd-9299-963ad302ea7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d68d457-682b-4583-bfbb-617252daee12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e71947-c907-4ca7-b902-f96008d2ec6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bb38598-bb22-4354-af79-127c4fdded9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bb070e1-5659-41c1-9156-6c2172e4a4b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c54451-2dfe-4d0b-9d06-a960b34cce87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59ab85d-6780-48d1-9977-920ee4ad98a7");

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
    }
}
