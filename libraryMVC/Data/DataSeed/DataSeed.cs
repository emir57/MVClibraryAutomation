using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using libraryMVC.Entities;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace libraryMVC.Data.DataSeed
{
    public class DataSeed
    {
        public static async void Seed(IApplicationBuilder app)
        {
            IServiceScope scope = app.ApplicationServices.CreateScope();
            AppDbContext context = scope.ServiceProvider.GetService<AppDbContext>();
            UserManager<Uye> userManager = scope.ServiceProvider.GetService<UserManager<Uye>>();
            SignInManager<Uye> signInManager = scope.ServiceProvider.GetService<SignInManager<Uye>>();
            RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
            context.Database.Migrate();
            if (context.Kitaplar.Count() == 0)
            {
                AddKitaps(context);
            }
            if (context.Users.Count() == 0)
            {
                AddUyes(context, userManager);
            }
            if (context.Emanetler.Count() == 0)
            {
                AddEmanets(context);
            }
            if (!(await roleManager.RoleExistsAsync("Admin")))
            {
                await roleManager.CreateAsync(new IdentityRole { Id = "admin-role", Name = "Admin" });
            }
            Uye uye = new Uye
            {
                UyeAd = "admin",
                Email = "admin@hotmail.com",
                UserName = "admin@hotmail.com"
            };
            if ((await userManager.FindByEmailAsync("admin@hotmail.com")) == null)
            {
                await userManager.AddPasswordAsync(uye, "123456aA.");
                await userManager.CreateAsync(uye);
            }
            if (!(await userManager.GetRolesAsync(uye)).Any(x => x == "Admin"))
            {
                await userManager.AddToRoleAsync(uye, "Admin");
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
                KitapAciklama = "-",
                IsActive = true
            });
            kitaplar.Add(new Kitap
            {
                KitapAd = "Nutuk",
                KitapYazari = "Mustafa Kemal Atatürk",
                KitapBaskiYil = 1927,
                KitapSayfaSayi = 351,
                KitapDil = "Türkçe",
                KitapYayinEvi = "Panama",
                KitapAciklama = "-",
                IsActive = true
            });
            kitaplar.Add(new Kitap
            {
                KitapAd = "Milena'ya Mektuplar",
                KitapYazari = "Franz Kafka",
                KitapBaskiYil = 2019,
                KitapSayfaSayi = 320,
                KitapDil = "Türkçe",
                KitapYayinEvi = "indigo",
                KitapAciklama = "-",
                IsActive = false
            });
            await context.Kitaplar.AddRangeAsync(kitaplar);
            await context.SaveChangesAsync();
        }
        private static async void AddUyes(AppDbContext context, UserManager<Uye> userManager)
        {
            Uye uye1 = new Uye
            {
                Id = "21ab7786-a8e2-40e4-b425-a4037db1de00",
                UyeAd = "Emir",
                UyeSoyad = "Gürbüz",
                UyeTelefon = "(555) 555-5555",
                Email = "emir@hotmail.com",
                UserName = "emir@hotmail.com",
                UyeAdres = "Ankara"
            };
            Uye uye2 = new Uye
            {
                Id = "38d9e421-bd6b-473f-88de-07b8ce5a7d08",
                UyeAd = "Ahmet",
                UyeSoyad = "Karaçayır",
                UyeTelefon = "(555) 000-5555",
                Email = "akara@hotmail.com",
                UserName = "akara@hotmail.com",
                UyeAdres = "İstanbul"
            };
            Uye uye3 = new Uye
            {
                Id = "73794d38-4474-49c1-a729-fa8824062419",
                UyeAd = "Ali",
                UyeSoyad = "Deniz",
                UyeTelefon = "(555) 111-5555",
                Email = "dali@hotmail.com",
                UserName = "dali@hotmail.com",
                UyeAdres = "Bursa"
            };
            await userManager.CreateAsync(uye1,"Aa.123");
            await userManager.CreateAsync(uye2,"Aa.123");
            await userManager.CreateAsync(uye3,"Aa.123");
        }
        private static async void AddEmanets(AppDbContext context)
        {
            List<Emanet> emanetler = new List<Emanet>();
            emanetler.Add(new Emanet
            {
                UyeId = "21ab7786-a8e2-40e4-b425-a4037db1de00",
                KitapNo = 1,
                EmanetNot = "-",
                EmanetVermeTarih = new DateTime(2022, 4, 7).ToString("yyyy-mm-dd"),
                EmanetIslemTarih = new DateTime(2022, 4, 7).ToString("yyyy-mm-dd"),
                EmanetGeriAlmaTarih = new DateTime(2022, 4, 28).ToString("yyyy-mm-dd"),
                EmanetTeslimEdildi = "Sürüyor"
            });
            emanetler.Add(new Emanet
            {
                UyeId = "38d9e421-bd6b-473f-88de-07b8ce5a7d08",
                KitapNo = 2,
                EmanetNot = "-",
                EmanetVermeTarih = new DateTime(2022, 3, 11).ToString("yyyy-mm-dd"),
                EmanetIslemTarih = new DateTime(2022, 3, 11).ToString("yyyy-mm-dd"),
                EmanetGeriAlmaTarih = new DateTime(2022, 3, 25).ToString("yyyy-mm-dd"),
                EmanetTeslimEdildi = "Teslim Edilmedi"
            });
            await context.Emanetler.AddRangeAsync(emanetler);
            await context.SaveChangesAsync();
        }
    }
}