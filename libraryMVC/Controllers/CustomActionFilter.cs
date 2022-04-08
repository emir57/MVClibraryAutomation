using System;
using System.Linq;
using libraryMVC.Models;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using site.Controllers;

namespace libraryMVC.Controllers
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        private readonly AppDbContext _context;

        public CustomActionFilter(AppDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var model = new MainViewModel();
            model.Uyeler = _context.Users.ToList();
            var controller = (context.Controller as Controller).ViewBag.MainViewModel = model;
            base.OnActionExecuted(context);
        }
    }
}