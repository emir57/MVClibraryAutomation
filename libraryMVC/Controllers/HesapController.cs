using System.Threading.Tasks;
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

        public HesapController(UserManager<Uye> userManager, SignInManager<Uye> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
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
            var result = _signInManager.PasswordSignInAsync(uye, model.Sifre, model.RememberMe, false);
            return RedirectToAction("Kitaplar", "Kitap", new { @message = "Başarıyla Giriş Yapıldı" });
        }
    }
}