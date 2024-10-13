using Algo22.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Algo22.Data;
using System.Security.Cryptography;
using System.Text;

namespace Algo22.Controllers
{
    public class AccountController : Controller
    {
        private readonly AlgoContext _context;

        public AccountController(AlgoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == model.Username);
            if (user != null && VerifyPassword(model.Password, user.Password))
            {

                return RedirectToAction("Home", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private static bool VerifyPassword(string password, string storedHash)
        {
            var hash = HashPassword(password);
            return hash == storedHash;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await _context.Users.AnyAsync(u => u.Username == model.Username))
            {
                ModelState.AddModelError(string.Empty, "Username already exists.");
                return View(model);
            }

            var user = new User
            {
                Username = model.Username,
                Password = HashPassword(model.Password)
            };

            _context.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }
    }
}