using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Divisima.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    NameSurName = table.Column<string>(type: "NvarChar(50)", maxLength: 50, nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginIP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slide",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slogan = table.Column<string>(type: "Nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "Nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "Nvarchar(150)", maxLength: 150, nullable: false),
                    Picture = table.Column<string>(type: "Nvarchar(150)", maxLength: 150, nullable: true),
                    Price = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Link = table.Column<string>(type: "Nvarchar(150)", nullable: true),
                    DisplayIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slide", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "LastLoginDate", "LastLoginIP", "NameSurName", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2024, 5, 24, 19, 55, 7, 475, DateTimeKind.Local).AddTicks(3510), "", "Emrehan Ağaçyetiştiren", "202cb962ac59075b964b07152d234b70", "Ağaç" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Slide");
        }
    }
}
