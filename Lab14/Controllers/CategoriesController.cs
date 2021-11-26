using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        #region Contexto

        private NORTHWNDEntities _contexto;

        public NORTHWNDEntities contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        #endregion

        public ActionResult Index()
        {
            return View(contexto.Categories.ToList());
        }

        public ActionResult Details(int id)
        {
            var productosPorCategoria = from p in contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorCategoria.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Categories.Add(nuevaCategoria);
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories categoriaEditar = contexto.Categories.Find(id);

            if (categoriaEditar == null)
                return HttpNotFound();

            return View(categoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(CategoriaEditar).State = EntityState.Modified;
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories categoriaEliminar = contexto.Categories.Find(id);

            if (categoriaEliminar == null)
                return HttpNotFound();

            return View(categoriaEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    CategoriaEliminar = contexto.Categories.Find(id);

                    if (CategoriaEliminar == null)
                        return HttpNotFound();

                    contexto.Categories.Remove(CategoriaEliminar);
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}