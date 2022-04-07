using System.Threading.Tasks;
using libraryMVC.Entities;
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

        public async Task<IActionResult> GirisYap()
        {
            return View();
        }
    }
}