using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Dtos;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            return View(await _context.Emanetler.ToListAsync());
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
        public IActionResult AdminUyeEkle()
        {
            UyeViewModel model = new UyeViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AdminUyeEkle(UyeViewModel uyeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(uyeViewModel);
            }
            Uye uye = _mapper.Map<Uye>(uyeViewModel);
            uye.UserName = uyeViewModel.Email;
            uye.Id = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(uye);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(uyeViewModel);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminUyeler), new { @message = $"{uye.UyeAd} {uye.UyeSoyad} başarıyla eklendi" });
        }
    }
}