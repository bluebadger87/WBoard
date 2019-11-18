using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBoard.DataContext;
using WBoard.Models;

namespace WBoard.Controllers
{
    public class UserController : Controller
    {
        private readonly MainContext _context;
        public UserController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User model)
        {

            return View();
        }


     


    }
}
