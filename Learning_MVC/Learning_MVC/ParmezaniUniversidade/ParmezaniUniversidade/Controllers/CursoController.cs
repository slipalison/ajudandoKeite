using ParmezaniUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParmezaniUniversidade.Controllers
{
    public class CursoController : Controller
    {
        private static readonly ICurso cursoRepositorio = new CursoRepositorio();

        // GET: Curso
        public ActionResult Curso()
        {
            return View();
        }

        [HttpGet]
        public JsonResult RetornaTodosCursos()
        {
            return Json(cursoRepositorio.RetornaTodos(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddCurso(Curso curso)
        {
            curso = cursoRepositorio.Incluir(curso);
            return Json(curso, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public JsonResult Editar(int cursoID, Curso curso)
        {
            curso.CursoID = cursoID;
            if (cursoRepositorio.Atualizar(curso))
                return Json(curso, JsonRequestBehavior.AllowGet);

            return Json(null, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Excluir(int cursoID)
        {
            if (cursoRepositorio.Excluir(cursoID))
                return Json(new { Status = true }, JsonRequestBehavior.AllowGet);

            return Json(new { Status = true }, JsonRequestBehavior.AllowGet);
        }
    }
}