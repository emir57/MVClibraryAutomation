using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using site.Models;
using Microsoft.EntityFrameworkCore;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Authorization;
using libraryMVC.Models;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult Uyeler(string searchString, int id)
        {
            return View(_context.Uyeler);
        }
        [HttpPost]
        public IActionResult UyelerSearch(string searchString, int id)
        {
            if(searchString==null)searchString="^";
            searchString = searchString.ToLower();
            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = _context.Uyeler.Where(x => x.UyeAd.ToLower().Contains(searchString) || x.UyeSoyad.ToLower().Contains(searchString) || x.UyeEposta.ToLower().Contains(searchString) || x.UyeTelefon.Contains(searchString) || x.UyeAdres.ToLower().Contains(searchString) || x.UyeNo == id).ToList();
            return View(arama);
        }
        public IActionResult Emanetler(string searchString, int id)
        {
            return View(_context.Emanetler);
        }
        [HttpPost]
        public IActionResult EmanetlerSearch(string searchString, int id)
        {
            if(searchString==null)searchString="^";
            searchString = searchString.ToLower();

            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = _context.Emanetler.Where(x => x.EmanetTeslimEdildi.ToLower().Contains(searchString) || x.EmanetNo==id).ToList();
            
            return View(arama);
        }
        public async Task<IActionResult> DeleteUyeler(int id)
        {
            var uye = _context.Uyeler.SingleOrDefault(x => x.UyeNo==id);
            _context.Uyeler.Remove(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction("Uyeler");
        }
        
        public async Task<IActionResult> DeleteEmanetler(int id)
        {
            var emanet = _context.Emanetler.SingleOrDefault(x => x.EmanetNo==id);
            _context.Emanetler.Remove(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Emanetler");
        }
        public IActionResult CreateEmanetler()
        {
            return View();
        }
        public IActionResult CreateKitaplar()
        {
            return View();
        }
        public IActionResult CreateUyeler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmanetler(Emanet emanet)
        {
            DateTime now = DateTime.Now;
            if(emanet.EmanetNot==null)emanet.EmanetNot="-";
            if(emanet.EmanetNot.Contains("^") == true) emanet.EmanetNot="-";
            if(emanet.EmanetTeslimEdildi.Contains("^")==true) emanet.EmanetTeslimEdildi="Sürüyor";
            emanet.EmanetIslemTarih = now.ToString("yyyy/MM/dd");
            emanet.EmanetIslemTarih = emanet.EmanetIslemTarih.Replace(".","-");
            _context.Emanetler.Add(emanet);
            _context.SaveChanges();
            return RedirectToAction("Emanetler");
        }
        
        [HttpPost]
        public IActionResult CreateUyeler(Uye uye)
        {
            if(uye.UyeAd.Contains("^") == true) uye.UyeAd="-";
            if(uye.UyeSoyad.Contains("^")==true) uye.UyeSoyad="-";
            if(uye.UyeTelefon.Contains("^")==true) uye.UyeTelefon="000 000 00 00";
            if(uye.UyeEposta.Contains("^")==true) uye.UyeEposta="unknown@hotmail.com";
            if(uye.UyeAdres.Contains("^")==true) uye.UyeAdres="Ankara";
            _context.Uyeler.Add(uye);
            _context.SaveChanges();
            return RedirectToAction("Uyeler");
        }
        public async Task<IActionResult> EditEmanetler(int? id)
        {
            
            var emanet = await _context.Emanetler.FindAsync(id);
            if(emanet == null)
            {

            }
            return View(emanet);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmanetler(int id, [Bind("EmanetNo,UyeNo,KitapNo,EmanetVermeTarih,EmanetGeriAlmaTarih,EmanetIslemTarih,EmanetNot,EmanetTeslimEdildi")] Emanet emanet)
        {
            if (id != emanet.EmanetNo)
            {
                
            }
            if(emanet.EmanetNot==null)emanet.EmanetNot="-";
            if(emanet.EmanetNot.Contains("^") == true) emanet.EmanetNot="-";
            if(emanet.EmanetTeslimEdildi.Contains("^")==true) emanet.EmanetTeslimEdildi="Sürüyor";

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emanet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                        
                }
                return RedirectToAction("Emanetler");
            }
            return View(emanet);
        }
        
        public IActionResult EditUyeler(int? id)
        {
            
            var uye = _context.Uyeler.Where(x => x.UyeNo==id).SingleOrDefault();
            if(uye == null)
            {

            }
            return View(uye);
        }
        [HttpPost]
        public async Task<IActionResult> EditUyeler(int id, [Bind("UyeNo,UyeAd,UyeSoyad,UyeTelefon,UyeEposta,UyeAdres")] Uye uye)
        {
            if (id != uye.UyeNo)
            {
                
            }
            if(uye.UyeAd.Contains("^")==true) uye.UyeAd="-";
            if(uye.UyeSoyad.Contains("^")==true) uye.UyeSoyad="-";
            if(uye.UyeEposta.Contains("^")==true) uye.UyeEposta="unknown@hotmail.com";
            if(uye.UyeTelefon.Contains("^")==true) uye.UyeTelefon="000 000 00 00";
            if(uye.UyeAdres.Contains("^")==true) uye.UyeAdres="Ankara";

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uye);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                        
                }
                return RedirectToAction("Uyeler");
            }
            return View(uye);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
