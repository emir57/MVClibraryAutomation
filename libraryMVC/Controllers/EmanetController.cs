using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libraryMVC.Dtos;
using libraryMVC.Entities;
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
        public async Task<IActionResult> Emanetler(string message = null)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            return View(emanetler);
        }
        //TODO: add date search
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetIslem(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.EmanetIslemTarih) >= startDate && Convert.ToDateTime(e.EmanetIslemTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aralığında kayıt bulunamadı");
            }
            return Ok(emanetler);
        }
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetGeriAlma(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.EmanetGeriAlmaTarih) >= startDate && Convert.ToDateTime(e.EmanetGeriAlmaTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aralığında kayıt bulunamadı");
            }
            return Ok(emanetler);
        }
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetVerme(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.EmanetVermeTarih) >= startDate && Convert.ToDateTime(e.EmanetVermeTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aralığında kayıt bulunamadı");
            }
            return Ok(emanetler);
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
                                x.EmanetNot.ToLower().Contains(searchString) ||
                                x.EmanetTeslimEdildi.ToLower().Contains(searchString)).ToList();
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
        public async Task<IActionResult> DeleteEmanetler(int id)
        {
            var emanet = await _context.Emanetler.SingleOrDefaultAsync(x => x.EmanetNo == id);
            _context.Emanetler.Remove(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Emanetler");
        }
        public async Task<IActionResult> CreateEmanetler()
        {
            EmanetViewModel model = new EmanetViewModel
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
            emanet.EmanetIslemTarih = DateTime.Now.ToString("yyyy/MM/dd");
            emanet.EmanetIslemTarih = emanet.EmanetIslemTarih.Replace(".", "-");
            await _context.Emanetler.AddAsync(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Emanetler), new { @message = "Emanet başarıyla eklendi" });
        }
        public async Task<IActionResult> EditEmanetler(int? id)
        {
            var emanet = await _context.Emanetler.FindAsync(id);
            if (emanet == null)
            {
                return RedirectToAction(nameof(Emanetler));
            }
            //TODO: mapping
            EmanetViewModel model = new EmanetViewModel
            {
                Emanet = emanet,
                Kitaplar = await _context.Kitaplar.ToListAsync(),
                Uyeler = await _context.Uyeler.ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmanetler(EmanetViewModel emanetViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(emanetViewModel);
            }
            //TODO: mapping
            _context.Update(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Emanetler), new { @message = "Emanet başarıyla güncellendi" });
        }
    }
}