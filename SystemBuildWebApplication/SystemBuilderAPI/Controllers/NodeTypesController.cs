using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SystemBuildeDataAccess;
using SystemBuilderDataModels;

namespace SystemBuilderAPI.Controllers
{
    public class NodeTypesController : Controller
    {
        private SystemBuilderContext db = new SystemBuilderContext();

        // GET: NodeTypes
        public ActionResult Index()
        {
            return View(db.NodeTypes.ToList());
        }

        // GET: NodeTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NodeType nodeType = db.NodeTypes.Find(id);
            if (nodeType == null)
            {
                return HttpNotFound();
            }
            return View(nodeType);
        }

        // GET: NodeTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NodeTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] NodeType nodeType)
        {
            if (ModelState.IsValid)
            {
                db.NodeTypes.Add(nodeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nodeType);
        }

        // GET: NodeTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NodeType nodeType = db.NodeTypes.Find(id);
            if (nodeType == null)
            {
                return HttpNotFound();
            }
            return View(nodeType);
        }

        // POST: NodeTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] NodeType nodeType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nodeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nodeType);
        }

        // GET: NodeTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NodeType nodeType = db.NodeTypes.Find(id);
            if (nodeType == null)
            {
                return HttpNotFound();
            }
            return View(nodeType);
        }

        // POST: NodeTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NodeType nodeType = db.NodeTypes.Find(id);
            db.NodeTypes.Remove(nodeType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
