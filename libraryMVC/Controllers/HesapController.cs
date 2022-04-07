using System.Threading.Tasks;
using libraryMVC.Entities;
using libraryMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    public class HesapController : Controller
    {
        private readonly SignInManager<Uye> _signInManager;
        private readonly UserManager<Uye> _userManager;

        public HesapController(UserManager<Uye> userManager, SignInManager<Uye> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult GirisYap(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Kitaplar", "Kitap", new { @message = "Başarıyla Giriş Yapıldı" });
        }
    }
}