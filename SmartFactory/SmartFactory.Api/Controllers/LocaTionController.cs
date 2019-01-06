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
    [RoutePrefix("LocaTion")]
    public class LocaTionController : ApiController
    {
        public ILocalionServices localionServices { get; set; }

        /// <summary>
        /// 查询所有公司编号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLocaTion")]
        public List<LocaTion> GetLocaTion()
        {
            var locaTionList = localionServices.GetLocations();
            return locaTionList;
        }
    }
}
