using ShoesFactory.BLL.DTO;
using ShoesFactory.BLL.Interfaces;
using ShoesFactory.BLL.Services;
using ShoesFactory.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesFactory.WEB.Controllers
{
    public class SupplyController : Controller
    {
        ISupplyService supplyService;
        public SupplyController(ISupplyService supplServ)
        {
            supplyService = supplServ;
        }
        // GET: Supply
        public ActionResult Index()
        {
            supplyService.AddSupply(new MaterialDTO("Lether", "дупа"), "Apple corp", 20, 14.3);
            supplyService.AddSupply(new MaterialDTO("Lether", "дупа"), "Apple corp", 20, 15.3);
            ViewBag.data = supplyService.GetAllSupplies();
            return View();
        }

        // GET: Supply/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supply/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supply/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supply/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Supply/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supply/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Supply/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
