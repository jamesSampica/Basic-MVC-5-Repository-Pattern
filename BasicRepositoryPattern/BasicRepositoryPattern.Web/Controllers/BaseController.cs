using BasicRepositoryPattern.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicRepositoryPattern.Business.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;

namespace BasicRepositoryPattern.Web.Controllers
{
    public class BaseController : Controller
    {

        public UnitOfWork UOW { get; private set; }
        public UserManager<AspNetUser> UserManager { get; private set; }

        public BaseController()
        {
            var context = new MyModelContainer();
            UOW = new UnitOfWork(context);
            UserManager = new UserManager<AspNetUser>(new UserStore<AspNetUser>(context));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && UserManager != null)
            {
                UserManager.Dispose();
                UserManager = null;
            }
            base.Dispose(disposing);
        }
    }
}