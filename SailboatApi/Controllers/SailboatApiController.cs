using DataTier.Repositories;
using SailboatApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SailboatApi.Controllers
{
    public class SailboatApiController : ApiController
    {
        private readonly ISailboatDbRepository _repository;

        public SailboatApiController(ISailboatDbRepository sailboatDbRepository)
        {
            _repository = sailboatDbRepository;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var sailboats = _repository.GetSailboats();

            var sailboatViewModels = new List<Sailboat>();
            foreach (var sailboat in sailboats)
            {
                var model = new Sailboat
                {
                    SailboatId = sailboat.SailboatId,
                    Name = sailboat.Name,
                    Type = sailboat.Type,
                    WaterLineLengthInFeet = sailboat.WaterLineLengthInFeet,
                    MaxHullSpeed = sailboat.MaxHullSpeed
                };

                sailboatViewModels.Add(model);
            }

            //return sailboatViewModels;
            return Ok(new { results = sailboatViewModels });
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}