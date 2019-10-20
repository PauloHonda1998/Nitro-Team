using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Honda_Farmacia_4.Controllers
{
    public class FarmaceuticoesController : Controller
    {
        private Connect db = new Connect();

        // GET: Farmaceuticoes
        public async Task<ActionResult> Index()
        {
            return View(await db.Farmaceutico.ToListAsync());
        }

        // GET: Farmaceuticoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmaceutico farmaceutico = await db.Farmaceutico.FindAsync(id);
            if (farmaceutico == null)
            {
                return HttpNotFound();
            }
            return View(farmaceutico);
        }

        // GET: Farmaceuticoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmaceuticoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CNPJ,CRF,Senha,Nome,CPF,CEP")] Farmaceutico farmaceutico)
        {
            if (ModelState.IsValid)
            {
                db.Farmaceutico.Add(farmaceutico);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(farmaceutico);
        }

        // GET: Farmaceuticoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmaceutico farmaceutico = await db.Farmaceutico.FindAsync(id);
            if (farmaceutico == null)
            {
                return HttpNotFound();
            }
            return View(farmaceutico);
        }

        // POST: Farmaceuticoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CNPJ,CRF,Senha,Nome,CPF,CEP")] Farmaceutico farmaceutico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmaceutico).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(farmaceutico);
        }

        // GET: Farmaceuticoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmaceutico farmaceutico = await db.Farmaceutico.FindAsync(id);
            if (farmaceutico == null)
            {
                return HttpNotFound();
            }
            return View(farmaceutico);
        }

        // POST: Farmaceuticoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Farmaceutico farmaceutico = await db.Farmaceutico.FindAsync(id);
            db.Farmaceutico.Remove(farmaceutico);
            await db.SaveChangesAsync();
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
