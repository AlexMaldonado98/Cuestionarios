using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cuestionarios.Controllers
{
    public class CuestionarioController : Controller
    {
        CUEST_ACCESS.Class1 a = new CUEST_ACCESS.Class1();

        // GET: Cuestionario
        public ActionResult Index()
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
            a.Agregar(item);
            return View("index", a.Listar());
        }


    }
}