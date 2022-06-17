using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiparisAPI.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varisAdresi",
                table: "Siparisler",
                newName: "weightUnit");

            migrationBuilder.RenameColumn(
                name: "statu",
                table: "Siparisler",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "siparisnot",
                table: "Siparisler",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "siparisNo",
                table: "Siparisler",
                newName: "quantityUnit");

            migrationBuilder.RenameColumn(
                name: "miktarBirim",
                table: "Siparisler",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "miktar",
                table: "Siparisler",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "malzemeKodu",
                table: "Siparisler",
                newName: "materialCode");

            migrationBuilder.RenameColumn(
                name: "malzemeAdi",
                table: "Siparisler",
                newName: "material");

            migrationBuilder.RenameColumn(
                name: "cikisAdresi",
                table: "Siparisler",
                newName: "destinationAddress");

            migrationBuilder.RenameColumn(
                name: "agirlikBirim",
                table: "Siparisler",
                newName: "departureAddress");

            migrationBuilder.RenameColumn(
                name: "agirlik",
                table: "Siparisler",
                newName: "customerOrderNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weightUnit",
                table: "Siparisler",
                newName: "varisAdresi");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "Siparisler",
                newName: "statu");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Siparisler",
                newName: "siparisnot");

            migrationBuilder.RenameColumn(
                name: "quantityUnit",
                table: "Siparisler",
                newName: "siparisNo");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Siparisler",
                newName: "miktarBirim");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Siparisler",
                newName: "miktar");

            migrationBuilder.RenameColumn(
                name: "materialCode",
                table: "Siparisler",
                newName: "malzemeKodu");

            migrationBuilder.RenameColumn(
                name: "material",
                table: "Siparisler",
                newName: "malzemeAdi");

            migrationBuilder.RenameColumn(
                name: "destinationAddress",
                table: "Siparisler",
                newName: "cikisAdresi");

            migrationBuilder.RenameColumn(
                name: "departureAddress",
                table: "Siparisler",
                newName: "agirlikBirim");

            migrationBuilder.RenameColumn(
                name: "customerOrderNo",
                table: "Siparisler",
                newName: "agirlik");
        }
    }
}
