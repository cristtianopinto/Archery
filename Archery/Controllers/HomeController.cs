using Archery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["test"] = "rtest";//creation d'un session
            ViewBag.Title = "Index"; 
            return View(db.Tournaments.Include("Weapons").Include("Pictures").OrderBy(x=>x.StartDate).ToList());
        }

        //[Route("a-propos")]
        public ActionResult About()
        {            
            var modelInfo = new Info
            {
                DevName = "PINTO",
                ContactMail = "cris@email.com",
                CreatedDate = DateTime.Today
            };
            return View(modelInfo);
        }

        //[Route("a-propos")]
        //public ActionResult Details(int? id)
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Include("Pictures").Include("Weapons").SingleOrDefault(x => x.ID == id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);            
        }

    }
}