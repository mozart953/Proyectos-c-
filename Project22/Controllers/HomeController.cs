using Project22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project22.Controllers
{
    public class HomeController : Controller
    {

        private Alumno alumno1 = new Alumno();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( String nombre, int idAlumno)
        {
            if (alumno1.ValidarUsuario(nombre, idAlumno)==true)
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Bienvenido";

            }
            else {

                ViewBag.alerta = "danger";
                ViewBag.res = "Nombre de usuario o contrasena incorrectos";
            
            }

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}