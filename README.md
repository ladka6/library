# Vaka Uygulaması

Bu proje, kütüphanede bulunan kitapların takibi ve ödünç verilmesi için bir kütüphane uygulamasıdır.

## Gereklilikler

- .NET Core
- Entity Framework Core
- MsSql veritabanı
- Bir geliştirme ortamı (örneğin, Visual Studio veya Visual Studio Code)

## Proje Yapısı
LibraryApp
├── Controllers
│ ├── BookController.cs
├── Models
│ ├── Book.cs
│ ├── ApplicationDbContext.cs
├── Views
│ ├── Book
│ │ ├── Index.cshtml
│ │ ├── Add.cshtml
│ │ ├── Borrow.cshtml
├── appsettings.json
└── Program.cs


- `Controllers` klasörü, projenin denetleyicilerini içerir. Her bir denetleyici, ilgili işlemleri gerçekleştirir.
- `Models` klasörü, projenin model sınıflarını içerir. `Book.cs`, kitap verilerini temsil eden model sınıfını içerir ve `ApplicationDbContext.cs`, veritabanı bağlantısını ve veritabanı işlemlerini yöneten sınıfı içerir.
- `Views` klasörü, projenin görünümlerini içerir. Her klasör, ilgili denetleyicinin görünümlerini içerir.
- `appsettings.json`, projenin yapılandırma ayarlarını içerir. Veritabanı bağlantı dizesi gibi bilgiler burada belirtilir.
- `Program.cs`, projenin başlatılmasını ve web sunucusunu çalıştırmayı sağlar.

## Kurulum

1. Bu depoyu yerel makinenize klonlayın veya ZIP olarak indirin.
2. Bir PostgreSQL veritabanı oluşturun ve bağlantı bilgilerini `appsettings.json` dosyasında güncelleyin.
3. Projeyi bir geliştirme ortamında açın (örneğin, Visual Studio veya Visual Studio Code).
4. Proje dosyalarını derleyin ve çalıştırın.

## Kullanım

- Ana sayfada tüm kitapların listelendiği bir görünüm göreceksiniz. Her bir kitabın adı, yazarı ve mevcut durumu (kütüphanede mi yoksa ödünç alındı mı) görüntülenir.
- Bir kitabı ödünç vermek istediğinizde, ilgili kitap için ödünç ver buttonuna tıklayın. İlgili kitabı alan kişinin adı ve geri getirilmesi gereken tarihi girin. Bu bilgiler veritabanına kaydedilecektir.
- Yeni bir kitap eklemek için "Kitap Ekle" bağlantısını kullanabilirsiniz. Kitap adı, yazarı ve resmi gibi bilgileri girmeniz gerekmektedir.

##Endpoints 
- /book
- /book/add
- /book/borrow

