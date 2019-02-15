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
    public class CUPOM_PROMOCIONALController : Controller
    {
        private PROJETO_SAD_ESIIEntities db = new PROJETO_SAD_ESIIEntities();

        // GET: CUPOM_PROMOCIONAL
        public ActionResult Index()
        {
            return View(db.TB_CUPOM_PROMOCIONAL.ToList());
        }

        // GET: CUPOM_PROMOCIONAL/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL = db.TB_CUPOM_PROMOCIONAL.Find(id);
            if (cUPOM_PROMOCIONAL == null)
            {
                return HttpNotFound();
            }
            return View(cUPOM_PROMOCIONAL);
        }

        // GET: CUPOM_PROMOCIONAL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CUPOM_PROMOCIONAL/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CUPOM,NOME_PRODUTO,VALOR,DATA_INICIO,DATA_FIM,ESTADO,CIDADE,BAIRRO,RUA,NUMERO")] CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL)
        {
            if (ModelState.IsValid)
            {
                db.TB_CUPOM_PROMOCIONAL.Add(cUPOM_PROMOCIONAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cUPOM_PROMOCIONAL);
        }

        // GET: CUPOM_PROMOCIONAL/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL = db.TB_CUPOM_PROMOCIONAL.Find(id);
            if (cUPOM_PROMOCIONAL == null)
            {
                return HttpNotFound();
            }
            return View(cUPOM_PROMOCIONAL);
        }

        // POST: CUPOM_PROMOCIONAL/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CUPOM,NOME_PRODUTO,VALOR,DATA_INICIO,DATA_FIM,ESTADO,CIDADE,BAIRRO,RUA,NUMERO")] CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cUPOM_PROMOCIONAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cUPOM_PROMOCIONAL);
        }

        // GET: CUPOM_PROMOCIONAL/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL = db.TB_CUPOM_PROMOCIONAL.Find(id);
            if (cUPOM_PROMOCIONAL == null)
            {
                return HttpNotFound();
            }
            return View(cUPOM_PROMOCIONAL);
        }

        // POST: CUPOM_PROMOCIONAL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CUPOM_PROMOCIONAL cUPOM_PROMOCIONAL = db.TB_CUPOM_PROMOCIONAL.Find(id);
            db.TB_CUPOM_PROMOCIONAL.Remove(cUPOM_PROMOCIONAL);
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
