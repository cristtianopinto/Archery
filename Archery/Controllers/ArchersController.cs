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
                //..
                //TODO .. ajoute archer
                string aux = archer.Password;
                archer.Password = Password.HashMD(aux);
                archer.Password.HashMD();
                db.Archers.Add(archer);
                db.SaveChanges();
                //ViewBag.Message = "Contact Ajouter";
                //GestionMessage("ok");
                //TempData["typeMessage"] = "ok";
                //TempData["typeMessage"] = new Message(0, "Contact Ajouter");
                Display("Archer enregistré");
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