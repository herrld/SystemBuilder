﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemBuildeDataAccess;
using SystemBuilderDataModels;

namespace SystemBuilderAPI.Controllers
{
    public class FieldsController : Controller
    {
        SystemBuilderContext db = new SystemBuilderContext();

        // GET: Fields
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fields/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fields/Create
        public ActionResult Create()
        {
            ViewBag.FieldTypeId = new SelectList(db.FieldTypes, "Id", "Name");
            return View();
        }

        // POST: Fields/Create
        [HttpPost]
        public ActionResult Create(Field field)
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

        // GET: Fields/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fields/Edit/5
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

        // GET: Fields/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fields/Delete/5
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
