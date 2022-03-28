using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using libraryMVC_.Data;

namespace libraryMVC.Controllers
{
    public class KitapController : Controller
    {
        private readonly AppDbContext _context;

        public KitapController(AppDbContext context)
        {
            _context = context;
        }
        
    }
}