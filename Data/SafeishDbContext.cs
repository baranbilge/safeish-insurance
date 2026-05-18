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
                new InsuranceType { Id = 3, Name = "DASK", Description = "Zorunlu deprem sigortası", IconUrl = "bi-house" }
            );

            // Seed Data for Insurance Packages
            modelBuilder.Entity<InsurancePackage>().HasData(
                // Sağlık Sigortası Paketleri (Id: 1)
                new InsurancePackage { Id = 1, InsuranceTypeId = 1, Name = "Temel Sağlık", Price = 3000, CoverageAmount = 50000, Features = "Yatarak Tedavi Kapsamı, Yoğun Bakım Teminatı, Acil Durum Ambulans Hizmeti, Suni Uzuv Teminatı" },
                new InsurancePackage { Id = 2, InsuranceTypeId = 1, Name = "Standart Sağlık", Price = 6000, CoverageAmount = 150000, Features = "Temel Kapsamlar, Yılda 10 Kez Ayakta Tedavi, Ücretsiz Check-up, %80 İlaç Katılım Payı" },
                new InsurancePackage { Id = 3, InsuranceTypeId = 1, Name = "Premium Sağlık", Price = 12000, CoverageAmount = 500000, Features = "Sınırsız Ayakta ve Yatarak Tedavi, Diş ve Göz Muayenesi, Yurtdışı Teminatı, Özel Oda Giderleri" },

                // Araç Sigortası Paketleri (Id: 2)
                new InsurancePackage { Id = 4, InsuranceTypeId = 2, Name = "Temel Kasko", Price = 4000, CoverageAmount = 250000, Features = "Çarpışma ve Çalınma, Araç Yanması, Yılda 1 Kez Çekici Hizmeti, Anahtar Kaybı (Limitli)" },
                new InsurancePackage { Id = 5, InsuranceTypeId = 2, Name = "Standart Kasko", Price = 7500, CoverageAmount = 500000, Features = "Temel Kapsamlar, Cam Kırılması, Mini Onarım, 7 Gün İkame Araç, Doğal Afetler" },
                new InsurancePackage { Id = 6, InsuranceTypeId = 2, Name = "Premium Kasko", Price = 11000, CoverageAmount = 1000000, Features = "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt Dolumu, Orjinal Yedek Parça" }
            );
        }
    }
}
