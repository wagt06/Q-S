using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FDS_SITE.Controllers
{
    public class CuestionarioController : Controller
    {
        // GET: Cuestionario
        public ActionResult Index()
        {
            List<Models.Quejas> Sugerencias = new List<Models.Quejas>();
            using (var db = new Models.FDSContext()) {
                Sugerencias = db.Quejas.ToList();
            }

                return View("lista", Sugerencias);
        }

        // GET: Cuestionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cuestionario/Create
        public ActionResult Create()
        {
            return View(new Models.Quejas());
        }

        // POST: Cuestionario/Create
        [HttpPost]
        public ActionResult Create(Models.Quejas Cuestionario)
        {
            try
            {
                // TODO: Add insert logic here
                using (var db = new Models.FDSContext())
                {
                    db.Quejas.Add(Cuestionario);
                    db.SaveChanges();

                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                //return RedirectToRoute("Index", new Models.Quejas());
                return View();
            }
        }

        // GET: Cuestionario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuestionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuestionario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuestionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}