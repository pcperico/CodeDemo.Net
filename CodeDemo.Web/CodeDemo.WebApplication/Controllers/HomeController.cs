
using CodeDemo.BusinessRules.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeDemo.BusinessRules.Models;
using CodeDemo.Data.Entities;
using CodeDemo.Data.Repositories.Interfaces;

namespace CodeDemo.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPeopleService _peopleService;
        private readonly IUserRepository _userRepository;


        public HomeController(IPeopleService peopleService,IUserRepository userRepository)
        {
            _peopleService = peopleService;
            _userRepository = userRepository;
        }
        public ActionResult Index()
        {
            var model = _userRepository.GetAll();
            return View(model);
        }
       
        public ActionResult CreateEditPeople()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult CreateEditPeople(UserModel model)
        {
            _peopleService.CreatePeopleAndUser(model);
            return RedirectToAction("Index");
        }

        public bool DeleteUser(int id)
        {
            return _peopleService.DeleteUser(id);
        }

        public ActionResult EditUser(int id)
        {
            var model = _peopleService.EditUser(id);
            return View("CreateEditPeople", model);
        }


    }
}