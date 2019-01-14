using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.Model;
using SmartFactory.Services;
using SmartFactory.IServices;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Host")]
    public class HostController : ApiController
    {
        
        public IHostServices hostServices { get; set; }

        /// <summary>
        /// 查询所有主机/附机
        /// </summary>
        /// <returns></returns>
        [Route("GetHost")]
        [HttpGet]
        public List<Host> GetHost(string PNumber)
        {
            var hostList = hostServices.GetHost(PNumber);
            return hostList;
        }

        /// <summary>
        /// 查询所有主机/附机
        /// </summary>
        /// <returns></returns>
        [Route("GetUnitHost")]
        [HttpGet]
        public List<Host> GetUnitHost(string uNumber)
        {
            var hostList = hostServices.GetUnitHost(uNumber);
            return hostList;
        }
    }
}
