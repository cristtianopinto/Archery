using Archery.Models;
using Archery.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class AuthenticationUserController : BaseController
    {
        // GET: BackOffice/Authentication
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthenticationUserViewModels model)
        {
           if (ModelState.IsValid)
            {
                var hash = model.Password.HashMD();
                var user = db.Archers.SingleOrDefault(
                    x => x.Mail == model.Mail && x.Password == hash);
                if (user == null)
                {
                    ModelState.AddModelError("Mail", "Login / mot de passe invalide");
                    return View();//todo json
                    //return Json(user);
                }
                else
                {
                    Session["USER"] = user;
                    //return Json(user);
                     return RedirectToAction("Index", "Home", new { area = "" });//todo json
                }
            }
            return View();
        }
        
        public ActionResult Logout()
        {
            Session.Remove("USER");
            return RedirectToAction("index", "home", new { area = "" });
        }
    }
}