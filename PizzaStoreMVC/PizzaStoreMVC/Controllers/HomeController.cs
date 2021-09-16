using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaDbData;
using PizzaRepository.Classes;

namespace PizzaStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        UserRepository userRepo;
        public HomeController()
        {
            userRepo = new UserRepository(new PizzaDb());
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public string GetUser()
        {
            var data = userRepo.GetAllUser();
            string str = "";
            foreach(var d in data)
            {
                str += d.Name + " ";
                Console.WriteLine(d.id+ " "+d.Name+" "+" "+d.Gender+" "+d.email);
            }
            return "Data Fetched successfully <br>"+str;
        }
        public string GetUserById(int id)
        {
            var data = userRepo.GetUserById(id);
            string str = "";
            if (data != null)
                str += data.id + " " + data.Name + " " + data.Gender + " " + data.email;
            else
                str = "No record found";
            return str;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}