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
        /// 查询功能位置信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLocaTions")]
        public List<LocationNotMapped> GetLocaTions()
        {
            var locaTionList = localionServices.GetLocations();
            return locaTionList;
        }

        /// <summary>
        /// 查看单个位置详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLocationById")]
        public LocationNotMapped GetLocationById(int id)
        {
            var i = localionServices.GetLocationById(id);
            return i;
        }
    }
}
