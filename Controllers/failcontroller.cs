using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using practica04.Models;


namespace practica04.Controllers
{
    public class failcontroller : Controller
    {
        private readonly  vercontext _context;

        public failcontroller(vercontext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult registro()
        {
            return View();
        }


[HttpPost]
        public IActionResult registro(usuario u){
            if (ModelState.IsValid){
                _context.usuarios.Add(u);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(u);
            }
        }


       public IActionResult detalle()
        {
            return View();
        }



    }
}