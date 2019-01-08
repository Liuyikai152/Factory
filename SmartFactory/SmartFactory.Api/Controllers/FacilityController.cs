using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;
namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Facility")]
    public class FacilityController : ApiController
    {
        public IFacilityServices FacilityServices { get; set; }
        /// <summary>
        /// 查看所有零件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFacility")]
        public List<Facility> GetFacility()
        {

            var getFacility = FacilityServices.GetFacility();
            return getFacility;
        }
        
        /// <summary>
        /// 根据ID查一个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetById")]
        public FacilityNotMapp GetById(int id)
        {
            var falist = FacilityServices.GetById(id);
            return falist;
        }
    }
}
