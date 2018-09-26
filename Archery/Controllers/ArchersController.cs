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
            
            return View();
        }
    }
}