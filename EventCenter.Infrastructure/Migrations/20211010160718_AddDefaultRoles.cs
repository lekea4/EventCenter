using Microsoft.EntityFrameworkCore.Migrations;

namespace EventCenter.Infrastructure.Migrations
{
    public partial class AddDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95a34e16-6713-4d08-b575-aeb29c222c12", "99e1cf52-4e91-401f-b4f3-e7b70ee943a9", "User", "USER" },
                    { "b016f97e-d934-4e64-9de7-b095412c08ef", "5e7296b2-a601-4cbc-b07a-434d7da4a08a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "EventCenters",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 4, "Fagba, Iju, Lagos", 1, "Arewa Event Center" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Country", "State" },
                values: new object[] { 4, "Nigeria", "Abuja" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a34e16-6713-4d08-b575-aeb29c222c12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b016f97e-d934-4e64-9de7-b095412c08ef");

            migrationBuilder.DeleteData(
                table: "EventCenters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
