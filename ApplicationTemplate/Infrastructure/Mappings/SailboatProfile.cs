using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationTemplate.Models;
using AutoMapper;
using BusinessTier;
using DataTier;

namespace ApplicationTemplate.Infrastructure.Mappings
{
    public class SailboatProfile : Profile
    {
        public SailboatProfile()
        {
            CreateMap<SailboatModel, SailboatDto>();
        }
    }
}