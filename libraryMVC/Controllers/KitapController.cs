using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using libraryMVC_.Data;
using Microsoft.EntityFrameworkCore;
using libraryMVC.Models;

namespace libraryMVC.Controllers
{
    public class KitapController : Controller
    {
        private readonly AppDbContext _context;
        public KitapController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Kitaplar(string searchString, int id)
        {
            return View(_context.Kitaplar);
        }
        [HttpPost]
        public async Task<IActionResult> KitaplarSearch(string searchString, int id)
        {
            if (searchString == null) searchString = "^";
            searchString = searchString.ToLower();
            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = await _context.Kitaplar.Where(x => x.KitapAd.ToLower().Contains(searchString) ||
                    x.KitapYazari.ToLower().Contains(searchString) ||
                    x.KitapYayinEvi.ToLower().Contains(searchString) ||
                    x.KitapDil.ToLower().Contains(searchString) || x.KitapNo == id)
            .ToListAsync();
            return View(arama);
        }
        public async Task<IActionResult> DeleteKitaplar(int id)
        {
            var kitap = await _context.Kitaplar.SingleOrDefaultAsync(x => x.KitapNo == id);
            _context.Kitaplar.Remove(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction("Kitaplar");
        }
        public IActionResult CreateKitaplar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateKitaplar(Kitap kitap)
        {
            if (kitap.KitapAciklama == null) kitap.KitapAciklama = "-";
            if (kitap.KitapAd.Contains("^") == true) kitap.KitapAd = "-";
            if (kitap.KitapAciklama.Contains("^") == true) kitap.KitapAciklama = "-";
            if (kitap.KitapDil.Contains("^") == true) kitap.KitapDil = "Türkçe";
            await _context.Kitaplar.AddAsync(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction("Kitaplar");
        }
        public async Task<IActionResult> EditKitaplar(int? id)
        {
            var kitap = await _context.Kitaplar.Where(x => x.KitapNo == id).SingleOrDefaultAsync();
            if (kitap == null)
            {
                return RedirectToAction(nameof(Kitaplar));
            }
            return View(kitap);
        }
        [HttpPost]
        public async Task<IActionResult> EditKitaplar(int id, Kitap kitap)
        {
            if (kitap.KitapAciklama == null) kitap.KitapAciklama = "-";
            if (kitap.KitapAd.Contains("^") == true) kitap.KitapAd = "-";
            if (kitap.KitapYazari.Contains("^") == true) kitap.KitapYazari = "-";
            if (kitap.KitapDil.Contains("^") == true) kitap.KitapDil = "Türkçe";
            if (kitap.KitapYayinEvi.Contains("^") == true) kitap.KitapYayinEvi = "-";
            if (kitap.KitapAciklama.Contains("^") == true) kitap.KitapAciklama = "-";
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {}
                return RedirectToAction("Kitaplar");
            }
            return View(kitap);
        }
    }
}