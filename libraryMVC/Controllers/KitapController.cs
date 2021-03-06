using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using libraryMVC_.Data;
using Microsoft.EntityFrameworkCore;
using libraryMVC.Models;
using System.Collections.Generic;
using libraryMVC.Entities;
using AutoMapper;

namespace libraryMVC.Controllers
{
    public class KitapController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public KitapController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Kitaplar(string message = null)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(_context.Kitaplar);
        }
        [HttpGet]
        public async Task<IActionResult> KitaplarSearchBySearchString(string searchString = null)
        {
            if (searchString == null)
            {
                var kitaplar = await _context.Kitaplar.ToListAsync();
                return Ok(kitaplar);
            }
            searchString = searchString.ToLower();
            //searchString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString);
            var arama = await _context.Kitaplar.Where(x => x.KitapAd.ToLower().Contains(searchString) ||
                    x.KitapYazari.ToLower().Contains(searchString) ||
                    x.KitapYayinEvi.ToLower().Contains(searchString))
            .ToListAsync();
            return Ok(arama);
        }
        [HttpGet]
        public async Task<IActionResult> KitaplarSearchById(int id = 0)
        {
            Kitap kitap;
            if (id == 0)
            {
                List<Kitap> kitaplar = await _context.Kitaplar.ToListAsync();
                return Ok(kitaplar);
            }
            kitap = await _context.Kitaplar.SingleOrDefaultAsync(x => x.KitapNo == id);
            if (kitap == null)
            {
                return BadRequest("Kitap Bulunamad??");
            }
            return Ok(kitap);
        }
        public async Task<IActionResult> DeleteKitaplar(int id)
        {
            var kitap = await _context.Kitaplar.SingleOrDefaultAsync(x => x.KitapNo == id);
            _context.Kitaplar.Remove(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction("Kitaplar");
        }

        // public async Task<IActionResult> EmanetAl()
        // {

        // }
    }
}