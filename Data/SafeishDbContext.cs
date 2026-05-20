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
                new InsuranceType { Id = 3, Name = "Konut Sigortası", Description = "Eviniz için tam koruma", IconUrl = "bi-house" }
            );

            // Seed Data for Insurance Packages
            modelBuilder.Entity<InsurancePackage>().HasData(
                // Sağlık Sigortası Paketleri (Id: 1)
                new InsurancePackage { Id = 1, InsuranceTypeId = 1, Name = "Temel Sağlık", Price = 3000, CoverageAmount = 50000, Features = "Yatarak Tedavi Kapsamı (Sınırlı), Acil Durum Ambulans Hizmeti" },
                new InsurancePackage { Id = 2, InsuranceTypeId = 1, Name = "Standart Sağlık", Price = 6000, CoverageAmount = 150000, Features = "Temel Kapsamlar, Yılda 10 Kez Ayakta Tedavi, %80 İlaç Katılım Payı" },
                new InsurancePackage { Id = 3, InsuranceTypeId = 1, Name = "Premium Sağlık", Price = 12000, CoverageAmount = 500000, Features = "Sınırsız Ayakta ve Yatarak Tedavi, Diş ve Göz Muayenesi, Yurtdışı Teminatı, Özel Oda Giderleri, Check-up" },

                // Araç Sigortası Paketleri (Id: 2)
                new InsurancePackage { Id = 4, InsuranceTypeId = 2, Name = "Temel Kasko", Price = 4000, CoverageAmount = 250000, Features = "Çarpışma, Çalınma, Araç Yanması, Yılda 1 Kez Çekici Hizmeti" },
                new InsurancePackage { Id = 5, InsuranceTypeId = 2, Name = "Standart Kasko", Price = 7500, CoverageAmount = 500000, Features = "Temel Kapsamlar, Cam Kırılması, Mini Onarım, 7 Gün İkame Araç" },
                new InsurancePackage { Id = 6, InsuranceTypeId = 2, Name = "Premium Kasko", Price = 11000, CoverageAmount = 1000000, Features = "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt Dolumu, Orjinal Yedek Parça, Doğal Afetler" },

                // Konut Sigortası Paketleri (Id: 3)
                new InsurancePackage { Id = 7, InsuranceTypeId = 3, Name = "Temel Konut", Price = 2500, CoverageAmount = 500000, Features = "Yangın, Deprem (DASK Kapsamı Dışı), Yer Kayması" },
                new InsurancePackage { Id = 8, InsuranceTypeId = 3, Name = "Standart Konut", Price = 4500, CoverageAmount = 1500000, Features = "Temel Kapsamlar, Hırsızlık, Su Baskını, Cam Kırılması" },
                new InsurancePackage { Id = 9, InsuranceTypeId = 3, Name = "Premium Konut", Price = 8000, CoverageAmount = 3000000, Features = "Tüm Kapsamlar, Eşya Güvencesi, İzolasyon Hasarları, Ücretsiz Çilingir ve Tesisatçı" }
            );
        }
    }
}
