using Microsoft.AspNetCore.Http;
using primerExamenProgramacionIII.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace primerExamenProgramacionIII.Controllers
{
    public class ProfesoresController : Controller
    {
        // GET: ProfesoresController
        public ActionResult Index()
        {
            // Se le envia al Index la informacion de las lista para mostrar a los Profesores
            ListaProfesores lp = ListaProfesores.Lalista;
            return View(lp.Profesor);

        }

        [RequireHttps]
        public IActionResult buscarProfesores(string texto)
        {
            // Se crea una funcionalidad para buscar a los profesores y se compara con el nombre
            ListaProfesores lp = ListaProfesores.Lalista;
            var profesores = lp.Profesor.Where(x => x.Nombre.Contains(texto));

            if(profesores == null)
            {
                return NotFound();
            }
            else
            {
                return View(profesores);
            }
            
        }


        // GET: ProfesoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfesoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfesoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfesoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfesoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfesoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfesoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
