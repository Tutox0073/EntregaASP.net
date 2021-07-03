using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeraWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace PrimeraWeb.Controllers
{    
    public class Authentication: Controller 
    {

        [Authorize]
        public IActionResult Inicio()
        {
            return RedirectToAction("Index", "Web");
        }


        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost ("Login")]
        public async Task<IActionResult> Validar(string Username, string Password, string returnUrl)
        {   
            var db = new tallerfinalContext();
            var Userlogin = db.Usuarios.FirstOrDefault(u => u.usuario == Username && u.contrasena == Password);

            if (Userlogin != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("Username", Userlogin.usuario));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, Username));
                claims.Add(new Claim(ClaimTypes.Name, Userlogin.nombre));
                claims.Add(new Claim(ClaimTypes.Role, Userlogin.perfil));
                var ClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var ClaimsPrincipal = new ClaimsPrincipal(ClaimsIdentity);
                await HttpContext.SignInAsync(ClaimsPrincipal);
                return Redirect(returnUrl);
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                TempData["Error"] = "los Datos se encuentran incorrectos";
                return View("Login");
            }
            
        }
        
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Web");
        }
        
    }
}
