using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeraWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;



namespace PrimeraWeb.Controllers
{
    public class Estudiantes : Controller
    {
        public IActionResult MostrarEstudiantes(int? page)
        {
            var db = new tallerfinalContext();
            var pageNumber = page ?? 1;
            int pageSize = 6;
            var clientes = db.Estudiantes.ToPagedList(pageNumber, pageSize);
            return View(clientes);
        }
        
        [Authorize]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var db = new tallerfinalContext();
            var estudiantes = db.Estudiantes.Find(id);
            return View(estudiantes);
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var db = new tallerfinalContext();
            var myEstudiante = db.Estudiantes.Find(id);
            return View(myEstudiante);

        }
        [HttpGet]
        public IActionResult Borrar(int id)
        {
            var db = new tallerfinalContext();
            var myEstudiante = db.Estudiantes.Find(id);
            return View(myEstudiante);

        }

        [HttpPost]

        public IActionResult Agregar(Models.Estudiantes myEstudiante)
        {
            var db = new tallerfinalContext();
            var Existe = db.Estudiantes.Find(myEstudiante.Codigo);

            if (Existe == null)
            {                
                db.Estudiantes.Add(myEstudiante);
                db.SaveChanges();
                return RedirectToAction("MostrarEstudiantes");
            }
            else
            {
                ViewData["mensaje"] = $"El codigo {myEstudiante.Codigo} ya existe";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Editar(Models.Estudiantes myEstudiante)
        {
            var db = new tallerfinalContext();
            var Existe = db.Estudiantes.Find(myEstudiante.Codigo);  

            Existe.Nombre = myEstudiante.Nombre;
            Existe.Correo = myEstudiante.Correo;
            Existe.Nota1 = myEstudiante.Nota1;
            Existe.Nota2 = myEstudiante.Nota2;
            Existe.Nota3 = myEstudiante.Nota3;
           
            db.SaveChanges();
            return RedirectToAction("MostrarEstudiantes");
            

        }
        [HttpPost, ActionName("Borrar")]
        public IActionResult ConfirmarBorrar(int id)
        {
            var db = new tallerfinalContext();
            var Existe = db.Estudiantes.Find(id);
            db.Remove(Existe);
            db.SaveChanges();
            return RedirectToAction("MostrarEstudiantes");

        }
    }
}