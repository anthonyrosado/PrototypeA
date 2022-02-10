using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeA.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiveLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Si = table.Column<float>(type: "real", nullable: false),
                    StartPg = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AirIn = table.Column<float>(type: "real", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    visibility = table.Column<int>(type: "int", nullable: false),
                    AirOut = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    EndPg = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiveLogs", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiveLogs");

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
        }
    }
}
