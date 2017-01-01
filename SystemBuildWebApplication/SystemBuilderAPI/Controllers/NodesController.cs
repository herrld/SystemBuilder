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
    public class NodesController : Controller
    {
        private SystemBuilderContext db = new SystemBuilderContext();

        // GET: Nodes
        public ActionResult Index()
        {
            var nodes = db.Nodes.Include(n => n.NodeType).Include(n => n.UI);
            return View(nodes.ToList());
        }

        // GET: Nodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Node node = db.Nodes.Find(id);
            if (node == null)
            {
                return HttpNotFound();
            }
            return View(node);
        }

        // GET: Nodes/Create
        public ActionResult Create()
        {
            ViewBag.NodeTypeId = new SelectList(db.NodeTypes, "Id", "Name");
            ViewBag.Id = new SelectList(db.UserInterfaces, "Id", "Id");
            return View();
        }

        // POST: Nodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NodeTypeId")] Node node)
        {
            if (ModelState.IsValid)
            {
                db.Nodes.Add(node);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NodeTypeId = new SelectList(db.NodeTypes, "Id", "Name", node.NodeTypeId);
            ViewBag.Id = new SelectList(db.UserInterfaces, "Id", "Id", node.Id);
            return View(node);
        }

        // GET: Nodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Node node = db.Nodes.Find(id);
            if (node == null)
            {
                return HttpNotFound();
            }
            ViewBag.NodeTypeId = new SelectList(db.NodeTypes, "Id", "Name", node.NodeTypeId);
            ViewBag.Id = new SelectList(db.UserInterfaces, "Id", "Id", node.Id);
            return View(node);
        }

        // POST: Nodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NodeTypeId")] Node node)
        {
            if (ModelState.IsValid)
            {
                db.Entry(node).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NodeTypeId = new SelectList(db.NodeTypes, "Id", "Name", node.NodeTypeId);
            ViewBag.Id = new SelectList(db.UserInterfaces, "Id", "Id", node.Id);
            return View(node);
        }

        // GET: Nodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Node node = db.Nodes.Find(id);
            if (node == null)
            {
                return HttpNotFound();
            }
            return View(node);
        }

        // POST: Nodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Node node = db.Nodes.Find(id);
            db.Nodes.Remove(node);
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
