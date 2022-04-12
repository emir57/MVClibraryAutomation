using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Admin : Controller
    {
        public async Task<IActionResult> Kitaplar()
        {
            return Ok();
        }
    }
}