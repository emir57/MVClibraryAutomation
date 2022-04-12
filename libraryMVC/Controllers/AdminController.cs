using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public AdminController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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