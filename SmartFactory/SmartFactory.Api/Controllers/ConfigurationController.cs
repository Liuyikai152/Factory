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

    [RoutePrefix("Configuration")]
    public class ConfigurationController : ApiController
    {
        public IConfigurationsServices configurationsServices { get; set; }

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetConfiguration")]
        public List<ConfigurationNotMapped> GetConfiguration()
        {
            var figurationList = configurationsServices.Getfiguration();
            return figurationList;
        }

        /// <summary>
        /// 添加审批流程配置
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        [Route("AddConfiguration")]
        [HttpPost]
        public int AddConfiguration(Configuration configuration)
        {
            var i = configurationsServices.AddConfiguration(configuration);
            return i;
        }

        /// <summary>
        /// 删除审批活动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteConfiguration")]
        public int DeleteConfiguration(int id)
        {
            var i = configurationsServices.DeleteConfiguration(id);
            return i;
                
        }
    }
}
