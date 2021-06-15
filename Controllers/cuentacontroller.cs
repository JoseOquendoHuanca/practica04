using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace practica04.Controllers
{
    public class cuentacontroller:Controller
    {private  readonly SignInManager<IdentityUser> _sim;
         private  readonly UserManager<IdentityUser> _um;


        public cuentacontroller(
        SignInManager<IdentityUser>sim,
        UserManager<IdentityUser>um) {
            _sim=sim;
            _um=um;
        }

         public IActionResult iniciarsesion(){

            return View();
        }
        
 [HttpPost]
         public IActionResult iniciarsesion(string usuario,string password){
 var result=_sim.PasswordSignInAsync(usuario,password,false,false).Result;
 if(result.Succeeded){

      return   RedirectToAction("Index","Home");

 }
 ModelState.AddModelError("","los datos son incorrectos ");
            return View();
        }
         public async Task<IActionResult> cerrarsesion(){

             await _sim.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

        public IActionResult crearcuenta(){

            return View();
        }

 [HttpPost]

        public IActionResult crearcuenta(string email, string password ){
           var  usuario= new IdentityUser(email);
           usuario.Email=email;
           usuario.PhoneNumber="";
           var  resultado = _um.CreateAsync(usuario,password).Result;

            if (resultado.Succeeded){
                return   RedirectToAction("Index","Home");

            }

          foreach(var error in resultado.Errors)
          {
   ModelState.AddModelError("",error.Description);
          }
          return View();
       

    }



        
    }
}