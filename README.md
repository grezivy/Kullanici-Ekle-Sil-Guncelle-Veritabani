📋 C# Windows Forms Personel / Kullanıcı Yönetim Sistemi (CRUD)
Selamlar! Bu proje, C# ve Windows Forms kullanarak geliştirdiğim bellek içi (in-memory) veri yönetimi gerçekleştiren bir CRUD (Create, Read, Update, Delete) uygulamasıdır.

Bu çalışmada, herhangi bir SQL veritabanı kurulumuna gerek kalmadan verileri doğrudan bellekte tutan sanal bir tablo yapısı kullandım.

🚀 Projenin Öne Çıkan Özellikleri
Sanal Veritabanı (DataTable): Veriler bir SQL veritabanı yerine System.Data.DataTable nesnesi üzerinde bellekte saklanır.

Otomatik ID Yönetimi: Eklenen her yeni kayda otomatik artan bir Id atanır.

Ekle (Create): Form üzerindeki TextBox'lara yazılan veriler validasyon kontrolünden geçerek tabloya eklenir.

Listele & Seç (Read): DataGridView üzerinde listelenen kişilerden birine tıklandığında bilgiler otomatik olarak yukarıdaki alanlara aktarılır.

Güncelle (Update): Tablodan seçilen kaydın bilgileri güncellenerek görünüm tazelenir.

Sil (Delete): Tablodan seçilen satır sanal tablodan tamamen kaldırılır.

Dinamik Event Bağlantıları: Olayların (Click, CellClick, Load) çakışmasını veya çift tetiklenmesini önlemek için olay abonelikleri yapıcı metod (Constructor) içinde güvenli bir şekilde yönetilmiştir.

🛠️ Kod Yapısı ve Kullanılan Mantık
Girdi Doğrulama (Validation): Kayıt ekleme sırasında string.IsNullOrWhiteSpace kontrolü yapılarak boş ad girilmesi engellenir.

Güvenli Seçim İndeksi: DataGridView seçimlerinde indeks taşması hatası (IndexOutOfRangeException) almamak için RowIndex sınır kontrolleri yapılmıştır.

Satır Temizleme: Her işlemden sonra Temizle() metodu çağrılarak TextBox'lar boşaltılır ve seçim sıfırlanır.

💻 Nasıl Çalıştırılır?
Projeyi bilgisayarınıza indirin (Clone edin veya .zip olarak indirin).

Visual Studio ile hft2_nesnetabanli.sln dosyasını açın.

Klavyeden F5 tuşuna basarak projeyi derleyip çalıştırabilirsiniz.
