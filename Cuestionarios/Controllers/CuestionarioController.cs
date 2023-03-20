using Cuestionarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Cuestionarios.Controllers
{
    public class CuestionarioController : Controller
    {
        CUEST_ACCESS.Class1 a = new CUEST_ACCESS.Class1();
        // GET: Cuestionario
        public ActionResult Index()
        {
            var cuestionarios = a.Listar().Select(c => new {c.id , c.nombreCuestionario}).ToList();

            ViewBag.cuestionarios = cuestionarios;

            // Obtener todas las preguntas al cargar la página
            ViewBag.Error = "Seleccione un cuestionario para administrar";
            var preguntas = new List<CUEST_ACCESS.preguntas>();
            return View(preguntas);
        }

        [HttpPost]
        public ActionResult Index(int? cuest)
        {
            if (cuest.HasValue)
            {
                var cuestionarios = a.Listar().Select(c => new { c.id, c.nombreCuestionario }).ToList();
                ViewBag.cuestionarios = cuestionarios;
                var preguntas = a.ListarPreguntasWhere(cuest.Value);
                if (!preguntas.Any())
                {
                    ViewBag.Error = "Este cuestionario no tiene preguntas para mostrar";
                }

                return View(preguntas);
            }
            else
            {
                // Filtrar las preguntas según el examen seleccionado
                var cuestionarios = a.Listar().Select(c => new { c.id, c.nombreCuestionario }).ToList();
                ViewBag.cuestionarios = cuestionarios;
                ViewBag.Error = "Seleccione un cuestionario para administrar";
                var preguntas = new List<CUEST_ACCESS.preguntas>();
                return View(preguntas);
               
            }
        }
        public ActionResult _CuestionarioDetalles()
        {
            var cuestionarios = a.Listar();
            return View(cuestionarios);
        }

        public ActionResult Create()
        {
            return View(new CUEST_ACCESS.cuestionarios());
        }
        
        [HttpPost]
        public ActionResult Create(CUEST_ACCESS.cuestionarios item)
        {
            var cuestionarios = a.Listar().Select(c => new { c.id, c.nombreCuestionario }).ToList();
            ViewBag.cuestionarios = cuestionarios;
            ViewBag.Error = "Seleccione un cuestionario para administrar";
            a.Agregar(item);
            return View("Index", new List<CUEST_ACCESS.preguntas>()) ;
        }
    }
}