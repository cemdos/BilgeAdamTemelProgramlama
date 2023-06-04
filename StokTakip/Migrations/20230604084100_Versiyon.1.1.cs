using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.Migrations
{
    /// <inheritdoc />
    public partial class Versiyon11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AktifMusteriMusteriID",
                table: "UrunDetayi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AktifUrunID",
                table: "UrunDetayi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UrunDetayi_AktifMusteriMusteriID",
                table: "UrunDetayi",
                column: "AktifMusteriMusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunDetayi_AktifUrunID",
                table: "UrunDetayi",
                column: "AktifUrunID");

            migrationBuilder.AddForeignKey(
                name: "FK_UrunDetayi_Musteri_AktifMusteriMusteriID",
                table: "UrunDetayi",
                column: "AktifMusteriMusteriID",
                principalTable: "Musteri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UrunDetayi_Urun_AktifUrunID",
                table: "UrunDetayi",
                column: "AktifUrunID",
                principalTable: "Urun",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrunDetayi_Musteri_AktifMusteriMusteriID",
                table: "UrunDetayi");

            migrationBuilder.DropForeignKey(
                name: "FK_UrunDetayi_Urun_AktifUrunID",
                table: "UrunDetayi");

            migrationBuilder.DropIndex(
                name: "IX_UrunDetayi_AktifMusteriMusteriID",
                table: "UrunDetayi");

            migrationBuilder.DropIndex(
                name: "IX_UrunDetayi_AktifUrunID",
                table: "UrunDetayi");

            migrationBuilder.DropColumn(
                name: "AktifMusteriMusteriID",
                table: "UrunDetayi");

            migrationBuilder.DropColumn(
                name: "AktifUrunID",
                table: "UrunDetayi");
        }
    }
}
