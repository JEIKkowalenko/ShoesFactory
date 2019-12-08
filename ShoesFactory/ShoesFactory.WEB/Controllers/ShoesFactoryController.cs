using AutoMapper;
using ShoesFactory.BLL.DTO;
using ShoesFactory.BLL.Interfaces;
using ShoesFactory.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesFactory.WEB.Controllers
{
    public class ShoesFactoryController : Controller
    {
        ISupplyService supplyService;       
        public ShoesFactoryController(ISupplyService splServ)
        {
            supplyService = splServ;
        }
        public ActionResult Supplies()
        {
            IEnumerable<SupplyDTO> supplyDtos = supplyService.GetAllSupplies();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplyDTO, SupplyViewModel>()).CreateMapper();
            var supplies = mapper.Map<IEnumerable<SupplyDTO>, List<SupplyViewModel>>(supplyDtos);
            return View(supplies);
        }
        public ActionResult AddSupply(SupplyViewModel model)
        {
            supplyService.AddSupply(new MaterialDTO(model.MaterialName, ""), model.SupplierName, model.Count, model.Price);
            return RedirectToAction("Supplies", supplyService.GetAllSupplies());
        }
        [HttpGet]
        public JsonResult GetSupply(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplyDTO, SupplyViewModel>()).CreateMapper();
            var supply = mapper.Map<SupplyDTO, SupplyViewModel>(supplyService.GetSupply(id));
            var jsondata = supply;
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult DeleteSupply(int id)
        {
            supplyService.DeleteSupply(id);
            return RedirectToAction("Supplies");
        }
        public ActionResult Materials()
        {
            IEnumerable<MaterialDTO> materialDtos = supplyService.GetAllMaterials();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MaterialDTO, MaterialViewModel>()).CreateMapper();
            var materials = mapper.Map<IEnumerable<MaterialDTO>, List<MaterialViewModel>>(materialDtos);
            return View(materials);
        }
        public ActionResult AddMaterial(MaterialViewModel material)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MaterialViewModel, MaterialDTO>()).CreateMapper();
            var newMaterial = mapper.Map<MaterialViewModel, MaterialDTO>(material);
            supplyService.AddMaterial(newMaterial);
            return RedirectToAction("Materials");
        }
        [HttpGet]
        public ActionResult DeleteMaterial(int id)
        {
           supplyService.DeleteMaterial(id);
            var x = supplyService.GetAllSupplies();
           return RedirectToAction("Materials");
        }

        [HttpGet]
        public JsonResult GetMaterial(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MaterialDTO, MaterialViewModel>()).CreateMapper();
            var material = mapper.Map<MaterialDTO, MaterialViewModel>(supplyService.GetMaterial(id));
            var jsondata = material;
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Suppliers()
        {
            IEnumerable<SupplierDTO> supplierDtos = supplyService.GetAllSuppliers();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplierDTO, SupplierViewModel>()).CreateMapper();
            var suppliers = mapper.Map<IEnumerable<SupplierDTO>, List<SupplierViewModel>>(supplierDtos);
            return View(suppliers);
        }
        public ActionResult AddSupplier(SupplierViewModel supplier)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplierViewModel, SupplierDTO>()).CreateMapper();
            var newSupplier = mapper.Map<SupplierViewModel, SupplierDTO>(supplier);
            supplyService.AddSupplier(newSupplier);
            return RedirectToAction("Suppliers");
        }
        [HttpGet]
        public ActionResult DeleteSupplier(int id)
        {
            supplyService.DeleteSupplier(id);
            var x = supplyService.GetAllSuppliers();
            return RedirectToAction("Suppliers");
        }

        [HttpGet]
        public JsonResult GetSupplier(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplierDTO, SupplierViewModel>()).CreateMapper();
            var supplier = mapper.Map<SupplierDTO, SupplierViewModel>(supplyService.GetSupplier(id));
            var jsondata = supplier;
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
    }
}