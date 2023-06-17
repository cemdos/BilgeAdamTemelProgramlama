using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StokTakip.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanici",
                columns: new[] { "ID", "CreDate", "CreUser", "DelDate", "DelUser", "Deleted", "KullaniciAdi", "ModDate", "ModUser", "Sifre" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 6, 10, 11, 21, 55, 381, DateTimeKind.Local).AddTicks(9189), null, null, null, false, "cemdos", null, null, "1234" },
                    { 20, new DateTime(2023, 6, 10, 11, 21, 55, 381, DateTimeKind.Local).AddTicks(9276), null, null, null, false, "ali", null, null, "1234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "ID",
                keyValue: 20);
        }
    }
}
