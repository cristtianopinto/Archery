using Archery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
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