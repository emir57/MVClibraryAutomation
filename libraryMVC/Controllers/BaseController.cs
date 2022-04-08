using System;
using System.Linq;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using site.Controllers;

namespace libraryMVC.Controllers
{
    public class BaseController : Controller
    {
        private readonly AppDbContext _context;

        public BaseController(AppDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            var model = context.Controller.ViewBag.Model as MainViewModel;
            model
        }

        protected MainViewModel mainViewModel(){
            MainViewModel model = new MainViewModel();
            model.Uyeler = _context.Users.ToList();
            return model;
        }
    }
}