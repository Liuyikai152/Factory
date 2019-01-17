using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.Model;
using SmartFactory.IServices;
using SmartFactory.Services;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("BitNumber")]
    public class BitNumberController : ApiController
    {
        public IBitNumberServices bitNumberServices { get; set; }

        /// <summary>
        /// 查看设备位号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFacilityType")]
        public List<BitNumber> GetFacilityType()
        {
            var getBitNumber = bitNumberServices.GetFacilityType();
            return getBitNumber.ToList();
        }
    }
}
