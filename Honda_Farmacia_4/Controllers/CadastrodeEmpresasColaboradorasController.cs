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
    public class CadastrodeEmpresasColaboradorasController : Controller
    {
        private Connect db = new Connect();

        // GET: CadastrodeEmpresasColaboradoras
        public async Task<ActionResult> Index()
        {
            return View(await db.CadastrodeEmpresasColaboradoras.ToListAsync());
        }

        // GET: CadastrodeEmpresasColaboradoras/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras = await db.CadastrodeEmpresasColaboradoras.FindAsync(id);
            if (cadastrodeEmpresasColaboradoras == null)
            {
                return HttpNotFound();
            }
            return View(cadastrodeEmpresasColaboradoras);
        }

        // GET: CadastrodeEmpresasColaboradoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastrodeEmpresasColaboradoras/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdEmpresa,Empresa,CNPJ,Data")] CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras)
        {
            if (ModelState.IsValid)
            {
                db.CadastrodeEmpresasColaboradoras.Add(cadastrodeEmpresasColaboradoras);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cadastrodeEmpresasColaboradoras);
        }

        // GET: CadastrodeEmpresasColaboradoras/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras = await db.CadastrodeEmpresasColaboradoras.FindAsync(id);
            if (cadastrodeEmpresasColaboradoras == null)
            {
                return HttpNotFound();
            }
            return View(cadastrodeEmpresasColaboradoras);
        }

        // POST: CadastrodeEmpresasColaboradoras/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdEmpresa,Empresa,CNPJ,Data")] CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastrodeEmpresasColaboradoras).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cadastrodeEmpresasColaboradoras);
        }

        // GET: CadastrodeEmpresasColaboradoras/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras = await db.CadastrodeEmpresasColaboradoras.FindAsync(id);
            if (cadastrodeEmpresasColaboradoras == null)
            {
                return HttpNotFound();
            }
            return View(cadastrodeEmpresasColaboradoras);
        }

        // POST: CadastrodeEmpresasColaboradoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CadastrodeEmpresasColaboradoras cadastrodeEmpresasColaboradoras = await db.CadastrodeEmpresasColaboradoras.FindAsync(id);
            db.CadastrodeEmpresasColaboradoras.Remove(cadastrodeEmpresasColaboradoras);
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
