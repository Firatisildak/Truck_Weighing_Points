# Kamyon Yönetim Sistemi - Truck Management System

## Proje Açıklaması (Project Description)

Bu proje, kamyonların kaydı, kantar işlemleri ve boşaltma işlemlerini yöneten bir web uygulamasıdır. Uygulama **Blazor WASM** (ön yüz), **Blazor Server veya ASP.NET Core** (arka yüz), ve **Clean Architecture** mimarisi kullanılarak geliştirilmiştir. Veritabanı olarak **MS SQL Express** kullanılmıştır. Ayrıca, **ClosedXML** teknolojisi ile kamyon listesini Excel dosyasına dönüştürme özelliği de eklenmiştir.

### Projenin Akışı (Workflow)
1. **Kayıt**: Kamyon gelir ve kaydı yapılır.
2. **Kantar**: Bilgiler doğru ise kantar tarafından onaylanır.
3. **Boşaltma**: Kamyon boşaltılır.
4. **Kantar**: Kamyon tekrar tartılır ve yeni tartım miktarı yazılır.
5. **Kayıt**: Bilgiler doğru ise onaylanır ve kamyon çıkışı verilir.

### Teknolojiler (Technologies Used)
- **Frontend**: Blazor WASM
- **Backend**: Blazor Server veya ASP.NET Core
- **Database**: MS SQL Express
- **Architecture**: Clean Architecture, Repository Pattern
- **Excel Export**: ClosedXML
- **ORM**: Entity Framework Core

---

## Özellikler (Features)

1. **Kamyon Ekleme / Düzenleme**: 
   - Kullanıcı, "Plaka", "Hammadde" ve "Miktar" bilgilerini girip, "Kaydet" butonuyla kamyonu veritabanına kaydeder.
   
2. **Kamyon Onayı**:
   - Kamyonlar iki kez onaylanabilir: İlk onay kaydın hemen ardından ve ikinci onay, miktar düzenlendikten sonra yapılır.
   - Kamyonlar "ilk onayı bekliyor", "tartım bekliyor" ve "son onay bekliyor" gibi durumlarla takip edilir.
   - Onaylanan kamyonlar, listede görünmez, ancak SQL'den silinmez.

3. **Düzenleme**:
   - Onaylanan kamyonlar, "Düzenle" butonuyla listeden seçilip, miktarları düzenlenebilir ve tekrar kaydedilebilir.
   - Düzenlenen kamyonlar tekrar onaylanabilir.

4. **Excel'e Dışa Aktarma**:
   - Kamyonların listesi, **ClosedXML** kullanılarak Excel dosyasına dönüştürülüp dışa aktarılabilir.

---

## Kullanılan Katmanlar (Project Layers)

### 1. **Entities** 
Veritabanındaki tablo modelleri burada yer alır. Örneğin, `Kamyon` sınıfı kamyon bilgilerini tutar.

### 2. **Data Access** 
Veritabanı işlemleri burada yapılır. `AppDBContext` sınıfı, Entity Framework Core ile yapılandırılır.

### 3. **Services**
Uygulamadaki iş mantığı burada bulunur. CRUD işlemleri ve Excel dışa aktarma işlemleri bu katmanda gerçekleştirilir.

### 4. **ViewModels**
Kullanıcıdan alınan veriler ve API ile kullanılan veri modelleri burada bulunur.

### 5. **Enums**
Uygulama içinde sabit değerlerin bulunduğu kategorilerdir.

---

## Proje Kodları (Code Snippets)

### Kamyon Entity
```csharp
public class Kamyon
{
    public int KamyonId { get; set; }
    public string Plaka { get; set; }
    public string Hammadde { get; set; }
    public decimal Miktar { get; set; }
    public DateTime Tarih { get; set; }
}
