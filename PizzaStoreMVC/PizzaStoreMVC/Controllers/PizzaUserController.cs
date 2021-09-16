using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Controllers
{
    public class PizzaUserController : Controller
    {
        // GET: PizzaUser
        public ActionResult Index()
        {
            return View();
        }
    }
}