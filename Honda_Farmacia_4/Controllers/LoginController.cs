using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Honda_Farmacia_4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Autherize(Farmaceutico login)
        {
            using (Connect db = new Connect())
            {
                Farmaceutico acessoDetails = db.Farmaceutico.Where(x => x.Nome == login.Nome && x.Senha == login.Senha).FirstOrDefault();
                if (acessoDetails == null)
                {
                    
                    return View("Index", login);
                }
                else
                {

                    return RedirectToAction("Index", "Home");
                }
            }

        }
    }
}