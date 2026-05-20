# Safeish - Sigortacılık Yönetim Platformu

Safeish, bireysel müşterilerin farklı sigorta türlerini inceleyebildiği, bütçe ve ihtiyaçlarına uygun paketler için anlık veya detaylı teklif talepleri oluşturabildiği, aktif/bekleyen poliçelerini dinamik olarak yönetebildiği modern ve güvenli bir dijital sigortacılık web platformudur.

Bu proje, **.NET 10.0** ve **ASP.NET Core MVC** mimarisi kullanılarak geliştirilmiş olup, kurumsal standartlara ve modern yazılım prensiplerine uygun olarak tasarlanmıştır.

---

##  Temel Özellikler

###  Kimlik Doğrulama ve Güvenlik
- **Cookie Authentication:** Güvenli oturum yönetimi ASP.NET Core bünyesindeki Cookie ara yazılımı ile sağlanır.
- **Şifreleme (Hashing):** Kullanıcı şifreleri veritabanına düz metin olarak değil, **SHA-256** algoritması ile şifrelenerek kaydedilir.
- **Yetkilendirme Koruması:** Profil, şifre değiştirme, iletişim bilgisi güncelleme ve poliçe iptal işlemleri `[Authorize]` özniteliği ile korunmaktadır.
- **Şifre Sıfırlama Akışı:** Güvenli token (`ResetPasswordToken`) üretilerek süreli şifre sıfırlama simülasyonu entegre edilmiştir.

###  Profil ve Hesap Yönetimi
- **Kullanıcı Paneli:** Kullanıcılar telefon, alternatif telefon ve adres bilgilerini anlık olarak güncelleyebilir.
- **Poliçe Yönetimi:** "Sigortalarım" sekmesinden geçmiş ve bekleyen teklifler görüntülenebilir. "Görüşme bekleniyor" statüsündeki poliçe talepleri asenkron (AJAX) olarak iptal edilebilir.

###  Dinamik Sigorta Paketleri ve Teklif Sistemi
- **Dinamik Listeleme:** Sağlık, Kasko ve Konut Sigortası altındaki tüm paketler (Temel, Standart, Premium) veritabanından dinamik olarak çekilir.
- **Hızlı Teklif (AJAX):** Oturum açmış kullanıcılar ana sayfadaki paketlerden tek tıkla, sayfa yenilenmeden teklif talebi oluşturabilir.
- **Akıllı Formlar:** Giriş yapmış kullanıcıların bilgileri detaylı teklif formlarına otomatik olarak doldurulur (prepopulate), böylece kullanıcı deneyimi (UX) artırılır.

---

##  Kullanılan Teknolojiler

- **Backend:** C#, .NET 10.0, ASP.NET Core MVC
- **Veri Erişim Katmanı:** Entity Framework Core 10.0.7 (Code-First)
- **Veritabanı:** Microsoft SQL Server
- **Frontend:** HTML5, CSS3, JavaScript (Fetch API), Bootstrap 5, Bootstrap Icons
- **Doğrulama:** Data Annotations, jQuery Validation & Unobtrusive Validation

---

##  Veritabanı Mimarisi

Sistem, Code-First yaklaşımı ile tasarlanmış ilişkisel bir veritabanı kullanır:

1. **`InsuranceType` (1) ─── (N) `InsurancePackage`**
   - Her sigorta türünün birden fazla alt paketi bulunur.
2. **`User` (1) ─── (N) `UserPolicy`**
   - Bir kullanıcı sistem üzerinden birden fazla sigorta teklifi isteyebilir.
3. **`InsurancePackage` (1) ─── (N) `UserPolicy`**
   - Poliçeler, ilgili sigorta paketlerine referanslıdır.

*Not: Sistem ilk kez ayağa kaldırıldığında (Seed Data), örnek sigorta türleri ve paketleri veritabanına otomatik olarak eklenir.*

---

##  Proje Dizin Yapısı

```text
Safeish/
├── Controllers/
│   ├── AccountController.cs       # Kimlik doğrulama, profil ve şifre işlemleri
│   └── HomeController.cs          # Ana sayfa listeleme ve teklif oluşturma süreçleri
├── Data/
│   └── SafeishDbContext.cs        # EF Core Context ve Seed Data yapılandırması
├── Migrations/                    # Code-First veritabanı göç (migration) geçmişi
├── Models/
│   ├── ViewModels/                # Veri transfer nesneleri (Login, Register, GetQuote vb.)
│   ├── User.cs, UserPolicy.cs     # Kullanıcı ve Poliçe varlıkları
│   └── InsuranceType.cs, ...      # Sigorta varlıkları
├── Views/
│   ├── Account/                   # Kullanıcı arayüzleri (Giriş, Kayıt, Profil)
│   ├── Home/                      # Ana sayfa ve Teklif formları
│   └── Shared/                    # _Layout.cshtml (ortak şablon)
├── Program.cs                     # Bağımlılık enjeksiyonu (DI) ve Middleware ayarları
└── appsettings.json               # Veritabanı Connection String ayarları
 Kurulum ve Çalıştırma Adımları
Projeyi kendi bilgisayarınızda (lokal ortam) çalıştırmak için aşağıdaki adımları izleyin:

1. Depoyu Klonlayın
Bash
git clone [https://github.com/baranbilge/safeish-insurance.git](https://github.com/baranbilge/safeish-insurance.git)
cd safeish-insurance

2. Veritabanı Bağlantısını Ayarlayın
appsettings.json dosyasını açarak DefaultConnection dizesini kendi SQL Server yapılandırmanıza göre güncelleyin.

JSON
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SafeishDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. Paketleri Yükleyin ve Veritabanını Oluşturun
Terminal (Command Prompt / PowerShell) üzerinden proje dizinindeyken aşağıdaki komutları çalıştırın. Bu komutlar gerekli paketleri kuracak ve tabloları/örnek verileri SQL Server'a aktaracaktır:

Bash
dotnet restore
dotnet ef database update

4. Projeyi Başlatın
Bash
dotnet run

Uygulama başarıyla derlendiğinde tarayıcınızdan http://localhost:5010 veya terminalde belirtilen adrese giderek projeyi görüntüleyebilirsiniz.
