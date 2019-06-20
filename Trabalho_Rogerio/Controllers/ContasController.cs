using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trabalho_Rogerio.Models;

namespace Trabalho_Rogerio.Controllers
{
    public class ContasController : Controller
    {
        private ContasContext db = new ContasContext();

        // GET: Contas
        public ActionResult Index()
        {
            return View(db.Contas.ToList());
        }

        // GET: Contas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contas contas = db.Contas.Find(id);
            if (contas == null)
            {
                return HttpNotFound();
            }
            return View(contas);
        }

        // GET: Contas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContasId,Fornecedor,Dtvencimento,Dtpagamento,Pago,Descricao,Valor")] Contas contas)
        {
            if (ModelState.IsValid)
            {
                db.Contas.Add(contas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contas);
        }

        // GET: Contas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contas contas = db.Contas.Find(id);
            if (contas == null)
            {
                return HttpNotFound();
            }
            return View(contas);
        }

        // POST: Contas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContasId,Fornecedor,Dtvencimento,Dtpagamento,Pago,Descricao,Valor")] Contas contas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contas);
        }

        // GET: Contas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contas contas = db.Contas.Find(id);
            if (contas == null)
            {
                return HttpNotFound();
            }
            return View(contas);
        }

        // POST: Contas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contas contas = db.Contas.Find(id);
            db.Contas.Remove(contas);
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
