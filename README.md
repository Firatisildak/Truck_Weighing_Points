
# Truck Management System - Kamyon Yönetim Sistemi

## Project Description 

This project is a web application that manages truck registration, weighbridge processes, and unloading operations. The application is built using **Blazor WASM** for the front end, **Blazor Server or ASP.NET Core** for the back end, and **Clean Architecture**. **MS SQL Express** is used for the database, and the feature to export the truck list to an Excel file is implemented using **ClosedXML** technology.

### Workflow
1. **Registration**: The truck arrives and is registered.
2. **Weighbridge**: If the information is correct, the weighbridge approves it.
3. **Unloading**: The truck is unloaded.
4. **Weighbridge**: The truck is weighed again and the new weight is recorded.
5. **Registration**: If the information is correct, it is approved, and the truck exits.

### Technologies Used
- **Frontend**: Blazor WASM
- **Backend**: Blazor Server or ASP.NET Core
- **Database**: MS SQL Express
- **Architecture**: Clean Architecture, Repository Pattern
- **Excel Export**: ClosedXML
- **ORM**: Entity Framework Core

---

## Features

1. **Add / Edit Truck**:
   - The user enters the "Plate", "Raw Material", and "Weight" information and saves the truck to the database by clicking the "Save" button.

2. **Truck Approval**:
   - Trucks can be approved twice: Once after registration and once after weight adjustment.
   - Trucks are tracked by their statuses: "waiting for first approval", "waiting for weighbridge", and "waiting for final approval".
   - After final approval, the truck will disappear from the list but will not be deleted from the SQL database.

3. **Edit Truck**:
   - Trucks in the approval list can be edited. The user is redirected to the registration page, where the "Weight" field can be adjusted and saved again.
   - After editing, the truck can be approved once more.

4. **Export to Excel**:
   - The truck list can be exported to an Excel file using **ClosedXML** technology.

---

## Project Layers

### 1. **Entities**
This layer contains the database models. For example, the `Truck` class stores truck details.

### 2. **Data Access**
The database operations are handled here. The `AppDBContext` class is configured with Entity Framework Core.

### 3. **Services**
Business logic is handled here. CRUD operations and the Excel export function are implemented in this layer.

### 4. **ViewModels**
This layer contains models for the data entered by the user and the data used by the API.

### 5. **Enums**
This layer contains constants used across the application.

---

## Code Snippets

### Truck Entity
```csharp
public class Truck
{
    public int TruckId { get; set; }
    public string Plate { get; set; }
    public string RawMaterial { get; set; }
    public decimal Weight { get; set; }
    public DateTime Date { get; set; }
}
```
## Proje Açıklaması

Bu proje, kamyonların kaydı, kantar işlemleri ve boşaltma işlemlerini yöneten bir web uygulamasıdır. Uygulama **Blazor WASM** (ön yüz), **Blazor Server veya ASP.NET Core** (arka yüz), ve **Clean Architecture** mimarisi kullanılarak geliştirilmiştir. Veritabanı olarak **MS SQL Express** kullanılmıştır. Ayrıca, **ClosedXML** teknolojisi ile kamyon listesini Excel dosyasına dönüştürme özelliği de eklenmiştir.

### Projenin Akışı
1. **Kayıt**: Kamyon gelir ve kaydı yapılır.
2. **Kantar**: Bilgiler doğru ise kantar tarafından onaylanır.
3. **Boşaltma**: Kamyon boşaltılır.
4. **Kantar**: Kamyon tekrar tartılır ve yeni tartım miktarı yazılır.
5. **Kayıt**: Bilgiler doğru ise onaylanır ve kamyon çıkışı verilir.

### Teknolojiler
- **Frontend**: Blazor WASM
- **Backend**: Blazor Server veya ASP.NET Core
- **Database**: MS SQL Express
- **Architecture**: Clean Architecture, Repository Pattern
- **Excel Export**: ClosedXML
- **ORM**: Entity Framework Core

---

## Özellikler

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

## Kullanılan Katmanlar

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
