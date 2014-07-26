using BasicRepositoryPattern.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicRepositoryPattern.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel() 
            {
                UserCount = UOW.UserRepository.GetUserCount(),
                RoleCount = UOW.RoleRepository.GetRoleCount(),
                ActiveUsers = UOW.UserRepository.GetActiveUsers()
            };

            return View(viewModel);
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