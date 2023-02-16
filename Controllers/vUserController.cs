using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp.Data;
using webapp.Models;

namespace webapp.Controllers
{
    public class vUserController : Controller
    {
        private readonly UserDbContext _context;

        public vUserController(UserDbContext context) { _context = context; }

        // GET: UserController

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        // POST: UserController/Create
        [HttpPost]

        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {



                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(user);

        }


            // GET: UserController/Delete/5
        }
}
