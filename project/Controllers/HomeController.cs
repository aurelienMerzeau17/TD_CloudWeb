using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using project.Models; 

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Currencies cu = new Currencies();
            return View(cu);
        }
    }
}
