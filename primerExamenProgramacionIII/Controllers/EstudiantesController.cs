using Microsoft.AspNetCore.Http;
using primerExamenProgramacionIII.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace primerExamenProgramacionIII.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: EstudiantesController
        public ActionResult Index()
        {
            // Se le envia al Index la informacion de las lista para mostrar a los Estudiantes
            ListaEstudiantes le = ListaEstudiantes.Lalista;
            return View(le.Estudiante);
        }

        [RequireHttps]
        public IActionResult buscarEstudiantes(string texto)
        {
            // Se crea una funcionalidad para buscar a los estudiantes y se compara con el nombre

            ListaEstudiantes lp = ListaEstudiantes.Lalista;
            var estudiante = lp.Estudiante.Where(x => x.Nombre.Contains(texto));

            if (estudiante == null)
            {
                return NotFound();
            }
            else
            {
                return View(estudiante);
            }

        }

        // GET: EstudiantesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudiantesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesController/Create
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

        // GET: EstudiantesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Edit/5
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

        // GET: EstudiantesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Delete/5
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
