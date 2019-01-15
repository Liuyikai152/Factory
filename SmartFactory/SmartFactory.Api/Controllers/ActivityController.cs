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

    [RoutePrefix("Activity")]
    public class ActivityController : ApiController
    {
        public IActivityServices activityServices { get; set; }

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        [Route("GetActivities")]
        [HttpGet]
        public List<ActivityNotMappit> GetActivities(string name, string state)
        {
            var ActivityList = activityServices.GetActivities(name,state);
            return ActivityList;
        }

    }
}
