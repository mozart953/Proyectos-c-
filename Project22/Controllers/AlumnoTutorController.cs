using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Project22.Models;

namespace Project22.Controllers
{
    public class AlumnoTutorController : Controller
    {
        // GET: AlumnoTutor
        public ActionResult Index()
        {
            using (var conexion = new Models.Modelo1()) {

                List<Models.Alumno> alumnos = conexion.Alumno.ToList();
                List<Models.grupo> grupos = conexion.grupo.ToList();
                List<Models.grado> grado = conexion.grado.ToList();

                var consulta = from al in alumnos
                               join grp in grupos on al.Grupo_idGrupo equals grp.idGrupo
                               join grd in grado on grp.Grado_idGrado equals grd.id_Grado
                               select new ViewModel
                               {
                                  alumno= al,
                                  grupo1= grp,
                                  grado1=grd

                               };

                return View(consulta);
                
                
            }

            
        }
    }
}