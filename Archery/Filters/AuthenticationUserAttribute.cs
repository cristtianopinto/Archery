using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Archery.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class AuthenticationUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
            if (filterContext.HttpContext.Session["USER"] == null)
            {
                filterContext.Result = new RedirectResult(@"\authenticationuser\login");
                //filterContext.Result = new RedirectToRouteResult(new { controller="authentication",action="login",area="backoffice"});
            }
        }
    }
}