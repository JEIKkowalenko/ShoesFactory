using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesFactory.BLL.Interfaces;
using ShoesFactory.BLL;
using ShoesFactory.BLL.DTO;
using ShoesFactory.DAL;
using ShoesFactory.DAL.EF;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.Repositories;
using ShoesFactory.BLL.Services;

namespace ShoesFactory.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EFUnitOfWork db = new EFUnitOfWork("Default Connection");
            SupplyService supplyService = new SupplyService(db);
            //ShoesService shoesService = new ShoesService(db);
            //supplyService.AddSupply(new MaterialDTO("Lether", "дупа"), "Apple corp",20, 14.3);
            //supplyService.AddSupply(new MaterialDTO("Lether", "дупа"), "Apple corp", 20, 15.3);
            //IDictionary<int, int> materials = new Dictionary<int, int>();
            //materials.Add(1, 20);          
            //shoesService.AddShoes("Ugg", "Gnomiki", materials);
            //ViewBag.data = db.Shoes.GetAll();
            //ViewBag.countLether = db.Materials.Get(1).Count;
            ViewBag.materials = db.Materials.GetAll();
            return View();
        }
        public ActionResult Materials()
        {
            EFUnitOfWork db = new EFUnitOfWork("Default Connection");
            SupplyService supplyService = new SupplyService(db);
            
            return PartialView();
        }
    }
}