using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationTemplate.Infrastructure.Mappings;
using ApplicationTemplate.Models;
using AutoMapper;
using BusinessTier;

namespace ApplicationTemplate.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<SailboatProfile>();
            });

            //Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}