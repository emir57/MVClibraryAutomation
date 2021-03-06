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
            return RedirectToAction(nameof(AdminKitaplar), new { @message = $"{kitapViewModel.KitapAd} ba??ar??yla eklendi" });
        }

        public async Task<IActionResult> EditAdminKitaplar(int? id)
        {
            var kitap = await _context.Kitaplar.Where(x => x.KitapNo == id).SingleOrDefaultAsync();
            if (kitap == null)
            {
                return RedirectToAction(nameof(AdminKitaplar));
            }
            KitapViewModel kitapViewModel = _mapper.Map<KitapViewModel>(kitap);
            return View(kitapViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditAdminKitaplar(KitapViewModel kitapViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(kitapViewModel);
            }
            Kitap kitap = _mapper.Map<Kitap>(kitapViewModel);
            _context.Kitaplar.Update(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminKitaplar), new { @message = $"{kitapViewModel.KitapAd} ba??ar??yla g??ncellendi" });
        }



        public async Task<IActionResult> AdminEmanetler(string message)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(await GetEmanetDtoAsync());
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
            return RedirectToAction(nameof(AdminEmanetler), new { @message = "Emanet ba??ar??yla eklendi" });
        }
        public async Task<IActionResult> EditAdminEmanetler(int? id)
        {
            var emanet = await _context.Emanetler.FindAsync(id);
            if (emanet == null)
            {
                return RedirectToAction(nameof(AdminEmanetler));
            }
            EmanetViewModel model = new EmanetViewModel();
            model = _mapper.Map<EmanetViewModel>(emanet);
            model.Kitaplar = await _context.Kitaplar.ToListAsync();
            model.Uyeler = await _userManager.Users.ToListAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditAdminEmanetler(EmanetViewModel emanetViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(emanetViewModel);
            }
            Emanet emanet = _mapper.Map<Emanet>(emanetViewModel);
            _context.Update(emanet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminEmanetler), new { @message = "Emanet ba??ar??yla g??ncellendi" });
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
            return RedirectToAction(nameof(AdminUyeler), new { @message = $"{uye.UyeAd} {uye.UyeSoyad} ba??ar??yla eklendi" });
        }
        public async Task<IActionResult> EditAdminUyeler(string id)
        {
            Uye uye = await _userManager.Users.Where(x => x.Id == id).SingleOrDefaultAsync();
            if (uye == null)
            {
                return RedirectToAction(nameof(AdminUyeler));
            }
            UyeViewModel uyeViewModel = _mapper.Map<UyeViewModel>(uye);
            return View(uyeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditAdminUyeler(UyeViewModel uyeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(uyeViewModel);
            }
            Uye uye = _mapper.Map<Uye>(uyeViewModel);
            _context.Update(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminUyeler), new { @message = $"{uye.UyeAd} {uye.UyeSoyad} ba??ar??yla g??ncellendi" });
        }
    }
}