using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFactory.Api.Controllers
{
    using SmartFactory.IServices;
    using SmartFactory.Model;
    using SmartFactory.Services;

    [RoutePrefix("Status")]
    public class StatusController : ApiController
    {
        public IStatusServices statusServices { get; set; }

        /// <summary>
        /// 显示审批状态
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStatus")]
        public List<Status> GetStatus()
        {
            var statusList = statusServices.GetStatus();
            return statusList;
        }
    }
}
