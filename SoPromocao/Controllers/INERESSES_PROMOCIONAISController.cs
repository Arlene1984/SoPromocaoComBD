using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoPromocao.Models;

namespace SoPromocao.Controllers
{
    public class INERESSES_PROMOCIONAISController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: INERESSES_PROMOCIONAIS
        public ActionResult Index()
        {
            return View(db.TB_INERESSES_PROMOCIONAIS.ToList());
        }

        // GET: INERESSES_PROMOCIONAIS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS = db.TB_INERESSES_PROMOCIONAIS.Find(id);
            if (iNERESSES_PROMOCIONAIS == null)
            {
                return HttpNotFound();
            }
            return View(iNERESSES_PROMOCIONAIS);
        }

        // GET: INERESSES_PROMOCIONAIS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: INERESSES_PROMOCIONAIS/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_INTERESSES_PROMOCIONAIS,ID_CONSUMIDOR,ID_PROMOCAO")] INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS)
        {
            if (ModelState.IsValid)
            {
                db.TB_INERESSES_PROMOCIONAIS.Add(iNERESSES_PROMOCIONAIS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iNERESSES_PROMOCIONAIS);
        }

        // GET: INERESSES_PROMOCIONAIS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS = db.TB_INERESSES_PROMOCIONAIS.Find(id);
            if (iNERESSES_PROMOCIONAIS == null)
            {
                return HttpNotFound();
            }
            return View(iNERESSES_PROMOCIONAIS);
        }

        // POST: INERESSES_PROMOCIONAIS/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_INTERESSES_PROMOCIONAIS,ID_CONSUMIDOR,ID_PROMOCAO")] INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNERESSES_PROMOCIONAIS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNERESSES_PROMOCIONAIS);
        }

        // GET: INERESSES_PROMOCIONAIS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS = db.TB_INERESSES_PROMOCIONAIS.Find(id);
            if (iNERESSES_PROMOCIONAIS == null)
            {
                return HttpNotFound();
            }
            return View(iNERESSES_PROMOCIONAIS);
        }

        // POST: INERESSES_PROMOCIONAIS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            INERESSES_PROMOCIONAIS iNERESSES_PROMOCIONAIS = db.TB_INERESSES_PROMOCIONAIS.Find(id);
            db.TB_INERESSES_PROMOCIONAIS.Remove(iNERESSES_PROMOCIONAIS);
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
