# Otel Yönetim Sistemi

Bu proje, otellerin müşteri, oda ve rezervasyon işlemlerini yönetebilmesi için geliştirilmiş kapsamlı bir yönetim sistemidir.

## Proje Hakkında

Otel Yönetim Sistemi, otellerin günlük operasyonlarını dijital ortamda yönetmelerini sağlayan bir yazılım çözümüdür. Sistem, müşteri kayıtları, oda yönetimi, rezervasyon işlemleri ve fatura oluşturma gibi temel otel işlemlerini kapsamaktadır.

## Diyagramlar

### UML Diyagramı

![image](https://github.com/user-attachments/assets/4ad9a520-4316-487d-958e-6140d124a068)

### ER Diyagramı

![image](https://github.com/user-attachments/assets/a4493213-1f45-4f71-ba9b-b44162c11570)

### Use-Case Diyagramı

![image](https://github.com/user-attachments/assets/4e7f4fa4-fa05-4ce8-83e3-e2b60d577931)


## Özellikler

### Müşteri Yönetimi
- Yeni müşteri kaydı oluşturma
- Müşteri bilgilerini güncelleme
- Müşteri kaydı silme
- Müşteri listesi görüntüleme
- TC Kimlik numarasına göre müşteri arama

### Oda Yönetimi
- Yeni oda ekleme
- Oda bilgilerini güncelleme
- Oda kaydı silme
- Oda listesi görüntüleme
- Oda müsaitlik durumu takibi

### Rezervasyon İşlemleri
- Yeni rezervasyon oluşturma
- Rezervasyon güncelleme
- Rezervasyon iptal etme
- Rezervasyon listesi görüntüleme

### Fatura İşlemleri
- Otomatik fatura oluşturma
- Fatura görüntüleme
- Fatura güncelleme
- Fatura silme

## Sistem Mimarisi

Proje N Katmanlı Mimari yapısı ile geliştirilmiştir:

### 1. Varlık Katmanı (Entity)
- Musteri
- Oda
- Rezervasyon
- Fatura
- Yonetici

### 2. Veri Erişim Katmanı (DAL)
- MusteriDAL
- OdaDAL
- RezervasyonDAL
- FaturaDAL
- YoneticiDAL

### 3. İş Katmanı (Service)
- MusteriService
- OdaService
- RezervasyonService
- FaturaService
- YoneticiService

## Veritabanı Yapısı

### Musteri_Tablo
- Musteri_ID (PK)
- Musteri_Adsoyad
- Musteri_Telefon
- Musteri_Cinsiyet
- Musteri_TCKimlik (Unique)

### Oda_Tablo
- Oda_ID (PK)
- Oda_Numara (Unique)
- Fiyat
- Oda_Tip
- Musaitlik
- Kat

### Rezervasyon_Tablo
- Rezerv_ID (PK)
- Musteri_TCKimlik (FK)
- Oda_Numara (FK)
- Giris_Tarihi
- Cikis_Tarihi
- Durum

### Fatura_Tablo
- Fatura_ID (PK)
- Musteri_TCKimlik (FK)
- Musteri_Adsoyad
- Giris_Tarihi
- Cikis_Tarihi
- Gun_Sayisi
- Son_Fiyat

  ## Youtube Videosu
https://youtu.be/Ys2kEjizIx0
