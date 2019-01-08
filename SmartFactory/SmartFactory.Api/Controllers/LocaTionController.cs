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
        public PageBox GetLocaTions(int PAGESIZE=5,int page=1)
        {
            List<LocationNotMapped> list = localionServices.GetLocations();
            PageBox pageBox = new PageBox();
            pageBox.PageIndex = page;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount=list.Count / PAGESIZE + (list.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data= list.Skip((page - 1) * PAGESIZE).Take(PAGESIZE);
            return pageBox;
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
