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
        public const int PAGESIZE = 3;
        /// <summary>
        /// 根据条件查询机泵所有主机/附机
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

        /// <summary>
        /// 添加机组
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        [Route("AddHost")]
        [HttpPost]
        public int AddHost(Host host)
        {
            var i = hostServices.AddHost(host);
            return i;
        }

        /// <summary>
        /// 删除主机/附机
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DeleteHost")]
        [HttpGet]
        public int DeleteHost(int id)
        {
            var i = hostServices.DeleteHost(id);
            return i;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        [Route("UpdateHost")]
        [HttpPost]
        public int UpdateHost(Host host)
        {
            host.DateChanged = DateTime.Now;
            host.StartDate = DateTime.Now;
            var i = hostServices.UpdateHost(host);
            return i;
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public Host GetByID(int id)
        {
            var host = hostServices.GetByID(id);
            return host;
        }

        /// <summary>
        /// 查询所有主机/附机
        /// </summary>
        /// <returns></returns>
        [Route("GetHosts")]
        [HttpGet]
        public PageBox GetHosts(int page=1)
        {
            var hostList = hostServices.GetHosts();
            PageBox pageBox = new PageBox();
            pageBox.PageIndex = page;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = hostList.Count / PAGESIZE + (hostList.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = hostList.Skip((page - 1) * PAGESIZE).Take(PAGESIZE);         
            return pageBox;
        }

        /// <summary>
        /// 根据条件查询主机或附机
        /// </summary>
        /// <returns></returns>
        [Route("GetHostType")]
        [HttpGet]
        public List<Host> GetHostType(string hostType)
        {

            var hostList =hostServices.GetHostType(hostType);
            return hostList;
        }
    }
}
