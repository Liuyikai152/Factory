using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;
using Newtonsoft.Json;
namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Facility")]
    public class FacilityController : ApiController
    {
        public IFacilityServices FacilityServices { get; set; }

        private const int PAGESIZE = 4;
        /// <summary>
        /// 查看所有零件
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        [Route("GetFacility")]
        public List<FacilityNotMapp> GetFacility()
        {

            var facilitylist = FacilityServices.GetFacility();
            return facilitylist;

        }
    }
}
