using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC.Controllers
{
    public class UyeController : Controller
    {
        private readonly AppDbContext _context;
        public UyeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Uyeler(string searchString, int id)
        {
            return View(_context.Uyeler);
        }
        [HttpGet]
        public async Task<IActionResult> UyelerSearchBySearchString(string searchString = null)
        {
            List<Uye> uyeler;
            if (searchString == null)
            {
                uyeler = await _context.Uyeler.ToListAsync();
                return Ok(uyeler);
            }
            searchString = searchString.ToLower();
            uyeler = await _context.Uyeler.Where(x => x.UyeAd.ToLower().Contains(searchString) ||
                    x.UyeSoyad.ToLower().Contains(searchString) ||
                    x.UyeEposta.ToLower().Contains(searchString) ||
                    x.UyeTelefon.Contains(searchString)).ToListAsync();
            return Ok(uyeler);
        }
        [HttpGet]
        public async Task<IActionResult> UyelerSearchById(int? id = null)
        {
            Uye uye;
            if (id == null)
            { }
            uye = await _context.Uyeler.FirstOrDefaultAsync(x => x.UyeNo == id);
            if (uye == null)
            {
                return BadRequest("Üye bulunamadı");
            }
            return Ok(uye);
        }
        public async Task<IActionResult> DeleteUyeler(int id)
        {
            var uye = await _context.Uyeler.SingleOrDefaultAsync(x => x.UyeNo == id);
            _context.Uyeler.Remove(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction("Uyeler");
        }
        public IActionResult CreateUyeler()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUyeler(Uye uye)
        {
            if (uye.UyeAd.Contains("^") == true) uye.UyeAd = "-";
            if (uye.UyeSoyad.Contains("^") == true) uye.UyeSoyad = "-";
            if (uye.UyeTelefon.Contains("^") == true) uye.UyeTelefon = "000 000 00 00";
            if (uye.UyeEposta.Contains("^") == true) uye.UyeEposta = "unknown@hotmail.com";
            if (uye.UyeAdres.Contains("^") == true) uye.UyeAdres = "Ankara";
            await _context.Uyeler.AddAsync(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction("Uyeler");
        }
        public async Task<IActionResult> EditUyeler(int? id)
        {
            var uye = await _context.Uyeler.Where(x => x.UyeNo == id).SingleOrDefaultAsync();
            if (uye == null)
            {
                return RedirectToAction(nameof(Uyeler));
            }
            return View(uye);
        }
        [HttpPost]
        public async Task<IActionResult> EditUyeler(int id, Uye uye)
        {
            if (uye.UyeAd.Contains("^") == true) uye.UyeAd = "-";
            if (uye.UyeSoyad.Contains("^") == true) uye.UyeSoyad = "-";
            if (uye.UyeEposta.Contains("^") == true) uye.UyeEposta = "unknown@hotmail.com";
            if (uye.UyeTelefon.Contains("^") == true) uye.UyeTelefon = "000 000 00 00";
            if (uye.UyeAdres.Contains("^") == true) uye.UyeAdres = "Ankara";
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uye);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                { }
                return RedirectToAction("Uyeler");
            }
            return View(uye);
        }
    }
}