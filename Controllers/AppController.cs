using System;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happens");

            return View();
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }

        [HttpGet("About")]
        public IActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }
    }
}