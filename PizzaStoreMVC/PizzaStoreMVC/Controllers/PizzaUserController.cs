﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaRepository.Classes;
using PizzaDbData;

namespace PizzaStoreMVC.Controllers
{
    public class PizzaUserController : Controller
    {
        UserRepository userRepo;
        public PizzaUserController()
        {
            userRepo = new UserRepository(new PizzaDb());
        }
        // GET: PizzaUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllUser()
        {
            var data = userRepo.GetAllUser();
            return View(data.ToList());
        }
        public ActionResult GetUserById(int id)
        {
            var data = userRepo.GetUserById(id);
            return View(Models.Mapper.Map(data));
        }
        public string DeleteUserById(int id)
        {
            string str = userRepo.DeleteUserById(id);
            return str;
        }
    }
}