using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using SmartFactory.Model;
using SmartFactory.IServices;
using SmartFactory.Services;


namespace SmartFactory.Api.Controllers
{

    /// <summary>
    /// 维修工单
    /// </summary>
    [RoutePrefix("MaintenanceOrder")]
    public class MaintenanceOrderController : ApiController
    {

        public IMaintenanceOrderServices maintenanceOrderServices { get; set; }

        /// <summary>
        /// 显示所有维修工单
        /// </summary>
        /// <returns></returns>
        [Route("GetMaintenanceOrders")]
        [HttpGet]
        public List<MaintenanceOrderNotMap> GetMaintenanceOrders()
        {
            var mainlist = maintenanceOrderServices.GetMaintenanceOrders();
            return mainlist;
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetById")]
        [HttpGet]
        public MaintenanceOrderNotMap GetById(int id)
        {
            var i = maintenanceOrderServices.GetById(id);
            return i;
        }

    }
}
