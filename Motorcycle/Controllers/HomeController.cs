using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Motorcycle.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Motorcycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private UserModel _User { get { return _context.Users.FirstOrDefault(u => u.Login == User.Identity.Name); } }

        private ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
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


        public IActionResult About_Motorcycle()
        {
            return View();
        }

        public IActionResult About_Tour()
        {
            return View();
        }

        public IActionResult My_Experience()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Forum()
        {
            return View(_context.Messages.ToArray());
        }


        [HttpPost]
        public IActionResult Forum(string InputedMsg)
        {
            _context.Messages.Add(new Message { messageText = InputedMsg, Departure = DateTime.Now, Sender = _User });
            _context.SaveChanges();
            return View(_context.Messages.ToArray());
        }



    }
}
