using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YbsSirketSimulasyonu
{
    class Program
    {
        // Global Değişkenler (Metotların her yerden erişebilmesi için)
        static int[] stoklar = { 50, 40, 30, 25, 60 }; // 5 farklı ürünün deposu
        static string[] urunler = { "Excalibur Laptop", "Oyuncu Mouse", "Mekanik Klavye", "27' Monitör", "Kulaklık" };

        static void Main(string[] args)
        {
            Console.WriteLine("=== YBS KARAR DESTEK SİMÜLASYONUNA HOŞ GELDİNİZ ===");
            Console.WriteLine("--------------------------------------------------");

            // 1. HAZIR FONKSİYON KULLANIMI: Tarih gösterme
            Console.WriteLine("Simülasyon Tarihi: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("--------------------------------------------------");

            // 2. METOT ÇAĞIRMA: Önce mevcut stok durumunu görelim
            StokDurumuGoster();

            // 3. DÖNGÜ VE RANDOM: 7 günlük hayali bir satış simülasyonu başlatalım
            Random rnd = new Random();
            Console.WriteLine("\n--- 7 GÜNLÜK SATIŞ SİMÜLASYONU BAŞLIYOR ---");

            for (int gun = 1; gun <= 7; gun++)
            {
                Console.WriteLine($"\n>> {gun}. GÜN RAPORU:");

                // Her gün rastgele bir ürün, rastgele adette satılsın
                int rastgeleUrunIndis = rnd.Next(0, urunler.Length); // Dizi sınırları içinde
                int satilanAdet = rnd.Next(1, 10); // En fazla 9 adet satılsın

                // 4. METOT ÇAĞIRMA: Satış işlemini yapması için robotu çağırıyoruz
                SatisYap(rastgeleUrunIndis, satilanAdet);
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Simülasyon Bitti. Son Stok Durumunu Görmek İçin Bir Tuşa Basın.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("=== SİMÜLASYON SONU GÜNCEL DEPO DURUMU ===");
            StokDurumuGoster();

            Console.ReadKey();
        }

        // --- BİZİM YAZDIĞIMIZ METOTLAR (ROBOTLAR) ---

        // Metot 1: Stok durumunu ekrana basan robot (Döngü ve Dizi kullanır)
        static void StokDurumuGoster()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{urunler[i]} -> Kalan Stok: {stoklar[i]}");
            }
        }

        // Metot 2: Satış işlemlerini kontrol eden ve stoktan düşen robot (If-Else kullanır)
        static void SatisYap(int urunIndex, int adet)
        {
            string secilenUrun = urunler[urunIndex];
            int mevcutStok = stoklar[urunIndex];

            // IF-ELSE KONTROLÜ: Stok yeterli mi?
            if (mevcutStok >= adet)
            {
                stoklar[urunIndex] -= adet; // Stoktan düş (Diziyi güncelle)
                Console.WriteLine($"✓ BAŞARILI: {secilenUrun} ürününden {adet} adet satıldı.");

                // YBS Kritik Stok Uyarısı (Yeni stok durumuna bakıyoruz)
                if (stoklar[urunIndex] < 10)
                {
                    // HAZIR FONKSİYON KULLANIMI: Yazıyı büyük harfe çevirerek dikkat çekelim
                    Console.WriteLine($"!! KRİTİK UYARI: {secilenUrun.ToUpper()} STOĞU 10'UN ALTINA DÜŞTÜ! ACİL SİPARİŞ VERİN.");
                }
            }
            else
            {
                Console.WriteLine($"X BAŞARISIZ: {secilenUrun} satılmak istendi ({adet} adet) ama YETERSİZ STOK! (Mevcut: {mevcutStok})");
            }
        }
    }
}
