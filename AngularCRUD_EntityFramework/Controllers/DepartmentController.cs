using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngularCRUD_EntityFramework.Models;

namespace AngularCRUD_EntityFramework.Controllers
{
    public class DepartmentController : Controller
    {
        private ProjectDB db = new ProjectDB();

        // GET: Department
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }
        public JsonResult GetAllDepartment()
        {
            var departments = db.Departments.ToList();
            return Json(departments, JsonRequestBehavior.AllowGet);
        }

        // GET: Department/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       // [HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create( Department department)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Departments.Add(department);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(department);
        //}

        [HttpPost]
        public JsonResult InsertDepartment(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            string message = "Successfully Saved.";
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public JsonResult GetSingleDepartment(int? id)
        {
            Department department = db.Departments.Find(id);
            return Json(department);
        }

        [HttpPost]
        public JsonResult UpdateDepartment(Department department)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                db.Entry(department).State = EntityState.Modified;
                db.SaveChanges();
                // return RedirectToAction("Index");
                 message = "Successfully Updated.";
            }
           // return View(department);
            
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        // GET: Department/Edit/5

        public ActionResult Edit()
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Department department = db.Departments.Find(id);
            //if (department == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

        public JsonResult DeleteDepartment(int id)
        {
            Department department = db.Departments.Find(id);
            db.Departments.Remove(department);
            db.SaveChanges();
            string message = "Deleted Successfully !";
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        // [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "DepartmentId,Name,Code")] Department department)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(department).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(department);
        //}

        // GET: Department/Delete/5
        public ActionResult Delete()
        {
            
            return View();
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Departments.Find(id);
            db.Departments.Remove(department);
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
