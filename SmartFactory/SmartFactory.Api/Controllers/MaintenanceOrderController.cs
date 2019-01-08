using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using SmartFactory.Model;
using SmartFactory.IServices;
using SmartFactory.Services;
using Newtonsoft.Json;

namespace SmartFactory.Api.Controllers
{

    /// <summary>
    /// 维修工单
    /// </summary>
    [RoutePrefix("MaintenanceOrder")]
    public class MaintenanceOrderController : ApiController
    {

        public IMaintenanceOrderServices maintenanceOrderServices { get; set; }

       public const int  PAGESIZE=3;
        /// <summary>
        /// 显示所有维修工单
        /// </summary>
        /// <returns></returns>
        [Route("GetMaintenanceOrders")]
        [HttpGet][HttpPost]
        public PageBox GetMaintenanceOrders(string UnitOrPump,int PageIndex=1)
        {
            if (UnitOrPump == null) {
                UnitOrPump = "";
            }

            PageBox pageBox = new PageBox();
            List<MaintenanceOrderNotMap> mainlist = maintenanceOrderServices.GetMaintenanceOrders(UnitOrPump);
            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = mainlist.Count / PAGESIZE + (mainlist.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = mainlist.Skip((PageIndex-1)*PAGESIZE).Take(PageIndex);
            return pageBox;
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
