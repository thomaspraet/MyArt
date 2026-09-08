using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyArt.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3a56ae8-7969-4e4a-8902-01ae516f78a0",
                column: "ConcurrencyStamp",
                value: "f6046ec7-1bf9-4536-8b82-e7aae1cee092");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f79a0806-0bc2-4d7f-b4c4-19263f08583a",
                column: "ConcurrencyStamp",
                value: "833c8e49-5b6d-4fc0-b71a-4dfb43ab339c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-7f8g-9h0i-j1k2l3m4n5o6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3af3f6ca-31f1-405c-ac11-7c8a1249bbc0", "AQAAAAIAAYagAAAAEO1jWEpPJEyEi9noVsp9qXqHtlylGof/k2BZ10f/InqqSaPWDD0e1+kgwa3jqw9Bxw==", "8e7dd5d0-a8da-42ed-b56d-7b7447ec8494" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3a56ae8-7969-4e4a-8902-01ae516f78a0",
                column: "ConcurrencyStamp",
                value: "d431deca-b4d6-42f6-8648-74194a57c2fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f79a0806-0bc2-4d7f-b4c4-19263f08583a",
                column: "ConcurrencyStamp",
                value: "28b70e8c-2f9b-4083-a819-d308486a3322");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-7f8g-9h0i-j1k2l3m4n5o6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a169f119-b98d-4654-92f3-f7fc21876d86", "AQAAAAIAAYagAAAAELE8YG/cosuBH+OOPPWHcDIuTS+r1q1WUoYzF0BZBb2yEPGQe8+q7rU3wxf56838+A==", "c1d172a2-a61d-4437-a14e-7d2741823640" });
        }
    }
}
