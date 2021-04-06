using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularEarTraining.Controllers
{
    public class AngularDataController : Controller
    {
        // GET: AngularData
        public ActionResult Index()
        {
            return View();
        }

        // GET: AngularData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AngularData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AngularData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AngularData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AngularData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AngularData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AngularData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
