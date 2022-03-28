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
