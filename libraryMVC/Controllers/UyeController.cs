using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using libraryMVC.Entities;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC.Controllers
{
    
    public class UyeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<Uye> _userManager;
        public UyeController(AppDbContext context, IMapper mapper, UserManager<Uye> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Uyeler(string message = null)
        {
            if (message != null)
            {
                ViewBag.Message = message;
            }
            return View(_userManager.Users.ToList());
        }
        [HttpGet]
        public async Task<IActionResult> UyelerSearchBySearchString(string searchString = null)
        {
            List<Uye> uyeler;
            if (searchString == null)
            {
                uyeler = await _userManager.Users.ToListAsync();
                return Ok(uyeler);
            }
            searchString = searchString.ToLower();
            uyeler = await _userManager.Users.Where(x => x.UyeAd.ToLower().Contains(searchString) ||
                    x.UyeSoyad.ToLower().Contains(searchString) ||
                    x.Email.ToLower().Contains(searchString) ||
                    x.UyeTelefon.Contains(searchString) ||
                    x.UyeAdres.ToLower().Contains(searchString)).ToListAsync();
            return Ok(uyeler);
        }
        [HttpGet]
        public async Task<IActionResult> UyelerSearchById(string id = null)
        {
            Uye uye;
            if (id == null)
            { }
            uye = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (uye == null)
            {
                return BadRequest("??ye bulunamad??");
            }
            return Ok(uye);
        }
        public async Task<IActionResult> DeleteUyeler(string id)
        {
            var uye = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == id);
            await _userManager.DeleteAsync(uye);
            await _context.SaveChangesAsync();
            return RedirectToAction("Uyeler");
        }
        public IActionResult CreateUyeler()
        {
            UyeViewModel model = new UyeViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUyeler(UyeViewModel uyeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(uyeViewModel);
            }
            Uye uye = _mapper.Map<Uye>(uyeViewModel);
            uye.UserName = uyeViewModel.Email;
            uye.Id = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(uye);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(uyeViewModel);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Uyeler), new { @message = $"{uye.UyeAd} {uye.UyeSoyad} ba??ar??yla eklendi" });
        }
        
    }
}