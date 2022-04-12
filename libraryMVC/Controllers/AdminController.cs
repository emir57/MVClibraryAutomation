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