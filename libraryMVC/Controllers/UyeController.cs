using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;

namespace libraryMVC.Controllers
{
    public class UyeController : Controller
    {
        private readonly AppDbContext _context;

        public UyeController(AppDbContext context)
        {
            _context = context;
        }
    }
}