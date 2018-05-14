using ApplicationTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DataTier.Repositories;

namespace ApplicationTemplate.Controllers
{
    public class SailboatController : Controller
    {
        private readonly ISailboatDbRepository _repository;

        public SailboatController(ISailboatDbRepository repository)
        {
            _repository = repository;
        }

        // GET: Sailboat
        public ActionResult Index()
        {
            var allSailboats = _repository.GetSailboats();

            var sailboatViewModels = new List<SailboatModel>();
            foreach (var sailboat in allSailboats)
            {
                var model = new SailboatModel
                {
                    SailboatId = sailboat.SailboatId,
                    Name = sailboat.Name,
                    Type = sailboat.Type,
                    WaterLineLengthInFeet = sailboat.WaterLineLengthInFeet,
                    MaxHullSpeed = sailboat.MaxHullSpeed
                };

                sailboatViewModels.Add(model);
            }

            return View(sailboatViewModels);
        }

        public ActionResult Add()
        {
            var model = new SailboatModel();

            return View("Add", model);
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Add(SailboatModel sailboatModel)
        {
            var sailboatDto = Mapper.Map<BusinessTier.SailboatDto>(sailboatModel);
            sailboatDto.CalculateMaxHullSpeed();

            _repository.Save(sailboatDto);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult GetSailboatById(int id)
        {
            var sailboat = _repository.GetSailboatById(id);

            if (sailboat == null)
            {
                //return View()
            }

            var sailboatVM = new SailboatModel
            {
                Name = sailboat.Name,
                Type = sailboat.Type,
                WaterLineLengthInFeet = sailboat.WaterLineLengthInFeet,
                MaxHullSpeed = sailboat.MaxHullSpeed,
                SailboatId = sailboat.SailboatId
            };

            //return PartialView("_EditSailboatView", sailboatVM);
            return Json(sailboatVM);
        }
    }
}