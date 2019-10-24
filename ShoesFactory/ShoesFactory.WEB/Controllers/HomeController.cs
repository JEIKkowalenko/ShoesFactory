using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesFactory.DAL;
using ShoesFactory.DAL.EF;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.Repositories;

namespace ShoesFactory.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ShoesContext db = new ShoesContext("Default Connection");
            ViewBag.data =  db.Shoes.Where(e => e.Id == db.TableOfDimensions.Where(k => k.Size.Sex == "male").FirstOrDefault().Id);
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