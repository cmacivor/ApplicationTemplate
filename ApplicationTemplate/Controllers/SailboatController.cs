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
            return View();
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

            //var dbObject = new DataTier.EF.Models.Sailboat
            //{
            //    Name = sailboatDto.Name,
            //    Type = sailboatDto.Type,
            //    MaxHullSpeed = Convert.ToDecimal(sailboatDto.MaxHullSpeed),
            //    WaterLineLengthInFeet = Convert.ToDecimal(sailboatDto.WaterLineLengthInFeet)
            //};

            //_repository.Save(dbObject);

            _repository.Save(sailboatDto);

            return RedirectToAction("Index");
        }
    }
}