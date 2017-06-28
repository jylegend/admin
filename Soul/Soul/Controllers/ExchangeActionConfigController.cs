using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soul.Models;

namespace Soul.Controllers
{
    public class ExchangeActionConfigController : Controller
    {
        private ExchangeActionConfigDbContext db = new ExchangeActionConfigDbContext();

        //
        // GET: /ExchangeActionConfig/

        public ActionResult Index()
        {
            return View(db.ExchangeActionConfig.ToList());
        }

        //
        // GET: /ExchangeActionConfig/Details/5

        public ActionResult Details(int id)
        {
            ExchangeActionConfig exchangeactionconfig = db.ExchangeActionConfig.Find(id);
            if (exchangeactionconfig == null)
            {
                return HttpNotFound();
            }
            return View(exchangeactionconfig);
        }

        //
        // GET: /ExchangeActionConfig/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ExchangeActionConfig/Create

        [HttpPost]
        public ActionResult Create(ExchangeActionConfig exchangeactionconfig)
        {
            if (ModelState.IsValid)
            {
                db.ExchangeActionConfig.Add(exchangeactionconfig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exchangeactionconfig);
        }

        //
        // GET: /ExchangeActionConfig/Edit/5

        public ActionResult Edit(int id)
        {
            ExchangeActionConfig exchangeactionconfig = db.ExchangeActionConfig.Find(id);
            if (exchangeactionconfig == null)
            {
                return HttpNotFound();
            }
            return View(exchangeactionconfig);
        }

        //
        // POST: /ExchangeActionConfig/Edit/5

        [HttpPost]
        public ActionResult Edit(ExchangeActionConfig exchangeactionconfig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exchangeactionconfig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exchangeactionconfig);
        }

        //
        // GET: /ExchangeActionConfig/Delete/5

        public ActionResult Delete(int id)
        {
            ExchangeActionConfig exchangeactionconfig = db.ExchangeActionConfig.Find(id);
            if (exchangeactionconfig == null)
            {
                return HttpNotFound();
            }
            return View(exchangeactionconfig);
        }

        //
        // POST: /ExchangeActionConfig/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ExchangeActionConfig exchangeactionconfig = db.ExchangeActionConfig.Find(id);
            db.ExchangeActionConfig.Remove(exchangeactionconfig);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}