using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeA.Data.Migrations
{
    public partial class UpdateB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "077e0650-11b3-4cc3-ab3b-0b6d7e45c430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "536b7f4e-3cbd-435a-8ce0-af2751a12e59");

            migrationBuilder.AddColumn<int>(
                name: "DiverId",
                table: "DiveLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Divers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiveLogs_DiverId",
                table: "DiveLogs",
                column: "DiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiveLogs_Divers_DiverId",
                table: "DiveLogs",
                column: "DiverId",
                principalTable: "Divers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiveLogs_Divers_DiverId",
                table: "DiveLogs");

            migrationBuilder.DropTable(
                name: "Divers");

            migrationBuilder.DropIndex(
                name: "IX_DiveLogs_DiverId",
                table: "DiveLogs");

            migrationBuilder.DropColumn(
                name: "DiverId",
                table: "DiveLogs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "077e0650-11b3-4cc3-ab3b-0b6d7e45c430", "548b9534-9918-4e9f-9abc-3d74482f391d", "Diver", "DIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "536b7f4e-3cbd-435a-8ce0-af2751a12e59", "a1b722c4-9fb2-4818-acc0-d0a39e579b60", "AdminUser", "ADMINUSER" });
        }
    }
}
