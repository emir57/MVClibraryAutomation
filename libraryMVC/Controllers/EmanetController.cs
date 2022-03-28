using System;
using System.Linq;
using System.Threading.Tasks;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC.Controllers
{
    public class EmanetController : Controller
    {
        private readonly AppDbContext _context;

        public EmanetController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Emanetler(string searchString, int id)
        {
            return View(_context.Emanetler);
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
        public IActionResult CreateEmanetler()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmanetler(Emanet emanet)
        {
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
                {

                }
                return RedirectToAction("Emanetler");
            }
            return View(emanet);
        }
    }
}