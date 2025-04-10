ReadMe.txt


## Eczane Otomasyonu Projesi

### Projenin Amacı
Eczane Otomasyonu, eczanelerin günlük işlemlerini kolaylaştırmak, reçete yönetimini düzenlemek, stok kontrolünü sağlamak ve satış işlemlerini takip etmek için tasarlanmış bir masaüstü uygulamasıdır. Bu belge, projeyi çalıştırma ve kullanım talimatlarını içermektedir.

---

### Gereksinimler
1. **Yazılım Gereksinimleri**
   - Microsoft Visual Studio (2022 veya üzeri önerilir)
   - .NET Framework (4.7.2 veya üzeri)
   - Microsoft SQL Server (2019 veya üzeri)
   - SQL Server Management Studio (SSMS)

2. **Donanım Gereksinimleri**
   - Minimum 4 GB RAM
   - Minimum 2 GHz işlemci
   - En az 500 MB boş disk alanı

---

### Projenin Kurulumu
1. **Kaynak Kodun İndirilmesi**
   - Bu projeyi zip dosyasını çıkarın.
   
2. **Veritabanının Kurulumu**
   - `Eczane Otomasyonu.bak` dosyasını SQL Server Management Studio ile açın.
   - "Execute" (Çalıştır) butonuna basarak veritabanı tablolarını, stored procedure'ları, view'ları ve trigger'ları oluşturun.
   
3. **Visual Studio'da Projeyi Açma**
   - Visual Studio'yu açın.
   - **File > Open > Project/Solution** yolunu izleyerek 'Eczane Otomasyonu.sln' dosyasını seçin.

4. **Veritabanı Bağlantısı**
   - `DatabaseConnection.cs` dosyasını açın.
   - Aşağıdaki bağlantı stringini düzenleyin:
     ```csharp
     string connectionString = "Server=SERVER_ADINIZ;Database=Eczane Otomasyonu;Trusted_Connection=True;";
     ```

5. **Projenin Derlenmesi ve Çalıştırılması**
   - **Build > Build Solution** yolunu izleyerek projeyi derleyin.
   - **Debug > Start Debugging** veya `F5` tuşuna basarak uygulamayı çalıştırın.

---

### Kullanım
1. **Giriş Ekranı**
   - Kullanıcı adı ve şifre ile giriş yapın.
   - Örnek kullanıcı bilgileri:
     - Kullanıcı Adı: `admin`
     - Şifre: `1234`

2. **Ana Menü**
   - Ana formdaki menülerden işlemleri seçerek ilgili modülleri açabilirsiniz:
     - **Reçeteler**: Reçete oluşturma, görüntüleme.
     - **Stok Yönetimi**: İlaç ekleme, düzenleme, kritik stok uyarıları.
     - **Kullanıcı Yönetimi**: Çalışan ekleme, düzenleme, silme.

3. **PanelContent Kullanımı**
   - Üst menüde seçtiğiniz modül, ana formdaki panelde gösterilecektir.

4. **Raporlama**
   - Satış ve stok raporlarını `Raporlar` menüsü altında görüntüleyebilirsiniz.

---

### Önemli Notlar
- **Kritik Stok Seviyesi**: İlacın stok miktarı belirlenen seviyenin altına düştüğünde otomatik olarak uyarı verilir.
- **Son Kullanma Tarihi Kontrolü**: Son kullanma tarihi geçen ilaçlar satışa kapatılır.
- **Güncellemeler**: Proje dosyalarını güncel tutmak için yeni sürüm dosyalarını indirip mevcut projeye eklemeyi unutmayın.

---

### Sorun Giderme
- **Bağlantı Hatası**: SQL Server bağlantısında hata alırsanız, bağlantı stringini ve SQL Server hizmetinin çalıştığını kontrol edin.
- **Eksik Dosyalar**: Eğer bir dosya eksikse projenin orijinal halini tekrar indirip güncel dosyalarla değiştirin.




