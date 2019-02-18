
using CodeDemo.BusinessRules.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeDemo.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleService _peopleService;
        public HomeController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult ListPeople()
        {
            var model = _peopleService.GetAllPeople();
            return View(model);
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