﻿//using Intranet.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class MenuPrincipalController : Controller
    {
        // GET: MenuPrincipal
        public ActionResult Index()
        {
            //using (ApplicationDbContext db = new ApplicationDbContext())
            //{
                return View("_MenuPrincipal");//, db.MenuPrincipal.OrderBy(a => a.IdSeccion).OrderBy(b=>b.Orden).ToList());
            //}
        }

        // GET: MenuPrincipal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuPrincipal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuPrincipal/Create
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

        // GET: MenuPrincipal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuPrincipal/Edit/5
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

        // GET: MenuPrincipal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuPrincipal/Delete/5
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
