using System;
using libraryMVC_.Data;
using Microsoft.AspNetCore.Mvc.Filters;
using site.Controllers;

namespace libraryMVC.Controllers
{
    public class ActionFilter : Attribute, IActionFilter
    {
        private readonly AppDbContext _context;

        public ActionFilter(AppDbContext context)
        {
            _context = context;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var homeController = context.Controller as HomeController;
            if (homeController != null)
            {
                homeController.ViewBag.Users = _context.Users;
            }
        }
    }
}