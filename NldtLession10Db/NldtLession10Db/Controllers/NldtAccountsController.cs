using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NldtLession10Db.Models;

namespace NldtLession10Db.Controllers
{
    public class NldtAccountsController : Controller
    {
        private NldtK22cnt3lession10DbEntities db = new NldtK22cnt3lession10DbEntities();

        // GET: NldtAccounts
        public ActionResult Index()
        {
            return View(db.NldtAccount.ToList());
        }

        // GET: NldtAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtAccount nldtAccount = db.NldtAccount.Find(id);
            if (nldtAccount == null)
            {
                return HttpNotFound();
            }
            return View(nldtAccount);
        }

        // GET: NldtAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NldtAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NldtID,NldtName,NldtPassword,NldtFullName,NldtEmail,NldtPhone,NldtActive")] NldtAccount nldtAccount)
        {
            if (ModelState.IsValid)
            {
                db.NldtAccount.Add(nldtAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nldtAccount);
        }

        // GET: NldtAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtAccount nldtAccount = db.NldtAccount.Find(id);
            if (nldtAccount == null)
            {
                return HttpNotFound();
            }
            return View(nldtAccount);
        }

        // POST: NldtAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NldtID,NldtName,NldtPassword,NldtFullName,NldtEmail,NldtPhone,NldtActive")] NldtAccount nldtAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nldtAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nldtAccount);
        }

        // GET: NldtAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NldtAccount nldtAccount = db.NldtAccount.Find(id);
            if (nldtAccount == null)
            {
                return HttpNotFound();
            }
            return View(nldtAccount);
        }

        // POST: NldtAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NldtAccount nldtAccount = db.NldtAccount.Find(id);
            db.NldtAccount.Remove(nldtAccount);
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
        public ActionResult Nldtlogin()
        {
            var NldtModel = new NldtAccount();
            return View(NldtModel);
        }
        [HttpPost]
        public ActionResult Nldtlogin(NldtAccount nldtAccount)
        {
            var NldtCheck = db.NldtAccount.Where(x => x.NldtName.Equals(nldtAccount.NldtName) && x.NldtPassword.Equals(nldtAccount.NldtPassword)).FirstOrDefault();
            if (NldtCheck != null) 
            {
                // luu session
                Session["NldtAccount"] = NldtCheck;
                return Redirect("/");
            }
            return View(NldtCheck);
        }
    }
}
