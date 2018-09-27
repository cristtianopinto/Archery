using Archery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class ArchersController : Controller
    {
        //metodo que vai representar uma acao
        // GET: Archer
        public ActionResult Subscribe()
        {
            return View();
        }
        // POST: Archer
        [HttpPost]
        public ActionResult Subscribe(Archer archer)
        {        
            
            if(DateTime.Now.AddYears(-9) <= archer.BirthDate)
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

            }
            //string.Format("teste");
            
            return View();
        }
    }
}