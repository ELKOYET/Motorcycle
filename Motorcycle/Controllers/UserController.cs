using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    [Authorize(Roles = "user")]
    public class UserController : Controller
    {
        private async Task<UserModel> findUser()=> await _context.Users.FirstOrDefaultAsync( u => u.Login == User.Identity.Name);
        private UserModel _User => findUser().Result;

        public UserController(ApplicationContext context) => _context = context;
        private ApplicationContext _context;


        [HttpGet]
        public IActionResult UserPanel()
        {
            return View(_User);
        }
 //Settings
        #region Settings
        [HttpGet]
        public IActionResult Settings()
        {
            
            return View();
        }

       
      

        #endregion Settings
    }
}


