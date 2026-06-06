using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class AddRealPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsurancePackages",
                columns: new[] { "Id", "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 50000m, "Ayakta Tedavi (Yılda 6 Kez), Yatarak Tedavi Kapsamı, Anlaşmalı Kurum Ağı", 1, "Tamamlayıcı", 3000m },
                    { 2, 250000m, "Limitsiz Ayakta Tedavi, %100 Yatarak Tedavi, Diş ve Göz Muayenesi, Geniş Anlaşmalı Kurum", 1, "Kapsamlı Sağlık", 7500m },
                    { 3, 1000000m, "Limitsiz Tüm Tedaviler, Yurtdışı Teminatı, Özel Oda ve Refakatçi, VIP Check-up, Acil Hava Ambulansı", 1, "VIP Hayat", 15000m },
                    { 4, 120000m, "Zorunlu Karşı Taraf Hasarı, Üçüncü Şahıs Koruma, Hukuki Savunma", 2, "Trafik", 3500m },
                    { 5, 500000m, "Çarpışma ve Çalınma, Doğal Afet Koruma, Cam Kırılması, Yılda 2 Kez Çekici", 2, "Genişletilmiş Kasko", 8000m },
                    { 6, 2000000m, "Limitsiz İhtiyari Mali Mesuliyet, Orijinal Yedek Parça, Sınırsız İkame Araç, Hatalı Akaryakıt, Tam Koruma", 2, "Premium Kasko", 14000m },
                    { 7, 250000m, "Yangın Koruma, Deprem (DASK Harici), Yer Kayması", 3, "Temel Güvence", 1500m },
                    { 8, 750000m, "Tüm Temel Kapsamlar, Hırsızlık, Su Baskını, Cam Kırılması, İzolasyon Hasarları", 3, "Evim Güvende", 3500m },
                    { 9, 2000000m, "Limitsiz Eşya Güvencesi, Elektronik Cihaz Koruma, Ücretsiz Çilingir ve Tesisat, Alternatif İkametgah", 3, "Premium Konak", 7000m },
                    { 10, 20000m, "Acil Durum Müdahalesi, Kaza Sonrası Tedavi, Muayene (Yılda 2)", 4, "Pati Koruma", 1200m },
                    { 11, 50000m, "Hastalık Tedavisi, Ameliyat Masrafları, Laboratuvar Tahlilleri, Mikroçip Takılması", 4, "Can Dostum", 3000m },
                    { 12, 150000m, "Sınırsız Tedavi, Check-up, Diş Temizliği, Yurtdışı Seyahat Kapsamı, Kayıp İlan Desteği", 4, "Premium Pati", 6000m },
                    { 13, 10000m, "Yurtiçi Tıbbi Tedavi, Bagaj Kaybı, Seyahat İptali", 5, "Yurt İçi", 300m },
                    { 14, 30000m, "Schengen Vize Şartlarına Uygun, Tıbbi Nakil, Acil İlaç Gönderimi, Pasaport Kaybı", 5, "Avrupa Vize", 900m },
                    { 15, 100000m, "Tüm Dünya Geçerli, Covid-19 Kapsamı, Hukuki Yardım, Acil Geri Dönüş, Kayak/Spor Yaralanmaları", 5, "Global Gezgin", 1800m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
