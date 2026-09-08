using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyArt.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3a56ae8-7969-4e4a-8902-01ae516f78a0",
                column: "ConcurrencyStamp",
                value: "5cc435eb-4a87-4959-90a8-c718320280ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f79a0806-0bc2-4d7f-b4c4-19263f08583a",
                column: "ConcurrencyStamp",
                value: "f8813a3d-8962-4852-a6df-848838de33b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-7f8g-9h0i-j1k2l3m4n5o6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a94398e1-e7f9-48a3-afe3-a519ea4ffca7", "AQAAAAIAAYagAAAAEBh+9W2/6aGuT2z0n5kWPg+Zub77EG5+m2ormGoBgMRUy6/gX5I8+MOVy2T7p8LqWQ==", "5de14a6c-e32f-41ca-a116-c7953d50983b" });
        }
    }
}
