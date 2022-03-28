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
        [HttpPost]
        public IActionResult UyelerSearch(string searchString, int id)
        {
            if (searchString == null) searchString = "^";
            searchString = searchString.ToLower();
            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = _context.Uyeler.Where(x => x.UyeAd.ToLower().Contains(searchString) || x.UyeSoyad.ToLower().Contains(searchString) || x.UyeEposta.ToLower().Contains(searchString) || x.UyeTelefon.Contains(searchString) || x.UyeAdres.ToLower().Contains(searchString) || x.UyeNo == id).ToList();
            return View(arama);
        }
        public async Task<IActionResult> DeleteUyeler(int id)
        {
            var uye = _context.Uyeler.SingleOrDefault(x => x.UyeNo == id);
            _context.Uyeler.Remove(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction("Uyeler");
        }
        public IActionResult CreateUyeler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUyeler(Uye uye)
        {
            if (uye.UyeAd.Contains("^") == true) uye.UyeAd = "-";
            if (uye.UyeSoyad.Contains("^") == true) uye.UyeSoyad = "-";
            if (uye.UyeTelefon.Contains("^") == true) uye.UyeTelefon = "000 000 00 00";
            if (uye.UyeEposta.Contains("^") == true) uye.UyeEposta = "unknown@hotmail.com";
            if (uye.UyeAdres.Contains("^") == true) uye.UyeAdres = "Ankara";
            _context.Uyeler.Add(uye);
            _context.SaveChanges();
            return RedirectToAction("Uyeler");
        }
        public IActionResult EditUyeler(int? id)
        {

            var uye = _context.Uyeler.Where(x => x.UyeNo == id).SingleOrDefault();
            if (uye == null)
            {

            }
            return View(uye);
        }
        [HttpPost]
        public async Task<IActionResult> EditUyeler(int id,Uye uye)
        {
            if (id != uye.UyeNo)
            {

            }
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
                {

                }
                return RedirectToAction("Uyeler");
            }
            return View(uye);
        }
    }
}