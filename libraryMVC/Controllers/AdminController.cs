using System.Threading.Tasks;
using AutoMapper;
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