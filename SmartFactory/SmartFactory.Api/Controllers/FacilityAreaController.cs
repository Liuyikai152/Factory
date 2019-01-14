using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Services;
using SmartFactory.Model;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("FacilityArea")]
    public class FacilityAreaController : ApiController
    {
        public IFactoryAreaServices factoryAreaServices { get; set; }

        [HttpGet]
        [Route("GetFactoryAreas")]
        public List<FactoryArea> GetFactoryAreas()
        {
            var factoryAreaList = factoryAreaServices.GetFactoryAreas();
            return factoryAreaList;
        }

    }
}
