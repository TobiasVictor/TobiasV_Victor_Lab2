using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TobiasV_Victor_Lab2.Models;
using Microsoft.EntityFrameworkCore;
using TobiasV_Victor_Lab2.Data;
using TobiasV_Victor_Lab2.LibraryViewModels;

namespace TobiasV_Victor_Lab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext context;
        public HomeController (LibraryContext context)
        {
            _context = context;
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
