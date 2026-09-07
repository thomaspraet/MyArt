using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyArt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedArtistAndTechnicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FirstName", "LastName", "PlaceOfBirth", "YearOfBirth" },
                values: new object[,]
                {
                    { 1, "", "Banksy", "Yate (UK)", "1974" },
                    { 2, "Gerrit", "Baten", "Aalst", "1959" },
                    { 3, "Etienne", "Bauwens", "Aalst", "1930" },
                    { 4, "Geert", "Bauwens", "Aalst", "1961" },
                    { 5, "René", "Bekaert", "Aalst", "1938" },
                    { 6, "André", "Berner", "Vilvoorde", "1955" },
                    { 7, "Walter", "Brems", "Reet", "1947" },
                    { 8, "Pedro", "Brugada", "Girona (ESP)", "1952" },
                    { 9, "André", "Bruylandt", "Onkerzele", "1944" },
                    { 10, "Randall", "Casaer", "", "" },
                    { 11, "Roland", "Cobbaut", "Aalst", "1961" },
                    { 12, "Claire", "Cocquyt", "", "" },
                    { 13, "Raf", "Coorevits", "Sint-Niklaas", "1934" },
                    { 14, "Tony", "De Bruycker", "Gent", "1950" },
                    { 15, "Vigdis", "De Cauter", "Gent", "1974" },
                    { 16, "Jeanne", "De Dijn", "Wichelen", "1919" },
                    { 17, "Robert", "De keersmaecker", "Bornem", "1955" },
                    { 18, "Luc", "De Mot", "Aalst", "1934" },
                    { 19, "Pieter", "De Poortere", "Gent", "1976" },
                    { 20, "Gino", "Dermaut", "Roeselare", "1951" },
                    { 21, "Paul", "De Ryck", "Aalst", "1953" },
                    { 22, "Jozef", "De Schrijver", "Aalst", "1916" },
                    { 23, "François", "Deshommes", "Aalst", "1939" },
                    { 24, "Theo", "De Smedt", "Aalst", "1938" },
                    { 25, "Leen", "De Vos", "Aalst", "1952" },
                    { 26, "Frans", "De Vree", "Aalst", "1934" },
                    { 27, "Paul", "De Vylder", "Sint-Niklaas", "1942" },
                    { 28, "Ignace", "Dierickx", "", "" },
                    { 29, "Hans", "Droesbeke", "Geraardsbergen", "1968" },
                    { 30, "Ronald", "Ergo", "Watervliet", "1936" },
                    { 31, "", "Expha", "Gent", "" },
                    { 32, "Leonor", "Fini", "Buenos Aires (ARG)", "1907" },
                    { 33, "Rafaël", "Gorsen", "Merksem", "1942" },
                    { 34, "Daniël", "Hardyns", "Gent", "1951" },
                    { 35, "Henri", "Hemelsoet", "Westdorpe (NL)", "1955" },
                    { 36, "Eveline", "Henderickx", "Aalst", "1931" },
                    { 37, "Carla", "Heuvinck", "", "" },
                    { 38, "Luc", "Hoenraet", "Aalst", "1941" },
                    { 39, "Achiel", "Hutsebaut", "Hofstade", "1936" },
                    { 40, "Octave", "Landuyt", "Gent", "1922" },
                    { 41, "Fons", "Macharis", "Denderbelle", "1927" },
                    { 42, "Mik", "Maes", "Aalst", "1959" },
                    { 43, "", "MarieAnge", "Nieuwpoort", "1963" },
                    { 44, "Frans", "Minnaert", "Idegem", "1929" },
                    { 45, "Geert", "Opsomer", "Waregem", "1958" },
                    { 46, "Wilhelm", "Mechnig", "Köln (GER)", "1929" },
                    { 47, "Achiel", "Pauwels", "Mariakerke", "1932" },
                    { 48, "Dany", "Persoons", "Aspelare", "1938" }
                });

            migrationBuilder.InsertData(
                table: "Technics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Acryl" },
                    { 2, "Aquarel" },
                    { 3, "Aquarel & fineliner" },
                    { 4, "Aquatint" },
                    { 5, "Bister" },
                    { 6, "Balpen & markers" },
                    { 7, "Cement" },
                    { 8, "Ets" },
                    { 9, "Ets, droge naald" },
                    { 10, "Gemengde techniek" },
                    { 11, "Gouache" },
                    { 12, "Houtsnede" },
                    { 13, "Keramiek" },
                    { 14, "Klei" },
                    { 15, "Kleurpotlood" },
                    { 16, "Linosnede" },
                    { 17, "Litho" },
                    { 18, "Offset druk" },
                    { 19, "Olieverf" },
                    { 20, "Oostindische inkt" },
                    { 21, "Opgehoogde zeefdruk" },
                    { 22, "PC grafiek" },
                    { 23, "Print op doek" },
                    { 24, "Print op fotopapier" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Technics");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
