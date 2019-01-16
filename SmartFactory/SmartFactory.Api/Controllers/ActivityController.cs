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

        /// <summary>
        /// 修改审批状态
        /// </summary>
        /// <param name="facility"></param>
        /// <returns></returns>
        [Route("UpdateState")]
        [HttpGet]
        public int UpdateState(int ID, int trueState, int state)
        {
            var i = activityServices.UpdateState(ID,trueState, state);
            return i;
        }

        /// <summary>
        /// 驳回审批状态
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="trueState"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UpdateNoState")]
        public int UpdateNoState(int ID, int trueState)
        {
            var i = activityServices.UpdateNoState(ID, trueState);
            return i;
        }

    }
}
