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
    public class ComprasController : Controller
    {
        private Connect db = new Connect();

        // GET: Compras
        public async Task<ActionResult> Index()
        {
            var compras = db.Compras.Include(c => c.Farmaceutico);
            return View(await compras.ToListAsync());
        }

        // GET: Compras/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compra compra = await db.Compras.FindAsync(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // GET: Compras/Create
        public ActionResult Create()
        {
            ViewBag.FarmaceuticoId = new SelectList(db.Farmaceutico, "Id", "CNPJ");
            ViewBag.ProdutosId = new SelectList(db.Produto, "IdProdutos", "Nome");
            ViewBag.Codigo_de_Barra = new SelectList(db.Produto, "Codigo_de_Barra", "Nome");
            return View();
        }

        // POST: Compras/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FarmaceuticoId,ProdutosId,DataCompra,Quantidade")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                db.Compras.Add(compra);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FarmaceuticoId = new SelectList(db.Farmaceutico, "Id", "CNPJ", compra.FarmaceuticoId);
            ViewBag.ProdutosId = new SelectList(db.Produto, "IdProdutos", "Nome", compra.ProdutosId);
            ViewBag.Codigo_de_Barra = new SelectList(db.Produto, "Codigo_de_Barra", "Nome", compra.ProdutosId);
            return View(compra);
        }

        // GET: Compras/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compra compra = await db.Compras.FindAsync(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarmaceuticoId = new SelectList(db.Farmaceutico, "Id", "CNPJ", compra.FarmaceuticoId);
            ViewBag.ProdutosId = new SelectList(db.Produto, "IdProdutos", "Nome", compra.ProdutosId);
            ViewBag.Codigo_de_Barra = new SelectList(db.Produto, "Codigo_de_Barra", "Nome", compra.ProdutosId);
            return View(compra);
        }

        // POST: Compras/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FarmaceuticoId,ProdutosId,DataCompra,Quantidade")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compra).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FarmaceuticoId = new SelectList(db.Farmaceutico, "Id", "CNPJ", compra.FarmaceuticoId);
            ViewBag.ProdutosId = new SelectList(db.Produto, "IdProdutos", "Nome", compra.ProdutosId);
            ViewBag.Codigo_de_Barra = new SelectList(db.Produto, "Codigo_de_Barra", "Nome", compra.ProdutosId);
            return View(compra);
        }

        // GET: Compras/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compra compra = await db.Compras.FindAsync(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Compra compra = await db.Compras.FindAsync(id);
            db.Compras.Remove(compra);
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
