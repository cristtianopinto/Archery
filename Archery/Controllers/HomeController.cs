using Archery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
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
        
    }
}