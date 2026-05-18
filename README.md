\# Safeish - Sigortacılık Yönetim Platformu 



\*\*Safeish\*\*, kullanıcıların farklı sigorta türlerini inceleyebildiği, bu türlere ait özel paketleri satın alabildiği ve finansal danışmanlık hizmetlerine erişebildiği kapsamlı bir sigortacılık web uygulamasıdır. Proje, modern web standartlarına uygun olarak \*\*.NET 10\*\* ve \*\*MVC mimarisi\*\* kullanılarak geliştirilmektedir.



\##  Özellikler



\- \*\*Modern ve Tematik Arayüz:\*\* Kurumsal güven hissi veren, sigortacılık sektörüne uygun, mobil uyumlu (responsive) UI/UX tasarımı.

\- \*\*Kullanıcı Kimlik Doğrulama (Auth):\*\* 

&#x20; - Kayıt Ol ve Giriş Yap sayfaları.

&#x20; - \*"Hesabınız yok mu? Hemen kayıt olun!"\* yönlendirmesi.

&#x20; - \*"Parolamı unuttum"\* akışı.

\- \*\*Dinamik Sigorta Paketleri:\*\* Çeşitli sigorta türleri (Örn: Kasko, DASK, Sağlık) ve bu türlere ait alt paketlerin listelenmesi.

\- \*\*Genişletilmiş Menü Yapısı:\*\*

&#x20; - Ana Sayfa

&#x20; - Sigortalar

&#x20; - Anlaşmalı Kurumlar

&#x20; - Finansal Danışmanlık

&#x20; - İletişim



\##  Kullanılan Teknolojiler ve Mimari



\- \*\*Framework:\*\* .NET 10.0

\- \*\*Mimari:\*\* ASP.NET Core MVC (Model-View-Controller)

\- \*\*Veritabanı:\*\* SQL Server 

\- \*\*ORM:\*\* Entity Framework Core

\- \*\*Kimlik Doğrulama:\*\* ASP.NET Core Identity (Login/Register işlemleri için)

\- \*\*Front-End:\*\* HTML5, CSS3, Bootstrap 5 (veya Tailwind CSS), JavaScript



\###  Gerekli NuGet Paketleri

Projeyi geliştirirken aşağıdaki paketler kullanılmıştır:

\- `Microsoft.EntityFrameworkCore`

\- `Microsoft.EntityFrameworkCore.SqlServer`

\- `Microsoft.EntityFrameworkCore.Tools` (Migration işlemleri için)

\- `Microsoft.AspNetCore.Identity.EntityFrameworkCore`



\##  Veritabanı ve ER Diyagramı



Projenin veritabanı yapısı Entity Framework Core \*\*Code-First\*\* yaklaşımıyla tasarlanmıştır.



\### Varlık-İlişki (ER) Diyagramı



Aşağıdaki diyagram tablolar arası ilişkileri göstermektedir:



```mermaid

erDiagram

&#x20;   USER ||--o{ POLICY : owns

&#x20;   INSURANCE\_TYPE ||--|{ INSURANCE\_PACKAGE : contains

&#x20;   INSURANCE\_PACKAGE ||--o{ POLICY : generates

&#x20;   

&#x20;   USER {

&#x20;       int Id PK

&#x20;       string Email

&#x20;       string PasswordHash

&#x20;       string FullName

&#x20;       string PhoneNumber

&#x20;   }

&#x20;   

&#x20;   INSURANCE\_TYPE {

&#x20;       int Id PK

&#x20;       string TypeName "Örn: Sağlık, Araç"

&#x20;       string Description

&#x20;   }

&#x20;   

&#x20;   INSURANCE\_PACKAGE {

&#x20;       int Id PK

&#x20;       int InsuranceTypeId FK

&#x20;       string PackageName

&#x20;       decimal Price

&#x20;       string Details

&#x20;   }

&#x20;   

&#x20;   POLICY {

&#x20;       int Id PK

&#x20;       int UserId FK

&#x20;       int PackageId FK

&#x20;       DateTime StartDate

&#x20;       DateTime EndDate

&#x20;       bool IsActive

&#x20;   }

&#x20;   

&#x20;   CORPORATE\_PARTNER {

&#x20;       int Id PK

&#x20;       string InstitutionName

&#x20;       string Sector

&#x20;       string ContactInfo

&#x20;   }

```



&#x20;Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:



1\. Depoyu Klonlayın:



Bash

git clone \[https://github.com/baranbilge/safeish.git](https://github.com/baranbilge/safeish.git)

cd Safeish

2\. Bağlantı Dizesini (Connection String) Ayarlayın:

appsettings.json dosyası içerisindeki DefaultConnection değerini kendi SQL Server ayarlarınıza göre güncelleyin:



JSON

"ConnectionStrings": {

&#x20; "DefaultConnection": "Server=YOUR\_SERVER\_NAME;Database=SafeishDb;Trusted\_Connection=True;MultipleActiveResultSets=true;Encrypt=False"

}

3\. Gerekli Paketleri Yükleyin ve Veritabanını Güncelleyin:

Package Manager Console (PMC) veya .NET CLI kullanarak Migration'ları uygulayın:



Bash

dotnet restore

dotnet ef database update

(veya PMC üzerinden: Update-Database)



4\. Projeyi Başlatın:



Bash

dotnet run



&#x20;Proje Dizin Yapısı

/Controllers: HomeController, AccountController (Giriş/Kayıt), InsuranceController vb. yönlendirme mantıkları.



/Models: Veritabanı tablolarının C# sınıfları (User, InsuranceType, InsurancePackage vb.) ve SafeishDbContext.



/Views: Arayüz dosyaları (.cshtml). Tematik tasarım klasörü.



/Views/Account/Login.cshtml ("Hesabınız yok mu?", "Parolamı unuttum" linklerini içerir)



/Views/Shared/\_Layout.cshtml (Ana menü: Ana Sayfa, Sigortalar, Anlaşmalı Kurumlar vb.)



/wwwroot: CSS, JS, resimler ve site temasına ait statik dosyalar.

