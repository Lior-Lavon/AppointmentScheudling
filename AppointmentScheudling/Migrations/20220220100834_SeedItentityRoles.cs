using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentScheudling.Migrations
{
    public partial class SeedItentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f6d476f-49eb-48e8-aefe-47b5647c83fc", "0951dc89-70a9-4e80-98bf-c4a45fb4558d", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "850af39c-d82d-4532-aaf1-e296a2d29faf", "2b2472c5-34a3-4eab-979b-7b9d9655a145", "Doctor", "Doctor" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2c87300-1e75-4a2b-bf9b-1636853b8f40", "30d609a8-e309-4b25-87b7-56f117bc3781", "Patient", "Patient" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f6d476f-49eb-48e8-aefe-47b5647c83fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "850af39c-d82d-4532-aaf1-e296a2d29faf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2c87300-1e75-4a2b-bf9b-1636853b8f40");
        }
    }
}
