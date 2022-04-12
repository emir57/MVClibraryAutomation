using System;
using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<Uye> _userManager;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public AdminController(AppDbContext context, IMapper mapper, UserManager<Uye> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IActionResult> AdminKitaplar(string message)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(_context.Kitaplar);
        }
        public IActionResult AdminKitapEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminKitapEkle(KitapViewModel kitapViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(kitapViewModel);
            }
            Kitap kitap = _mapper.Map<Kitap>(kitapViewModel);
            kitap.IsActive = false;
            await _context.Kitaplar.AddAsync(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminKitaplar), new { @message = $"{kitapViewModel.KitapAd} başarıyla eklendi" });
        }



        public async Task<IActionResult> AdminEmanetler(string message)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(_context.Emanetler);
        }

        public async Task<IActionResult> AdminEmanetEkle()
        {
            EmanetViewModel model = new EmanetViewModel
            {
                Uyeler = await _userManager.Users.ToListAsync(),
                Kitaplar = await _context.Kitaplar.ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AdminEmanetEkle(EmanetViewModel emanetViewModel)
        {
            if (!ModelState.IsValid)
            {
                emanetViewModel.Uyeler = await _userManager.Users.ToListAsync();
                emanetViewModel.Kitaplar = await _context.Kitaplar.ToListAsync();
                return View(emanetViewModel);
            }
            emanetViewModel.EmanetIslemTarih = DateTime.Now.ToString("yyyy/MM/dd");
            emanetViewModel.EmanetIslemTarih = emanetViewModel.EmanetIslemTarih.Replace(".", "-");
            Emanet emanet = _mapper.Map<Emanet>(emanetViewModel);
            await _context.Emanetler.AddAsync(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminEmanetler), new { @message = "Emanet başarıyla eklendi" });
        }


        public async Task<IActionResult> AdminUyeler(string message)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(_context.Users);
        }
    }
}