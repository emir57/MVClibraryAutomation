using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public async Task<IActionResult> AdminKitaplar()
        {
            return View();
        }
        public async Task<IActionResult> AdminEmanetler()
        {
            return View();
        }
        public async Task<IActionResult> AdminUyeler()
        {
            return View();
        }
    }
}