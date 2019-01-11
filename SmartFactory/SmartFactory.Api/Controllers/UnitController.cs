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
    [RoutePrefix("Unit")]
    public class UnitController : ApiController
    {
        public IUnitServices UnitServices { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnit")]
        public List<UnitNotMapped> GetUnit()
        {
            var untpList = UnitServices.GetHost();
            return untpList;
        }
    }
}
