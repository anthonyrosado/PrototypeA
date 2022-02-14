using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeA.Data.Migrations
{
    public partial class RoleChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "335aaa58-e01d-428b-9f47-fb0294341090");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9890b7a-926e-46c9-baed-ae4fa4e54324");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9d3203e-506b-4fad-8119-7bae42dc5664");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe26310-6a9d-4bf2-b9d1-c01a36fd6a07");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "077e0650-11b3-4cc3-ab3b-0b6d7e45c430", "548b9534-9918-4e9f-9abc-3d74482f391d", "Diver", "DIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "536b7f4e-3cbd-435a-8ce0-af2751a12e59", "a1b722c4-9fb2-4818-acc0-d0a39e579b60", "AdminUser", "ADMINUSER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "077e0650-11b3-4cc3-ab3b-0b6d7e45c430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "536b7f4e-3cbd-435a-8ce0-af2751a12e59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "335aaa58-e01d-428b-9f47-fb0294341090", "55ca9936-2dc7-49e6-bd32-7d5d05fa06c2", "Customer", "CUSTOMER" },
                    { "b9890b7a-926e-46c9-baed-ae4fa4e54324", "d628abc7-47ef-4811-95d8-399e09357b06", "ServiceProvider", "SERVICEPROVIDER" },
                    { "b9d3203e-506b-4fad-8119-7bae42dc5664", "4e1cee03-23a6-4024-a57c-f94cd7ecced5", "AdminUser", "ADMINUSER" },
                    { "cfe26310-6a9d-4bf2-b9d1-c01a36fd6a07", "f8cac303-4efc-436e-a2c0-05f586a5221d", "SatelliteOwner", "SATELLITEOWNER" }
                });
        }
    }
}
