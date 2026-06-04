# YBS Stok ve Satış Yönetimi Simülasyonu (Karar Destek Sistemi)

Bu proje, bir teknoloji mağazasının stok yönetim süreçlerini ve anlık satış senaryolarını simüle etmek amacıyla **Management Information Systems (YBS)** vizyonuyla geliştirilmiş bir konsol uygulamasıdır. 

Proje, işletmelerin karşılaştığı **kritik stok seviyesi yönetimi** ve **yetersiz stok analizi** gibi temel yönetimsel problemleri algoritmik olarak çözer.

---

## Kullanılan C# Yapıları ve Teknikleri

Bu simülasyon projesinde, temelden orta seviyeye kadar şu programlama yapıları aktif olarak kullanılmıştır:

*   **Diziler (Arrays):** Ürün isimleri ve dinamik stok miktarları veritabanı mantığıyla paralel dizilerde tutulmuştur.
*   **Döngüler (Loops):** 7 günlük simülasyon akışı ve güncel depo durumu raporlamaları `for` döngüleri ile yönetilmiştir.
*   **Koşullu İfadeler (If-Else):** Satış anında stok kontrolü ve ürün miktarı 10'un altına düştüğünde sistemin otomatik olarak üreticiye **"Kritik Stok Uyarısı"** vermesi sağlanmıştır.
*   **Metotlar (Methods):** Kodun modüler, okunabilir ve tekrar kullanılabilir olması için satış ve listeleme işlemleri özel metotlara devredilmiştir.
*   **Hazır Fonksiyonlar:** Sistem tarihini çekmek (`DateTime.Now`) ve kritik uyarı metinlerini manipüle etmek (`ToUpper`) için yerleşik C# fonksiyonlarından yararlanılmıştır.

---

## Proje Amacı

Bu çalışma, sadece teknik bir kodlama alıştırması değil; verileri anlamlı birer işletme bilgisine dönüştürmeyi amaçlayan bir **YBS Karar Destek Sistemi** örneğidir.

*Geliştirici: Merve*
