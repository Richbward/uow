using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uowAPI.Migrations
{
    public partial class TicketechSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "Id", "Active", "City", "ClientSince", "Contact", "Email", "Name", "Phone", "State", "Street1", "Street2", "Url", "Zip" },
                values: new object[] { new Guid("f98fac6e-5cbf-42be-8cfb-1a22ccd224d1"), true, "New York", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh Murdock", null, "NYC Parking West 145th Garage Corp.", "(646) 243-6930", "NY", "53 Bradhurst Ave", null, null, "10039" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: new Guid("f98fac6e-5cbf-42be-8cfb-1a22ccd224d1"));
        }
    }
}
