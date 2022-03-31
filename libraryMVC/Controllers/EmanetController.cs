using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libraryMVC.Dtos;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using site.Models;

namespace libraryMVC.Controllers
{
    public class EmanetController : Controller
    {
        private readonly AppDbContext _context;
        public EmanetController(AppDbContext context)
        {
            _context = context;
        }
        private async Task<List<EmanetDto>> GetEmanetDtoAsync()
        {
            List<EmanetDto> emanetler = await (from e in _context.Emanetler
                                               select new EmanetDto
                                               {
                                                   EmanetNo = e.EmanetNo,
                                                   EmanetVermeTarih = e.EmanetVermeTarih,
                                                   EmanetGeriAlmaTarih = e.EmanetGeriAlmaTarih,
                                                   EmanetIslemTarih = e.EmanetIslemTarih,
                                                   EmanetNot = e.EmanetNot,
                                                   EmanetTeslimEdildi = e.EmanetTeslimEdildi,
                                                   Uye = _context.Uyeler.FirstOrDefault(uye => uye.UyeNo == e.UyeNo),
                                                   Kitap = _context.Kitaplar.FirstOrDefault(kitap => kitap.KitapNo == e.KitapNo)
                                               }).ToListAsync();
            return emanetler;
        }
        public async Task<IActionResult> Emanetler(string searchString, int id)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            return View(emanetler);
        }
        [HttpGet]
        public async Task<IActionResult> EmanetlerSearchBySearchString(string searchString = null)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            if (searchString != null)
            {
                searchString = searchString.ToLower();
                emanetler = emanetler.Where(x => x.Kitap.KitapAd.ToLower().Contains(searchString) ||
                                x.Uye.UyeAd.ToLower().Contains(searchString) ||
                                x.Uye.UyeSoyad.ToLower().Contains(searchString) ||
                                x.EmanetNot.ToLower().Contains(searchString)).ToList();
            }
            return Ok(emanetler);
        }
        [HttpGet]
        public async Task<IActionResult> EmanetlerSearchById(int id)
        {
            EmanetDto emanet = (await GetEmanetDtoAsync()).FirstOrDefault(e => e.EmanetNo == id);
            if (emanet == null)
            {
                return NotFound("Not Found");
            }
            return Ok(emanet);
        }
        [HttpPost]
        public async Task<IActionResult> EmanetlerSearch(string searchString, int id)
        {
            if (searchString == null) searchString = "^";
            searchString = searchString.ToLower();
            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = await _context.Emanetler.Where(x =>
                    x.EmanetTeslimEdildi.ToLower().Contains(searchString) || x.EmanetNo == id)
            .ToListAsync();
            return View(arama);
        }
        public async Task<IActionResult> DeleteEmanetler(int id)
        {
            var emanet = await _context.Emanetler.SingleOrDefaultAsync(x => x.EmanetNo == id);
            _context.Emanetler.Remove(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Emanetler");
        }
        public async Task<IActionResult> CreateEmanetler()
        {
            EmanetlerViewModel model = new EmanetlerViewModel
            {
                Uyeler = await _context.Uyeler.ToListAsync(),
                Kitaplar = await _context.Kitaplar.ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmanetler(Emanet emanet)
        {
            if (!ModelState.IsValid)
            {
                return View(emanet);
            }
            DateTime now = DateTime.Now;
            if (emanet.EmanetNot == null) emanet.EmanetNot = "-";
            if (emanet.EmanetNot.Contains("^") == true) emanet.EmanetNot = "-";
            if (emanet.EmanetTeslimEdildi.Contains("^") == true) emanet.EmanetTeslimEdildi = "Sürüyor";
            emanet.EmanetIslemTarih = now.ToString("yyyy/MM/dd");
            emanet.EmanetIslemTarih = emanet.EmanetIslemTarih.Replace(".", "-");
            await _context.Emanetler.AddAsync(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Emanetler");
        }
        public async Task<IActionResult> EditEmanetler(int? id)
        {
            var emanet = await _context.Emanetler.FindAsync(id);
            if (emanet == null)
            {
                return RedirectToAction(nameof(Emanetler));
            }
            return View(emanet);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmanetler(int id, Emanet emanet)
        {
            if (emanet.EmanetNot == null) emanet.EmanetNot = "-";
            if (emanet.EmanetNot.Contains("^") == true) emanet.EmanetNot = "-";
            if (emanet.EmanetTeslimEdildi.Contains("^") == true) emanet.EmanetTeslimEdildi = "Sürüyor";
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emanet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                { }
                return RedirectToAction("Emanetler");
            }
            return View(emanet);
        }
    }
}