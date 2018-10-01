using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using Archery.Data;
using Archery.Models;
using Archery.Tools;
using System.Security.Cryptography;

namespace Archery.Controllers
{
    public class ArchersController : BaseController
    {
        
        
        //metodo que vai representar uma acao
        // GET: Archer
        public ActionResult Subscribe()
        {
            return View();
        }
        // POST: Archer
        [HttpPost]
        [ValidateAntiForgeryToken]//seguranca olhar form Subscribe
        public ActionResult Subscribe([Bind(Exclude ="ID")]Archer archer)
        {
            //archer.Password = CreateMD5(archer.Password);
            
            if (DateTime.Now.AddYears(-9) <= archer.BirthDate)
            {
                /* 1
                ViewBag.Erreur = "Error Date";
                return View();
                */
                //2
                //ModelState.AddModelError("BirthDate","Date de naissance invalide");
            }
            
            if(ModelState.IsValid)
            {
                //archer.Password = Extension.HashMD(archer.Password);
                /*
                if(db.Archers.Count(x=>x.Mail == archer.Mail) != 0)
                {
                    Display("Vous avez déjà un compte assigné à cet email");
                    return View();
                }
                else
                {
                    archer.Password = archer.Password.HashMD();
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Archers.Add(archer);
                    db.SaveChanges();
                    db.Configuration.ValidateOnSaveEnabled = true;
                    Display("Archer enregistré");
                } */
                archer.Password = archer.Password.HashMD();
                db.Configuration.ValidateOnSaveEnabled = false;
                db.Archers.Add(archer);
                db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
                Display("Archer enregistré");
                //ViewBag.Message = "Contact Ajouter";
                //GestionMessage("ok");
                //TempData["typeMessage"] = "ok";
                //TempData["typeMessage"] = new Message(0, "Contact Ajouter");

                return RedirectToAction("index", "home");
            }
            else
            {
                //GestionMessage("error");
                //TempData["typeMessage"] = "error";
                Display("Archer PAS enregistré",Tools.MessageType.ERROR);
                
            }
            //string.Format("teste");
            
            return View();
        }
    }
}