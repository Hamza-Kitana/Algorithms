using Algo22.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Algo22.Controllers
{
    public class LoginController : Controller
    { 
        static List<Login> Log = new (); 
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Ch()
        {
            return RedirectToAction ("Home" , "Home");
        }
    }
}
