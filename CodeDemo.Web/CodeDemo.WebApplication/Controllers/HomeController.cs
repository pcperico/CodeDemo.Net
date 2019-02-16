using AutoShopSystemManagement.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeDemo.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleRepository _peopleRepository;
        public HomeController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public ActionResult Index()
        {
            var x= _peopleRepository.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}