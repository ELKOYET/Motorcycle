using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Motorcycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Motorcycle.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private UserModel _User { get { return _context.Users.FirstOrDefault(u => u.Login == User.Identity.Name); } }

        private ApplicationContext _context;

        public AdminController(ApplicationContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult AdminPanel()
        {
            return View(_User);
        }

    }
}
