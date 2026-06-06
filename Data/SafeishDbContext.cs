using Microsoft.EntityFrameworkCore;
using Safeish.Models;

namespace Safeish.Data
{
    public class SafeishDbContext : DbContext
    {
        public SafeishDbContext(DbContextOptions<SafeishDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<InsuranceType> InsuranceTypes { get; set; }
        public DbSet<InsurancePackage> InsurancePackages { get; set; }
        public DbSet<UserPolicy> UserPolicies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed Data for Insurance Types
            modelBuilder.Entity<InsuranceType>().HasData(
                new InsuranceType { Id = 1, Name = "Sağlık Sigortası", Description = "Kapsamlı sağlık güvencesi", IconUrl = "bi-heart-pulse" },
                new InsuranceType { Id = 2, Name = "Kasko Sigortası", Description = "Aracınız için tam koruma", IconUrl = "bi-car-front" },
                new InsuranceType { Id = 3, Name = "Konut Sigortası", Description = "Eviniz için tam koruma", IconUrl = "bi-house" },
                new InsuranceType { Id = 4, Name = "Evcil Hayvan Sigortası", Description = "Minik dostlarınız için", IconUrl = "bi-github" },
                new InsuranceType { Id = 5, Name = "Seyahat Sigortası", Description = "Güvenli yolculuklar", IconUrl = "bi-airplane-fill" }
            );

            // Seed Data for Insurance Packages (Tüm kategoriler için düşük, orta, yüksek seviyeli paketler)
            modelBuilder.Entity<InsurancePackage>().HasData(
                // Sağlık Sigortası Paketleri (Id: 1)
                new InsurancePackage { Id = 1, InsuranceTypeId = 1, Name = "Tamamlayıcı", Price = 3000, CoverageAmount = 50000, Features = "Ayakta Tedavi (Yılda 6 Kez), Yatarak Tedavi Kapsamı, Anlaşmalı Kurum Ağı" },
                new InsurancePackage { Id = 2, InsuranceTypeId = 1, Name = "Kapsamlı Sağlık", Price = 7500, CoverageAmount = 250000, Features = "Limitsiz Ayakta Tedavi, %100 Yatarak Tedavi, Diş ve Göz Muayenesi, Geniş Anlaşmalı Kurum" },
                new InsurancePackage { Id = 3, InsuranceTypeId = 1, Name = "VIP Hayat", Price = 15000, CoverageAmount = 1000000, Features = "Limitsiz Tüm Tedaviler, Yurtdışı Teminatı, Özel Oda ve Refakatçi, VIP Check-up, Acil Hava Ambulansı" },

                // Araç Sigortası Paketleri (Id: 2)
                new InsurancePackage { Id = 4, InsuranceTypeId = 2, Name = "Trafik", Price = 3500, CoverageAmount = 120000, Features = "Zorunlu Karşı Taraf Hasarı, Üçüncü Şahıs Koruma, Hukuki Savunma" },
                new InsurancePackage { Id = 5, InsuranceTypeId = 2, Name = "Genişletilmiş Kasko", Price = 8000, CoverageAmount = 500000, Features = "Çarpışma ve Çalınma, Doğal Afet Koruma, Cam Kırılması, Yılda 2 Kez Çekici" },
                new InsurancePackage { Id = 6, InsuranceTypeId = 2, Name = "Premium Kasko", Price = 14000, CoverageAmount = 2000000, Features = "Limitsiz İhtiyari Mali Mesuliyet, Orijinal Yedek Parça, Sınırsız İkame Araç, Hatalı Akaryakıt, Tam Koruma" },

                // Konut Sigortası Paketleri (Id: 3)
                new InsurancePackage { Id = 7, InsuranceTypeId = 3, Name = "Temel Güvence", Price = 1500, CoverageAmount = 250000, Features = "Yangın Koruma, Deprem (DASK Harici), Yer Kayması" },
                new InsurancePackage { Id = 8, InsuranceTypeId = 3, Name = "Evim Güvende", Price = 3500, CoverageAmount = 750000, Features = "Tüm Temel Kapsamlar, Hırsızlık, Su Baskını, Cam Kırılması, İzolasyon Hasarları" },
                new InsurancePackage { Id = 9, InsuranceTypeId = 3, Name = "Premium Konak", Price = 7000, CoverageAmount = 2000000, Features = "Limitsiz Eşya Güvencesi, Elektronik Cihaz Koruma, Ücretsiz Çilingir ve Tesisat, Alternatif İkametgah" },

                // Evcil Hayvan Sigortası Paketleri (Id: 4)
                new InsurancePackage { Id = 10, InsuranceTypeId = 4, Name = "Pati Koruma", Price = 1200, CoverageAmount = 20000, Features = "Acil Durum Müdahalesi, Kaza Sonrası Tedavi, Muayene (Yılda 2)" },
                new InsurancePackage { Id = 11, InsuranceTypeId = 4, Name = "Can Dostum", Price = 3000, CoverageAmount = 50000, Features = "Hastalık Tedavisi, Ameliyat Masrafları, Laboratuvar Tahlilleri, Mikroçip Takılması" },
                new InsurancePackage { Id = 12, InsuranceTypeId = 4, Name = "Premium Pati", Price = 6000, CoverageAmount = 150000, Features = "Sınırsız Tedavi, Check-up, Diş Temizliği, Yurtdışı Seyahat Kapsamı, Kayıp İlan Desteği" },

                // Seyahat Sigortası Paketleri (Id: 5)
                new InsurancePackage { Id = 13, InsuranceTypeId = 5, Name = "Yurt İçi", Price = 300, CoverageAmount = 10000, Features = "Yurtiçi Tıbbi Tedavi, Bagaj Kaybı, Seyahat İptali" },
                new InsurancePackage { Id = 14, InsuranceTypeId = 5, Name = "Avrupa Vize", Price = 900, CoverageAmount = 30000, Features = "Schengen Vize Şartlarına Uygun, Tıbbi Nakil, Acil İlaç Gönderimi, Pasaport Kaybı" },
                new InsurancePackage { Id = 15, InsuranceTypeId = 5, Name = "Global Gezgin", Price = 1800, CoverageAmount = 100000, Features = "Tüm Dünya Geçerli, Covid-19 Kapsamı, Hukuki Yardım, Acil Geri Dönüş, Kayak/Spor Yaralanmaları" }
            );

            // Seed 18 Rastgele Müşteri ve Poliçeleri
            var users = new System.Collections.Generic.List<User>();
            var policies = new System.Collections.Generic.List<UserPolicy>();
            var random = new System.Random(100);
            var firstNames = new[] {"Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali", "Veli", "Hasan", "Hüseyin", "Zeynep", "Elif", "Burak", "Can", "Deniz", "Ege", "Emre", "Furkan", "Gökhan", "Gizem", "Seda", "Mert"};
            var lastNames = new[] {"Yılmaz", "Kaya", "Demir", "Çelik", "Şahin", "Yıldız", "Yıldırım", "Öztürk", "Aydın", "Özdemir", "Arslan", "Doğan", "Kılıç", "Aslan", "Çetin", "Kara", "Koç", "Kurt", "Özkan", "Şimşek"};
            var phonePrefixes = new[] {"0532", "0533", "0542", "0544", "0505", "0555", "0543"};
            var packageNames = new System.Collections.Generic.Dictionary<int, string> {
                {1, "Tamamlayıcı"}, {2, "Kapsamlı Sağlık"}, {3, "VIP Hayat"},
                {4, "Trafik"}, {5, "Genişletilmiş Kasko"}, {6, "Premium Kasko"},
                {7, "Temel Güvence"}, {8, "Evim Güvende"}, {9, "Premium Konak"},
                {10, "Pati Koruma"}, {11, "Can Dostum"}, {12, "Premium Pati"},
                {13, "Yurt İçi"}, {14, "Avrupa Vize"}, {15, "Global Gezgin"}
            };

            var emailDomains = new[] { "@gmail.com", "@hotmail.com" };

            for (int i = 1; i <= 18; i++)
            {
                var fname = firstNames[random.Next(firstNames.Length)];
                var lname = lastNames[random.Next(lastNames.Length)];
                // 2024 veya sonrası tarih (2024 yılı içinde)
                var createdAt = new System.DateTime(2024, random.Next(1, 12), random.Next(1, 28), random.Next(8, 18), random.Next(0, 59), 0, System.DateTimeKind.Utc);
                var phone = phonePrefixes[random.Next(phonePrefixes.Length)] + random.Next(1000000, 9999999).ToString();
                var domain = emailDomains[random.Next(emailDomains.Length)];
                
                users.Add(new User
                {
                    Id = 1000 + i, // Çakışmaları önlemek için 1000'den başlıyoruz
                    FirstName = fname,
                    LastName = lname,
                    Email = $"{fname.ToLower()}.{lname.ToLower()}{i}{domain}",
                    PasswordHash = "AQAAAAIAAYagAAAAEPQAAA", // dummy hash
                    PhoneNumber = phone,
                    CreatedAt = createdAt,
                    Role = "User"
                });

                var packageId = random.Next(1, 16); 
                var isExpired = random.Next(0, 3) == 0; // 1/3 ihtimalle Sona Erdi
                var status = isExpired ? "Sona erdi" : "Aktif";
                var start = createdAt.AddDays(random.Next(1, 5));
                var end = isExpired ? start.AddYears(1) : new System.DateTime(2028, random.Next(1, 13), random.Next(1, 28), random.Next(8, 18), random.Next(0, 59), 0, System.DateTimeKind.Utc);
                
                policies.Add(new UserPolicy
                {
                    Id = 1000 + i,
                    UserId = 1000 + i,
                    InsurancePackageId = packageId,
                    PackageName = packageNames[packageId],
                    Status = status,
                    IsActive = !isExpired,
                    StartDate = start,
                    EndDate = end
                });
            }

            // Bekleyen poliçeler için rastgele 4 müşteriye ek poliçe
            for (int i = 1; i <= 4; i++)
            {
                var packageId = random.Next(1, 16); 
                policies.Add(new UserPolicy
                {
                    Id = 2000 + i,
                    UserId = 1000 + i, // İlk 4 müşteriye atıyoruz
                    InsurancePackageId = packageId,
                    PackageName = packageNames[packageId],
                    Status = "Görüşme bekleniyor",
                    IsActive = false,
                    StartDate = new System.DateTime(2024, 6, 3, 12, 0, 0, System.DateTimeKind.Utc),
                    EndDate = new System.DateTime(2025, 6, 3, 12, 0, 0, System.DateTimeKind.Utc)
                });
            }

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserPolicy>().HasData(policies);
        }
    }
}
