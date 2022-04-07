using System;
using System.Collections.Generic;
using System.Linq;
using libraryMVC.Entities;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace libraryMVC.Data.DataSeed
{
    public class DataSeed
    {
        public DataSeed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();
            if (context.Kitaplar.Count() == 0)
            {
                AddKitaps(context);
            }
            if (context.Users.Count() == 0)
            {
                AddUyes(context);
            }
        }
        private static async void AddKitaps(AppDbContext context)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(new Kitap
            {
                KitapAd = "Kamelyalı Kadın",
                KitapYazari = "Alexandre Dumas",
                KitapBaskiYil = 2019,
                KitapSayfaSayi = 300,
                KitapDil = "Türkçe",
                KitapYayinEvi = "Martı Yayınları",
                KitapAciklama = "-"
            });
            kitaplar.Add(new Kitap
            {
                KitapAd = "Nutuk",
                KitapYazari = "Mustafa Kemal Atatürk",
                KitapBaskiYil = 1927,
                KitapSayfaSayi = 351,
                KitapDil = "Türkçe",
                KitapYayinEvi = "Panama",
                KitapAciklama = "-"
            });
            kitaplar.Add(new Kitap
            {
                KitapAd = "Milena'ya Mektuplar",
                KitapYazari = "Franz Kafka",
                KitapBaskiYil = 2019,
                KitapSayfaSayi = 320,
                KitapDil = "Türkçe",
                KitapYayinEvi = "indigo",
                KitapAciklama = "-"
            });
            await context.Kitaplar.AddRangeAsync(kitaplar);
            await context.SaveChangesAsync();
        }
        private static async void AddUyes(AppDbContext context)
        {
            List<Uye> uyeler = new List<Uye>();
            uyeler.Add(new Uye
            {
                UyeAd = "Emir",
                UyeSoyad = "Gürbüz",
                UyeTelefon = "(555) 555-5555",
                Email = "emir@hotmail.com",
                UserName = "emir@hotmail.com",
                UyeAdres = "Ankara"
            });
            uyeler.Add(new Uye
            {
                UyeAd = "Ahmet",
                UyeSoyad = "Karaçayır",
                UyeTelefon = "(555) 000-5555",
                Email = "akara@hotmail.com",
                UserName = "akara@hotmail.com",
                UyeAdres = "İstanbul"
            });
            uyeler.Add(new Uye
            {
                UyeAd = "Ali",
                UyeSoyad = "Deniz",
                UyeTelefon = "(555) 111-5555",
                Email = "dali@hotmail.com",
                UserName = "dali@hotmail.com",
                UyeAdres = "Bursa"
            });
            await context.Users.AddRangeAsync(uyeler);
            await context.SaveChangesAsync();
            if (context.Emanetler.Count() == 0)
            {
                AddEmanets(context, uyeler);
            }
        }
        private static async void AddEmanets(AppDbContext context, List<Uye> uyeler)
        {
            List<Emanet> emanetler = new List<Emanet>();
            emanetler.Add(new Emanet
            {
                UyeId = uyeler.FirstOrDefault(u => u.UyeAd == "Emir").Id,
                KitapNo = 1,
                EmanetNot = "-",
                EmanetVermeTarih = new DateTime(2022, 4, 7).ToString("yyyy-mm-dd"),
                EmanetIslemTarih = new DateTime(2022, 4, 7).ToString("yyyy-mm-dd"),
                EmanetGeriAlmaTarih = new DateTime(2022, 4, 28).ToString("yyyy-mm-dd"),
                EmanetTeslimEdildi = "Sürüyor"
            });
            emanetler.Add(new Emanet
            {
                UyeId = uyeler.FirstOrDefault(u => u.UyeAd == "Ahmet").Id,
                KitapNo = 2,
                EmanetNot = "-",
                EmanetVermeTarih = new DateTime(2022, 3, 11).ToString("yyyy-mm-dd"),
                EmanetIslemTarih = new DateTime(2022, 3, 11).ToString("yyyy-mm-dd"),
                EmanetGeriAlmaTarih = new DateTime(2022, 3, 25).ToString("yyyy-mm-dd"),
                EmanetTeslimEdildi = "Teslim Edilmedi"
            });
            emanetler.Add(new Emanet
            {
                UyeId = uyeler.FirstOrDefault(u => u.UyeAd == "Ali").Id,
                KitapNo = 3,
                EmanetNot = "-",
                EmanetVermeTarih = new DateTime(2022, 3, 5).ToString("yyyy-mm-dd"),
                EmanetIslemTarih = new DateTime(2022, 3, 5).ToString("yyyy-mm-dd"),
                EmanetGeriAlmaTarih = new DateTime(2022, 3, 19).ToString("yyyy-mm-dd"),
                EmanetTeslimEdildi = "Teslim Edildi"
            });
        }
    }
}