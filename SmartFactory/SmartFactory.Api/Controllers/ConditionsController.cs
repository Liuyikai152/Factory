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

    [RoutePrefix("Conditions")]
    public class ConditionsController : ApiController
    {
        public IConditionsServices conditionsServices { get; set; }

        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetConditions")]
        public List<Conditions> GetConditions()
        {
            var conditionsList = conditionsServices.GetConditions();
            return conditionsList;
        }
    }
}
