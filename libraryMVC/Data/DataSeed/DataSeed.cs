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

            }
            if (context.Emanetler.Count() == 0)
            {

            }
            if (context.Users.Count() == 0)
            {

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
    }
}