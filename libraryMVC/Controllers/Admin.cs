using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    public class Admin : Controller
    {
        public async Task<IActionResult> Kitaplar()
        {
            return Ok();
        }
    }
}