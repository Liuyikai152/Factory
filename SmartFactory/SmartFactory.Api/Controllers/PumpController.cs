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
    [RoutePrefix("Pump")]
    public class PumpController : ApiController
    {

        public IPumpServices pumpServices { get; set; }

        /// <summary>
        /// 添加机泵
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddPump")]
        public int AddPump(Pump pump)
        {
            int i= pumpServices.AddPump(pump);
            return i;
        }

        /// <summary>
        /// 删除机泵
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeletePump")]
        public int DeletePump(int id)
        {
            int i = pumpServices.DeletePump(id);
            return i;

        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetByID")]
        public PumpNotMap GetByID(int id)
        {
            var pumpNotMap = pumpServices.GetByID(id);
            return pumpNotMap;
        }
        public const int PAGESIZE= 3;

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPumps")]
        public PageBox GetPumps(int PageIndex=1)
        {
            PageBox pageBox = new PageBox();
            var pumpList = pumpServices.GetPumps();
            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = pumpList.Count / PAGESIZE + (pumpList.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = pumpList.Skip((PageIndex - 1) * PAGESIZE).Take(PAGESIZE);
            return pageBox;
        }

        /// <summary>
        /// 修改警告状态
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdatePump")]
        public int UpdatePump(Pump pump)
        {
            var i = pumpServices.UpdatePump(pump);

            return i;
        }
    }
}
