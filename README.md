# 📚 Patika Kütüphane Kitap Kayıt Uygulaması

Bu proje, bir kütüphane uygulaması için **kitap kayıt sistemi** oluşturarak kitap bilgilerini yönetmeyi ve kaydetmeyi amaçlar. Proje kapsamında bir `Kitap` sınıfı tanımlanmış ve iki farklı constructor ile kitap nesneleri oluşturulmuştur.

---

## 🚀 Proje Özellikleri

### 📖 Kitap Sınıfı
`Kitap` sınıfında aşağıdaki özellikler bulunmaktadır:
- **Ad (Title)**: Kitabın adı (string).
- **YazarAd (AuthorFirstName)**: Yazarın adı (string).
- **YazarSoyad (AuthorLastName)**: Yazarın soyadı (string).
- **SayfaSayisi (PageCount)**: Kitabın toplam sayfa sayısı (int).
- **Yayınevi (Publisher)**: Kitabın yayınevi (string).
- **KayitTarihi (RegistrationDate)**: Kitabın kayıt edildiği tarih (otomatik olarak atanır) (DateTime).

---

### 🔨 Constructor'lar
1. **Default Constructor** (Parametresiz):
   - `KayitTarihi` özelliğini otomatik olarak "şu anki tarih ve saat" (yani `DateTime.Now`) olarak atar.
   - Özellikler daha sonra ayrı ayrı atanabilir.

2. **Parametreli Constructor**:
   - Kitabın `Ad`, `YazarAd`, `YazarSoyad`, `SayfaSayisi` ve `Yayınevi` bilgilerini nesne oluşturulurken parametre olarak alır.
   - `KayitTarihi` özelliğini yine otomatik olarak "şu anki tarih ve saat" olarak at
