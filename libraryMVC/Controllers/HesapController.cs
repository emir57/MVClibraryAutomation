using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC.Controllers
{
    public class HesapController : Controller
    {
        private readonly SignInManager<Uye> _signInManager;
        private readonly UserManager<Uye> _userManager;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public HesapController(UserManager<Uye> userManager, SignInManager<Uye> signInManager, AppDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GirisYap(string message = null, string @class = null)
        {
            if (message != null && @class != null)
            {
                ViewBag.Message = message;
                ViewBag.Class = @class;
            }
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Uye uye = await _context.Users.FirstOrDefaultAsync(x => x.Email == model.EPosta);
            if (uye == null)
            {
                ModelState.AddModelError("", "Eposta veya şifre hatalı");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(uye, model.Sifre, model.RememberMe, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Eposta veya şifre hatalı");
                return View(model);
            }
            return RedirectToAction("Kitaplar", "Kitap", new { @message = "Başarıyla Giriş Yapıldı" });
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> KayitOl(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Uye uye = _mapper.Map<Uye>(model);
            var result = await _userManager.CreateAsync(uye, model.Sifre);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    if (error.Code == "PasswordTooShort")
                    {
                        ModelState.AddModelError("", "Şifre minimum 6 karakter olabilir");
                    }
                    if (error.Code == "PasswordRequiresNonAlphanumeric")
                    {
                        ModelState.AddModelError("", "Şifre özel karakter içermelidir");
                    }
                    if (error.Code == "PasswordRequiresLower")
                    {
                        ModelState.AddModelError("", "Şifre küçük harf içermelidir");
                    }
                    if (error.Code == "PasswordRequiresUpper")
                    {
                        ModelState.AddModelError("", "Şifre büyük harf içermelidir");
                    }

                }
                return View(model);
            }
            return RedirectToAction(nameof(GirisYap), new { @message = "Başarıyla Kayıt Olundu", @class = "alert alert-success" });
        }

        public async Task<IActionResult> Cikis()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(GirisYap), new { @message = "Çıkış işlemi başarılı", @class = "alert alert-success" });
        }
    }
}