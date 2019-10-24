using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesFactory.DAL;
using ShoesFactory.DAL.Repositories;

namespace ShoesFactory.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new EFUnitOfWork("Default Connection");           
            ViewBag.data = db.Materials.GetAll();
            db.Save();
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