using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica04.Models;

namespace practica04.Controllers
{
    public class HomeController : Controller
    {
        private readonly vercontext _context;
       
        public HomeController(vercontext context )
        {
             _context= context;
        }

        public IActionResult Index(int id)
        {
            // var usuario =_context.usuarios.Where(x =>x.fecharegistr < DateTime.Now) .ToList();
            var usuario =_context.usuarios.OrderByDescending(x =>x.id).ToList();
            return View(usuario);
        }

        public IActionResult Privacy()
        {
               var usuario =_context.usuarios.OrderByDescending(x =>x.id).ToList();
            return View(usuario);
        }

          public IActionResult detalle(){
      
            return View();
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
