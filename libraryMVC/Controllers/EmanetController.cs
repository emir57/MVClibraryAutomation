using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Dtos;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using site.Models;

namespace libraryMVC.Controllers
{
    public class EmanetController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<Uye> _userManager;
        public EmanetController(AppDbContext context, IMapper mapper, UserManager<Uye> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        private async Task<List<EmanetDto>> GetEmanetDtoAsync()
        {
            List<EmanetDto> emanetler = await (from e in _context.Emanetler
                                               select new EmanetDto
                                               {
                                                   Emanet = _mapper.Map<EmanetViewModel>(e),
                                                   Uye = _userManager.Users.FirstOrDefault(uye => uye.Id == e.UyeId),
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
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetIslem(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.Emanet.EmanetIslemTarih) >= startDate && Convert.ToDateTime(e.Emanet.EmanetIslemTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aral??????nda kay??t bulunamad??");
            }
            return Ok(emanetler);
        }
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetGeriAlma(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.Emanet.EmanetGeriAlmaTarih) >= startDate && Convert.ToDateTime(e.Emanet.EmanetGeriAlmaTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aral??????nda kay??t bulunamad??");
            }
            return Ok(emanetler);
        }
        [HttpPost]
        public async Task<IActionResult> EmanetSearchByEmanetVerme(DateTime startDate, DateTime finishDate)
        {
            List<EmanetDto> emanetler = await GetEmanetDtoAsync();
            emanetler = emanetler.Where(e => Convert.ToDateTime(e.Emanet.EmanetVermeTarih) >= startDate && Convert.ToDateTime(e.Emanet.EmanetVermeTarih) <= finishDate).ToList();
            if (emanetler.Count == 0)
            {
                return BadRequest("Bu tarih aral??????nda kay??t bulunamad??");
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
                                x.Emanet.EmanetNot.ToLower().Contains(searchString) ||
                                x.Emanet.EmanetTeslimEdildi.ToLower().Contains(searchString)).ToList();
            }
            return Ok(emanetler);
        }
        [HttpGet]
        public async Task<IActionResult> EmanetlerSearchById(int id)
        {
            EmanetDto emanet = (await GetEmanetDtoAsync()).FirstOrDefault(e => e.Emanet.EmanetNo == id);
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
        
        
    }
}